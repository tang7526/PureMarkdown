namespace NotepadPower
{
    partial class PureMarkdown
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PureMarkdown));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新文件ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.儲存檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存新檔ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.載入CSSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.匯出網頁ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.關於ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markdown語法說明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textEditorControl1 = new ICSharpCode.TextEditor.TextEditorControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogForSetCSS = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.關於ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(928, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新文件ToolStripMenuItem1,
            this.開啟檔案ToolStripMenuItem,
            this.儲存檔案ToolStripMenuItem,
            this.另存新檔ToolStripMenuItem1});
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.檔案ToolStripMenuItem.Text = "檔案";
            // 
            // 新文件ToolStripMenuItem1
            // 
            this.新文件ToolStripMenuItem1.Name = "新文件ToolStripMenuItem1";
            this.新文件ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.新文件ToolStripMenuItem1.Text = "新文件";
            this.新文件ToolStripMenuItem1.Click += new System.EventHandler(this.新文件ToolStripMenuItem1_Click);
            // 
            // 開啟檔案ToolStripMenuItem
            // 
            this.開啟檔案ToolStripMenuItem.Name = "開啟檔案ToolStripMenuItem";
            this.開啟檔案ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.開啟檔案ToolStripMenuItem.Text = "開啟檔案";
            this.開啟檔案ToolStripMenuItem.Click += new System.EventHandler(this.開啟檔案ToolStripMenuItem_Click);
            // 
            // 儲存檔案ToolStripMenuItem
            // 
            this.儲存檔案ToolStripMenuItem.Name = "儲存檔案ToolStripMenuItem";
            this.儲存檔案ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.儲存檔案ToolStripMenuItem.Text = "儲存檔案";
            this.儲存檔案ToolStripMenuItem.Click += new System.EventHandler(this.儲存檔案ToolStripMenuItem_Click);
            // 
            // 另存新檔ToolStripMenuItem1
            // 
            this.另存新檔ToolStripMenuItem1.Name = "另存新檔ToolStripMenuItem1";
            this.另存新檔ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.另存新檔ToolStripMenuItem1.Text = "另存新檔";
            this.另存新檔ToolStripMenuItem1.Click += new System.EventHandler(this.另存新檔ToolStripMenuItem1_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.載入CSSToolStripMenuItem,
            this.匯出網頁ToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 載入CSSToolStripMenuItem
            // 
            this.載入CSSToolStripMenuItem.Name = "載入CSSToolStripMenuItem";
            this.載入CSSToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.載入CSSToolStripMenuItem.Text = "載入CSS";
            this.載入CSSToolStripMenuItem.Click += new System.EventHandler(this.載入CSSToolStripMenuItem_Click);
            // 
            // 匯出網頁ToolStripMenuItem
            // 
            this.匯出網頁ToolStripMenuItem.Name = "匯出網頁ToolStripMenuItem";
            this.匯出網頁ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.匯出網頁ToolStripMenuItem.Text = "匯出網頁";
            this.匯出網頁ToolStripMenuItem.Click += new System.EventHandler(this.匯出網頁ToolStripMenuItem_Click);
            // 
            // 關於ToolStripMenuItem
            // 
            this.關於ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markdown語法說明ToolStripMenuItem});
            this.關於ToolStripMenuItem.Name = "關於ToolStripMenuItem";
            this.關於ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.關於ToolStripMenuItem.Text = "幫助";
            // 
            // markdown語法說明ToolStripMenuItem
            // 
            this.markdown語法說明ToolStripMenuItem.Name = "markdown語法說明ToolStripMenuItem";
            this.markdown語法說明ToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.markdown語法說明ToolStripMenuItem.Text = "Markdown 語法說明";
            this.markdown語法說明ToolStripMenuItem.Click += new System.EventHandler(this.markdown語法說明ToolStripMenuItem_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(467, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(458, 573);
            this.webBrowser1.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textEditorControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.webBrowser1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(928, 579);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // textEditorControl1
            // 
            this.textEditorControl1.AutoScroll = true;
            this.textEditorControl1.AutoSize = true;
            this.textEditorControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEditorControl1.IsReadOnly = false;
            this.textEditorControl1.Location = new System.Drawing.Point(3, 3);
            this.textEditorControl1.Name = "textEditorControl1";
            this.textEditorControl1.Size = new System.Drawing.Size(458, 573);
            this.textEditorControl1.TabIndex = 9;
            this.textEditorControl1.TextChanged += new System.EventHandler(this.textEditorControl1_TextChanged);
            this.textEditorControl1.DragDrop += new System.Windows.Forms.DragEventHandler(this.textEditorControl1_DragDrop);
            this.textEditorControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEditorControl1_KeyDown);
            this.textEditorControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textEditorControl1_MouseDown);
            // 
            // PureMarkdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 603);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PureMarkdown";
            this.Text = "PureMarkdown";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripMenuItem 關於ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存新檔ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 儲存檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新文件ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem markdown語法說明ToolStripMenuItem;
        private ICSharpCode.TextEditor.TextEditorControl textEditorControl1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem 開啟檔案ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 載入CSSToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialogForSetCSS;
        private System.Windows.Forms.ToolStripMenuItem 匯出網頁ToolStripMenuItem;
    }
}

