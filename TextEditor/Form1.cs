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

namespace TextEditor
{
    public partial class Form1 : Form
    {
        private string CurrentFilePath = null; //現在のファイルパスを保持するためのフィールド
        private WebView2 webView;

        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(loadWindow); //フォームロード時に呼び出す。
            InitializeWebView(); // webview2の初期化
        }

        // プログラム起動時にテキストボックスの設定を反映
        private void loadWindow(object sender, EventArgs e)
        {
            mainTextBox.Multiline = true;
            mainTextBox.ScrollBars = ScrollBars.Vertical;
            mainTextBox.Dock = DockStyle.Fill;
        }

        // webview2の初期化
        private void InitializeWebView()
        {
            webView = new WebView2();
            webView.Dock = DockStyle.Fill;

            // splitContainerの右側パネルにWebView2を追加
            splitContainer1.Panel2.Controls.Add(webView);

            // webView2でgoogleを開く
            webView.Source = new Uri("https://www.google.co.jp");
        }

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
    }
}
