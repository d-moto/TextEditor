using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Web.WebView2.WinForms;
using System.Security.Policy; //webView2の名前空間をインポート
using Microsoft.Web.WebView2.Core;
using System.Net.Http;
using System.Runtime.InteropServices;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        private string CurrentFilePath = null; //現在のファイルパスを保持するためのフィールド
        private WebView2 webView1;
        private WebView2 additionalWebView;

        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(loadWindow); //フォームロード時に呼び出す。
            InitializeTabControl(); //TabControlに関する初期化を呼び出し
            this.tabControl.DrawItem += new DrawItemEventHandler(tabControl_DrawItem);
        }

        // loadWindow関数（現状処理はなし。）
        private void loadWindow(object sender, EventArgs e)
        {
            // 現状なし。
        }

        //******************************************************************************************************************//
        // TextBoxに関する記述                                                                                              //
        //******************************************************************************************************************//
        // START                                                                                                            //
        //******************************************************************************************************************//
        // New
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.Clear(); //textboxのクリア
            CurrentFilePath = null; //file path リセット
        }

        // Open
        private void openOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                CurrentFilePath = openFileDialog.FileName;
                mainTextBox.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        // Save
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CurrentFilePath))
            {
                //ファイルパスがない場合は、「名前を付けて保存」を実行
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                //ファイルパスがあるときは、上書き保存
                File.WriteAllText(CurrentFilePath, mainTextBox.Text);
            }
        }

        // Save as
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, mainTextBox.Text);
                CurrentFilePath = saveFileDialog.FileName; // ファイルパスを更新
            }
        }

        // Close window
        private void closeWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainTextBox.CanUndo)
            {
                mainTextBox.Undo();
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mainTextBox.CanRedo)
            {
                mainTextBox.Redo();
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string searchText = "The string to search for"; // ユーザー入力として実装可能
            int index = mainTextBox.Text.IndexOf(searchText);
            if (index != -1)
            {
                mainTextBox.Select(index, searchText.Length);
                mainTextBox.ScrollToCaret();
            }
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string searchText = "The string to search for"; //ユーザー入力として実装可能
            string replaceText = "The string to replace to"; //ユーザー入力として実装可能
            mainTextBox.Text = mainTextBox.Text.Replace(searchText, replaceText);
        }

        private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                mainTextBox.Font = fontDialog.Font;
            }
        }

        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                mainTextBox.ForeColor = colorDialog.Color;
            }
        }

        private void StartAutoSave()
        {
            Timer timer = new Timer();
            timer.Interval = 60000; // 60sごとに保存
            timer.Tick += (s, e) => StartAutoSave();
            timer.Start();
        }

        private void AutoSave()
        {
            if (!string.IsNullOrEmpty(CurrentFilePath))
            {
                File.WriteAllText(CurrentFilePath, mainTextBox.Text);
            }
        }
        //******************************************************************************************************************//
        // TextBoxに関する記述                                                                                              //
        //******************************************************************************************************************//
        // END                                                                                                              //
        //******************************************************************************************************************//

        //******************************************************************************************************************//
        // Browserに関する記述                                                                                              //
        //******************************************************************************************************************//
        // START                                                                                                            //
        //******************************************************************************************************************//

        // TabControlの初期化
        private void InitializeTabControl()
        {
            additionalWebView = new WebView2();
            additionalWebView.Dock = DockStyle.Fill;

            // tabにwebviewを追加
            tabPage1.Controls.Add(additionalWebView);

            // webview2でgoogleを開く
            additionalWebView.Source = new Uri("https://www.google.co.jp");

            // WebView2が初期化された後に設定を行う
            additionalWebView.CoreWebView2InitializationCompleted += (sender, args) =>
            {
                if (!args.IsSuccess)
                {
                    tabPage1.Text = "Error";
                    return;
                }

                // ページの読み込みが完了した時のイベント
                additionalWebView.CoreWebView2.NavigationCompleted += (navSender, navArgs) =>
                {
                    // タブのタイトルをウェブページのタイトルに設定
                    tabPage1.Text = additionalWebView.CoreWebView2.DocumentTitle;

                    // アイコンの取得
                    UpdateTabIcon(tabPage1, additionalWebView.CoreWebView2);
                };
            };
        }

        // IconのUpdate
        private async void UpdateTabIcon(TabPage tab, CoreWebView2 webView)
        { // debug用
            try
            {
                // JavaScriptでfaviconのURLを取得
                string faviconUrl = await webView.ExecuteScriptAsync("document.querySelector('link[rel=\"icon\"]')?.href;");
                if (string.IsNullOrEmpty(faviconUrl) || !Uri.IsWellFormedUriString(faviconUrl, UriKind.Absolute))
                {
                    // WebページのルートURLを使って絶対パスに変換
                    Uri baseUri = new Uri(webView.Source.ToString());
                    faviconUrl = new Uri(baseUri, "/favicon.ico").ToString();
                }

                if (!string.IsNullOrEmpty(faviconUrl))
                {
                    faviconUrl = faviconUrl.Trim('"'); // ダブルクォートを削除
                    using (HttpClient client = new HttpClient())
                    {
                        // faviconのストリームを取得
                        var stream = await client.GetStreamAsync(faviconUrl);

                        // 取得したデータが有効な画像かどうかを確認
                        using (var image = Image.FromStream(stream))
                        {
                            // アイコンのサイズをリサイズ（16x16など小さいサイズに設定）
                            int iconSize = 16;
                            var resizedIcon = new Bitmap(image, new Size(iconSize, iconSize));

                            // ImageListにアイコンを追加し、タブにアイコンを設定
                            if (imageList1 == null) imageList1 = new ImageList();  // ImageListの初期化
                            imageList1.ImageSize = new Size(iconSize, iconSize);   // ImageListのアイコンサイズを設定

                            // タブコントロールにImageListを関連付ける
                            tabControl.ImageList = imageList1;

                            imageList1.Images.Add(resizedIcon);
                            tab.ImageIndex = imageList1.Images.Count - 1;

                            // ログとしてローカルファイルパスを表示（オプション）
                            string localFilePath = Path.Combine(@"C:\Users\xxxxx\Downloads", $"{new Uri(webView.Source.ToString()).Host}_favicon.ico");
                            resizedIcon.Save(localFilePath, System.Drawing.Imaging.ImageFormat.Icon);
                            Console.WriteLine($"Favicon saved to: {localFilePath}");
                        }
                    }
                }
            }
            catch (ExternalException ex)
            {
                // GDI+ 関連のエラー発生時の処理
                Console.WriteLine($"Failed to get favicon due to GDI+ error: {ex.Message}");
                tab.ImageIndex = -1;
            }
            catch (Exception ex)
            {
                // その他のエラー発生時の処理
                Console.WriteLine($"Failed to get favicon: {ex.Message}");
                tab.ImageIndex = -1;
            }
        }
        //{
        //    try
        //    {
        //        // JavaScriptでfaviconのURLを取得
        //        string faviconUrl = await webView.ExecuteScriptAsync("document.querySelector('link[rel=\"icon\"]')?.href;");
        //        if (string.IsNullOrEmpty(faviconUrl))
        //        {
        //            // FaviconのURLが取得できない場合、ドメインのルートから直接favicon.icoを取得
        //            Uri uri = new Uri(webView.Source.ToString());
        //            faviconUrl = $"{uri.Scheme}://{uri.Host}/favicon.ico";
        //        }

        //        if (!string.IsNullOrEmpty(faviconUrl))
        //        {
        //            faviconUrl = faviconUrl.Trim('"'); // ダブルクォートを削除
        //            using (HttpClient client = new HttpClient())
        //            {
        //                var stream = await client.GetStreamAsync(faviconUrl);
        //                var icon = new Bitmap(stream);

        //                // ImageListにアイコンを追加し、タブにアイコンを設定
        //                imageList1.Images.Add(icon);
        //                tab.ImageIndex = imageList1.Images.Count - 1;
        //            }
        //        }
        //    }
        //    catch
        //    {
        //        // アイコン取得に失敗した場合の処理（デフォルトのアイコンを使用するなど）
        //        tab.ImageIndex = -1;
        //    }
        //}
        //{
        //    string faviconUrl = await webView.ExecuteScriptAsync("document.querySelector('link[rel=\"icon\"]').href;");
        //    if (string.IsNullOrEmpty(faviconUrl))
        //    {
        //        Uri uri = new Uri(webView.Source.ToString());
        //        faviconUrl = $"{uri.Scheme}://{uri.Host}/favicon.ico";
        //    }

        //    if (!string.IsNullOrEmpty(faviconUrl))
        //    {
        //        try
        //        {
        //            faviconUrl = faviconUrl.Trim('"'); // JavaScriptが返す文字列から余分なダブルクォーテーションを削除
        //            using (HttpClient client = new HttpClient())
        //            {
        //                var stream = await new HttpClient().GetStreamAsync(faviconUrl);
        //                var icon = new Bitmap(stream);

        //                imageList1.Images.Add(icon);
        //                tab.ImageIndex = imageList1.Images.Count - 1;
        //            }

        //            // タブのIcon設定
        //            //tab.ImageIndex = imageList1.Images.Add(icon, Color.Transparent);
        //        }
        //        catch
        //        {
        //            // アイコン取得に失敗した際の処理
        //            tab.ImageIndex = -1;
        //        }
        //    }
        //}
        // Tabの追加時の関数
        private void AddNewTab(string url = "https://www.google.co.jp")
        {
            TabPage newTab = new TabPage("Loading...");//初期タイトル

            // webView2の作成
            WebView2 additionalWebView = new WebView2();
            additionalWebView.Dock = DockStyle.Fill;

            additionalWebView.CoreWebView2InitializationCompleted += async (sender, args) =>
            {
                if (args.IsSuccess)
                {
                    // ページの読み込みが完了したときのイベント
                    additionalWebView.CoreWebView2.NavigationCompleted += (navSender, navArgs) =>
                    {
                        // タブのタイトルをwebページのタイトルに更新
                        newTab.Text = additionalWebView.CoreWebView2.DocumentTitle;

                        // アイコンの取得
                        UpdateTabIcon(newTab, additionalWebView.CoreWebView2);
                    };
                }
                else
                {
                    newTab.Text = "Error";
                }
            };

            // URLの読み込み
            additionalWebView.Source = new Uri(url);

            // 新しいタブにwebView2を追加
            newTab.Controls.Add(additionalWebView);
            tabControl.TabPages.Add(newTab);

            // 新しいタブをアクティブにする
            tabControl.SelectedTab = newTab;
        }

        // Activeなタブのwebviewを取得する。
        private WebView2 GetActiveWebView()
        {
            if (tabControl.SelectedTab != null && tabControl.SelectedTab.Controls.Count > 0)
            {
                // 現在のタブの最初のコントロールがwebview2だと仮定
                return tabControl.SelectedTab.Controls[0] as WebView2;
            }
            return null;
        }

        // Browser Back Button Click
        private void backBrowser_Click(object sender, EventArgs e)
        {
            WebView2 activeWebView = GetActiveWebView();
            if (activeWebView != null && activeWebView.CanGoBack)
            {
                activeWebView.GoBack();
            }         
        }

        // Browser Forward Button Click
        private void forwardBrowser_Click(object sender, EventArgs e)
        {
            WebView2 activeWebView = GetActiveWebView();
            if (activeWebView != null && activeWebView.CanGoForward)
            {
                activeWebView.GoForward();
            }
        }

        // 新しいタブ追加ボタンのクリックイベント
        private void NewTabButton_Click(object sender, EventArgs e)
        {
            AddNewTab();
        }

        // タブ削除ボタンのクリック
        private void CloseTabButton_Click(Object sender, EventArgs e)
        {
            if (tabControl.TabPages.Count > 0)
            {
                // 現在選択中のタブを削除
                tabControl.TabPages.Remove(tabControl.SelectedTab);
            }
        }

        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            // タブのインデックス
            TabPage tabPage = tabControl.TabPages[e.Index];
            Rectangle tabBounds = tabControl.GetTabRect(e.Index);

            // タブに設定されたアイコンを描画
            if (tabControl.ImageList != null && tabPage.ImageIndex >= 0)
            {
                // アイコンの描画位置を設定
                Image icon = tabControl.ImageList.Images[tabPage.ImageIndex];
                Point iconLocation = new Point(tabBounds.Left + 3, tabBounds.Top + (tabBounds.Height - icon.Height) / 2);
                e.Graphics.DrawImage(icon, iconLocation);
            }

            // タブのテキストを描画
            // アイコンの幅（16ピクセル）を考慮してテキストの描画開始位置を設定
            int iconWidth = tabControl.ImageList?.ImageSize.Width ?? 0;
            Rectangle textBounds = new Rectangle(tabBounds.Left + iconWidth + 6, tabBounds.Top, tabBounds.Width - iconWidth - 6, tabBounds.Height);
            TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font, textBounds, Color.Black, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
        }
        //{
        //    // タブのインデックス
        //    TabPage tabPage = tabControl.TabPages[e.Index];
        //    Rectangle tabBounds = tabControl.GetTabRect(e.Index);

        //    // タブに設定されたアイコンを描画
        //    if (tabControl.ImageList != null && tabPage.ImageIndex >= 0)
        //    {
        //        // アイコンの描画位置を設定（少し左に寄せて表示）
        //        Image icon = tabControl.ImageList.Images[tabPage.ImageIndex];
        //        Point iconLocation = new Point(tabBounds.Left + 5, tabBounds.Top + (tabBounds.Height - icon.Height) / 2);  // 垂直中央に揃える
        //        e.Graphics.DrawImage(icon, iconLocation);
        //    }

        //    // テキストを描画
        //    // アイコンの幅を考慮して、テキストの描画開始位置を調整
        //    int iconWidth = tabControl.ImageList?.ImageSize.Width ?? 0;
        //    Rectangle textBounds = new Rectangle(tabBounds.Left + iconWidth + 10, tabBounds.Top + 5, tabBounds.Width - iconWidth - 10, tabBounds.Height);

        //    // テキストの色を黒 (Color.Black) に指定して描画
        //    TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font, textBounds, Color.Black, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
        //}

        //******************************************************************************************************************//
        // Browserに関する記述                                                                                              //
        //******************************************************************************************************************//
        // END                                                                                                              //
        //******************************************************************************************************************//
    }
}
