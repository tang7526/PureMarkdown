namespace PureMarkdown
{
    partial class PureMarkdownForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PureMarkdownForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新文件ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.儲存檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存新檔ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.結束程式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.載入CSSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.匯出網頁ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.關於ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markdown語法說明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogForSetCSS = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.關閉檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new PureMarkdown.DraggableTabControl();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.另存新檔ToolStripMenuItem1,
            this.關閉檔案ToolStripMenuItem,
            this.結束程式ToolStripMenuItem});
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.檔案ToolStripMenuItem.Text = "檔案";
            // 
            // 新文件ToolStripMenuItem1
            // 
            this.新文件ToolStripMenuItem1.Name = "新文件ToolStripMenuItem1";
            this.新文件ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.新文件ToolStripMenuItem1.Text = "新增文件";
            this.新文件ToolStripMenuItem1.Click += new System.EventHandler(this.新文件ToolStripMenuItem1_Click);
            // 
            // 開啟檔案ToolStripMenuItem
            // 
            this.開啟檔案ToolStripMenuItem.Name = "開啟檔案ToolStripMenuItem";
            this.開啟檔案ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.開啟檔案ToolStripMenuItem.Text = "開啟檔案";
            this.開啟檔案ToolStripMenuItem.Click += new System.EventHandler(this.開啟檔案ToolStripMenuItem_Click);
            // 
            // 儲存檔案ToolStripMenuItem
            // 
            this.儲存檔案ToolStripMenuItem.Name = "儲存檔案ToolStripMenuItem";
            this.儲存檔案ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.儲存檔案ToolStripMenuItem.Text = "儲存檔案";
            this.儲存檔案ToolStripMenuItem.Click += new System.EventHandler(this.儲存檔案ToolStripMenuItem_Click);
            // 
            // 另存新檔ToolStripMenuItem1
            // 
            this.另存新檔ToolStripMenuItem1.Name = "另存新檔ToolStripMenuItem1";
            this.另存新檔ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.另存新檔ToolStripMenuItem1.Text = "另存新檔";
            this.另存新檔ToolStripMenuItem1.Click += new System.EventHandler(this.另存新檔ToolStripMenuItem1_Click);
            // 
            // 結束程式ToolStripMenuItem
            // 
            this.結束程式ToolStripMenuItem.Name = "結束程式ToolStripMenuItem";
            this.結束程式ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.結束程式ToolStripMenuItem.Text = "結束程式";
            this.結束程式ToolStripMenuItem.Click += new System.EventHandler(this.結束程式ToolStripMenuItem_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 579);
            this.panel1.TabIndex = 11;
            this.panel1.DoubleClick += new System.EventHandler(this.panel1_DoubleClick);
            // 
            // 關閉檔案ToolStripMenuItem
            // 
            this.關閉檔案ToolStripMenuItem.Name = "關閉檔案ToolStripMenuItem";
            this.關閉檔案ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.關閉檔案ToolStripMenuItem.Text = "關閉檔案";
            this.關閉檔案ToolStripMenuItem.Click += new System.EventHandler(this.關閉檔案ToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(928, 579);
            this.tabControl1.TabIndex = 0;
            // 
            // PureMarkdownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 603);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PureMarkdownForm";
            this.Text = "PureMarkdown";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 關於ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存新檔ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 儲存檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新文件ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem markdown語法說明ToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem 開啟檔案ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 載入CSSToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialogForSetCSS;
        private System.Windows.Forms.ToolStripMenuItem 匯出網頁ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem 結束程式ToolStripMenuItem;
        private DraggableTabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem 關閉檔案ToolStripMenuItem;
    }
}

