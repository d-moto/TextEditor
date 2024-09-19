namespace TextEditor
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.mainTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.新規作成NToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.開くOToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.上書き保存SToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.名前を付けて保存AToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.印刷PToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.印刷プレビューVToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.終了XToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.編集EToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.元に戻すUToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.やり直しRToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.切り取りTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.コピーCToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.貼り付けPToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.すべて選択AToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ツールTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.カスタマイズCToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.オプションOToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.内容CToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.インデックスIToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.検索SToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.バージョン情報AToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            resources.ApplyResources(this.mainSplitContainer, "mainSplitContainer");
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.panel1);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mainSplitContainer.Panel2.Controls.Add(this.mainTextBox);
            this.mainSplitContainer.Panel2.Controls.Add(this.menuStrip2);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.tabControl);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.CloseTabButton_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.forwardBrowser_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.NewTabButton_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.backBrowser_Click);
            // 
            // tabControl
            // 
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.ImageList = this.imageList1;
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl_DrawItem);
            // 
            // tabPage1
            // 
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            resources.ApplyResources(this.imageList1, "imageList1");
            this.imageList1.TransparentColor = System.Drawing.Color.Black;
            // 
            // mainTextBox
            // 
            resources.ApplyResources(this.mainTextBox, "mainTextBox");
            this.mainTextBox.Name = "mainTextBox";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem1,
            this.編集EToolStripMenuItem1,
            this.ツールTToolStripMenuItem1,
            this.ヘルプHToolStripMenuItem1});
            resources.ApplyResources(this.menuStrip2, "menuStrip2");
            this.menuStrip2.Name = "menuStrip2";
            // 
            // ファイルFToolStripMenuItem1
            // 
            this.ファイルFToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新規作成NToolStripMenuItem1,
            this.開くOToolStripMenuItem1,
            this.toolStripSeparator6,
            this.上書き保存SToolStripMenuItem1,
            this.名前を付けて保存AToolStripMenuItem1,
            this.toolStripSeparator7,
            this.印刷PToolStripMenuItem1,
            this.印刷プレビューVToolStripMenuItem1,
            this.toolStripSeparator8,
            this.終了XToolStripMenuItem1});
            this.ファイルFToolStripMenuItem1.Name = "ファイルFToolStripMenuItem1";
            resources.ApplyResources(this.ファイルFToolStripMenuItem1, "ファイルFToolStripMenuItem1");
            // 
            // 新規作成NToolStripMenuItem1
            // 
            resources.ApplyResources(this.新規作成NToolStripMenuItem1, "新規作成NToolStripMenuItem1");
            this.新規作成NToolStripMenuItem1.Name = "新規作成NToolStripMenuItem1";
            this.新規作成NToolStripMenuItem1.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // 開くOToolStripMenuItem1
            // 
            resources.ApplyResources(this.開くOToolStripMenuItem1, "開くOToolStripMenuItem1");
            this.開くOToolStripMenuItem1.Name = "開くOToolStripMenuItem1";
            this.開くOToolStripMenuItem1.Click += new System.EventHandler(this.openOToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            // 
            // 上書き保存SToolStripMenuItem1
            // 
            resources.ApplyResources(this.上書き保存SToolStripMenuItem1, "上書き保存SToolStripMenuItem1");
            this.上書き保存SToolStripMenuItem1.Name = "上書き保存SToolStripMenuItem1";
            this.上書き保存SToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // 名前を付けて保存AToolStripMenuItem1
            // 
            this.名前を付けて保存AToolStripMenuItem1.Name = "名前を付けて保存AToolStripMenuItem1";
            resources.ApplyResources(this.名前を付けて保存AToolStripMenuItem1, "名前を付けて保存AToolStripMenuItem1");
            this.名前を付けて保存AToolStripMenuItem1.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            // 
            // 印刷PToolStripMenuItem1
            // 
            resources.ApplyResources(this.印刷PToolStripMenuItem1, "印刷PToolStripMenuItem1");
            this.印刷PToolStripMenuItem1.Name = "印刷PToolStripMenuItem1";
            // 
            // 印刷プレビューVToolStripMenuItem1
            // 
            resources.ApplyResources(this.印刷プレビューVToolStripMenuItem1, "印刷プレビューVToolStripMenuItem1");
            this.印刷プレビューVToolStripMenuItem1.Name = "印刷プレビューVToolStripMenuItem1";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            resources.ApplyResources(this.toolStripSeparator8, "toolStripSeparator8");
            // 
            // 終了XToolStripMenuItem1
            // 
            this.終了XToolStripMenuItem1.Name = "終了XToolStripMenuItem1";
            resources.ApplyResources(this.終了XToolStripMenuItem1, "終了XToolStripMenuItem1");
            this.終了XToolStripMenuItem1.Click += new System.EventHandler(this.closeWindowToolStripMenuItem_Click);
            // 
            // 編集EToolStripMenuItem1
            // 
            this.編集EToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.元に戻すUToolStripMenuItem1,
            this.やり直しRToolStripMenuItem1,
            this.toolStripSeparator9,
            this.切り取りTToolStripMenuItem1,
            this.コピーCToolStripMenuItem1,
            this.貼り付けPToolStripMenuItem1,
            this.toolStripSeparator10,
            this.すべて選択AToolStripMenuItem1});
            this.編集EToolStripMenuItem1.Name = "編集EToolStripMenuItem1";
            resources.ApplyResources(this.編集EToolStripMenuItem1, "編集EToolStripMenuItem1");
            // 
            // 元に戻すUToolStripMenuItem1
            // 
            this.元に戻すUToolStripMenuItem1.Name = "元に戻すUToolStripMenuItem1";
            resources.ApplyResources(this.元に戻すUToolStripMenuItem1, "元に戻すUToolStripMenuItem1");
            this.元に戻すUToolStripMenuItem1.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // やり直しRToolStripMenuItem1
            // 
            this.やり直しRToolStripMenuItem1.Name = "やり直しRToolStripMenuItem1";
            resources.ApplyResources(this.やり直しRToolStripMenuItem1, "やり直しRToolStripMenuItem1");
            this.やり直しRToolStripMenuItem1.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            resources.ApplyResources(this.toolStripSeparator9, "toolStripSeparator9");
            // 
            // 切り取りTToolStripMenuItem1
            // 
            resources.ApplyResources(this.切り取りTToolStripMenuItem1, "切り取りTToolStripMenuItem1");
            this.切り取りTToolStripMenuItem1.Name = "切り取りTToolStripMenuItem1";
            // 
            // コピーCToolStripMenuItem1
            // 
            resources.ApplyResources(this.コピーCToolStripMenuItem1, "コピーCToolStripMenuItem1");
            this.コピーCToolStripMenuItem1.Name = "コピーCToolStripMenuItem1";
            // 
            // 貼り付けPToolStripMenuItem1
            // 
            resources.ApplyResources(this.貼り付けPToolStripMenuItem1, "貼り付けPToolStripMenuItem1");
            this.貼り付けPToolStripMenuItem1.Name = "貼り付けPToolStripMenuItem1";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            resources.ApplyResources(this.toolStripSeparator10, "toolStripSeparator10");
            // 
            // すべて選択AToolStripMenuItem1
            // 
            this.すべて選択AToolStripMenuItem1.Name = "すべて選択AToolStripMenuItem1";
            resources.ApplyResources(this.すべて選択AToolStripMenuItem1, "すべて選択AToolStripMenuItem1");
            // 
            // ツールTToolStripMenuItem1
            // 
            this.ツールTToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.カスタマイズCToolStripMenuItem1,
            this.オプションOToolStripMenuItem1});
            this.ツールTToolStripMenuItem1.Name = "ツールTToolStripMenuItem1";
            resources.ApplyResources(this.ツールTToolStripMenuItem1, "ツールTToolStripMenuItem1");
            // 
            // カスタマイズCToolStripMenuItem1
            // 
            this.カスタマイズCToolStripMenuItem1.Name = "カスタマイズCToolStripMenuItem1";
            resources.ApplyResources(this.カスタマイズCToolStripMenuItem1, "カスタマイズCToolStripMenuItem1");
            // 
            // オプションOToolStripMenuItem1
            // 
            this.オプションOToolStripMenuItem1.Name = "オプションOToolStripMenuItem1";
            resources.ApplyResources(this.オプションOToolStripMenuItem1, "オプションOToolStripMenuItem1");
            // 
            // ヘルプHToolStripMenuItem1
            // 
            this.ヘルプHToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.内容CToolStripMenuItem1,
            this.インデックスIToolStripMenuItem1,
            this.検索SToolStripMenuItem1,
            this.toolStripSeparator11,
            this.バージョン情報AToolStripMenuItem1});
            this.ヘルプHToolStripMenuItem1.Name = "ヘルプHToolStripMenuItem1";
            resources.ApplyResources(this.ヘルプHToolStripMenuItem1, "ヘルプHToolStripMenuItem1");
            // 
            // 内容CToolStripMenuItem1
            // 
            this.内容CToolStripMenuItem1.Name = "内容CToolStripMenuItem1";
            resources.ApplyResources(this.内容CToolStripMenuItem1, "内容CToolStripMenuItem1");
            // 
            // インデックスIToolStripMenuItem1
            // 
            this.インデックスIToolStripMenuItem1.Name = "インデックスIToolStripMenuItem1";
            resources.ApplyResources(this.インデックスIToolStripMenuItem1, "インデックスIToolStripMenuItem1");
            // 
            // 検索SToolStripMenuItem1
            // 
            this.検索SToolStripMenuItem1.Name = "検索SToolStripMenuItem1";
            resources.ApplyResources(this.検索SToolStripMenuItem1, "検索SToolStripMenuItem1");
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            resources.ApplyResources(this.toolStripSeparator11, "toolStripSeparator11");
            // 
            // バージョン情報AToolStripMenuItem1
            // 
            this.バージョン情報AToolStripMenuItem1.Name = "バージョン情報AToolStripMenuItem1";
            resources.ApplyResources(this.バージョン情報AToolStripMenuItem1, "バージョン情報AToolStripMenuItem1");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainSplitContainer);
            this.Name = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.loadWindow);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.RichTextBox mainTextBox;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 新規作成NToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 開くOToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem 上書き保存SToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 名前を付けて保存AToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem 印刷PToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 印刷プレビューVToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem 終了XToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 編集EToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 元に戻すUToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem やり直しRToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem 切り取りTToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem コピーCToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 貼り付けPToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem すべて選択AToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ツールTToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem カスタマイズCToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem オプションOToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 内容CToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem インデックスIToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 検索SToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem バージョン情報AToolStripMenuItem1;
    }
}

