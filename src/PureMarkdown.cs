using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ICSharpCode.TextEditor.Document;
using System.IO;
using MarkdownSharp;
using ICSharpCode.TextEditor;
using PureMarkdown;

namespace NotepadPower
{
    public partial class PureMarkdown : Form
    {
        static int PAGESCOUNT = 0;

        public PureMarkdown()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;  // 設定表單最大化    
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseWheelDown);
            this.tabControl1.ShowToolTips = true;
            addNewTabPage();
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = this.tabControl1.SelectedTab.ToolTipText + " - PureMarkdown";
            ((TextEditorControl)this.tabControl1.SelectedTab.Controls.Find("textEditorControl1", true).FirstOrDefault()).Focus();
        }

        private void markdown語法說明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://markdown.tw/");
        }

        private void 開啟檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(this.openFileDialog1.FileName))
                {
                    ((TextEditorControl)this.tabControl1.SelectedTab.Controls.Find("textEditorControl1", true).FirstOrDefault()).Text = sr.ReadToEnd();
                    this.Text = this.openFileDialog1.FileName;
                    this.tabControl1.SelectedTab.Text = openFileDialog1.FileName.Substring(openFileDialog1.FileName.LastIndexOf('\\') + 1);
                }
            }
        }

        private void 新文件ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addNewTabPage();
        }

        private void 儲存檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void SaveFile()
        {
            if (this.tabControl1.SelectedTab.Text.Contains("未命名"))
            {
                SaveAs();
            }
            else
            {
                ((editorControl)this.ActiveControl).SaveFile(this.tabControl1.SelectedTab.Text.Remove(0, 2));
                if (this.tabControl1.SelectedTab.Text.IndexOf('*', 0) == 0)
                {
                    this.tabControl1.SelectedTab.Text = this.tabControl1.SelectedTab.Text.Remove(0, 2);
                }
            }
        }

        private void 另存新檔ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void SaveAs()
        {
            saveFileDialog1.Filter = "Markdown files (*.md)|*.md|All files (*.*)|*.*";
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ((editorControl)this.ActiveControl).SaveFile(saveFileDialog1.FileName);
                this.Text = saveFileDialog1.FileName + " - PureMarkdown";
                this.tabControl1.SelectedTab.Text = saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.LastIndexOf('\\') + 1);
                this.tabControl1.SelectedTab.ToolTipText = saveFileDialog1.FileName;
            }
        }

        private void 載入CSSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialogForSetCSS.Filter = "css files (*.css)|*.css";
            if (this.openFileDialogForSetCSS.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(this.openFileDialogForSetCSS.FileName))
                {
                    string strBody = "";
                    WebBrowser web_browser = ((WebBrowser)this.tabControl1.SelectedTab.Controls.Find("webBrowser1", true).FirstOrDefault());
                    if (web_browser.Document != null)
                    {
                        strBody = web_browser.Document.Body.InnerHtml;
                    }
                    web_browser.DocumentText = "<html><head>"
                                  + "<style type='text/css'>"
                                  + sr.ReadToEnd()
                                  + "</style></head>"
                                  + "<body>"
                                  + strBody
                                  + "</body></html>";
                }
            }
        }

        private void 匯出網頁ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "html files (*.html)|*.html";
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    WebBrowser web_browser = ((WebBrowser)this.tabControl1.SelectedTab.Controls.Find("webBrowser1", true).FirstOrDefault());
                    sw.Write("<html>\n<head>\n");
                    if (web_browser.Document != null)
                    {
                        HtmlElement head = web_browser.Document.GetElementsByTagName("head")[0];
                        sw.Write(head.InnerHtml);
                        sw.Write("\n<title></title>\n</head>\n<body>\n");
                        sw.Write(web_browser.Document.Body.InnerHtml);
                    }
                    sw.Write("\n</body>\n</html>");
                }
            }
        }

        private void textEditorControl1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void textEditorControl1_DragDrop(object sender, DragEventArgs e)
        {
            //if (e.Effect == DragDropEffects.Move)
            //{
            //    string strDocPath = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            //    using (StreamReader sr = new StreamReader(strDocPath))
            //    {
            //        this.textEditorControl1.Text = sr.ReadToEnd();
            //        this.Text = strDocPath;
            //        this.Refresh();
            //    }
            //}
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            if (((MouseEventArgs)e).Button == MouseButtons.Left)
            {
                addNewTabPage();
            }
        }

        private void addNewTabPage()
        {
            TabPage tabPage = new TabPage();
            editorControl editor_Control = new editorControl(this, this.tabControl1, this.saveFileDialog1);
            editor_Control.Dock = DockStyle.Fill;
            tabPage.Controls.Add(editor_Control);
            this.tabControl1.TabPages.Add(tabPage);
            PAGESCOUNT += 1;
            tabPage.Text = "未命名" + PAGESCOUNT + ".md";
            tabPage.ToolTipText = "未命名" + PAGESCOUNT + ".md";
            this.Text = this.tabControl1.SelectedTab.ToolTipText + " - PureMarkdown"; // 這一行是為了當程式第一次啟動時，改掉程式標題才寫的。
            this.tabControl1.SelectedTab = tabPage; // 當新增分頁後，直接跳到新分頁。
            editor_Control.FocusNewTabPage();
        }

        private void tabControl1_MouseWheelDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle) // 若按下滑鼠中鍵
            {
                Point p = this.tabControl1.PointToClient(Cursor.Position); // 取得游標所在位置的座標
                for (int i = 0; i < this.tabControl1.TabCount; i++)
                {
                    Rectangle r = this.tabControl1.GetTabRect(i); // 取得 TabPage 的邊框

                    // 如果游標落在邊框內
                    if (r.Contains(p))
                    {
                        if (this.tabControl1.TabCount > 1) // 如果分頁有一個以上再關閉
                        {
                            this.tabControl1.TabPages.RemoveAt(i); // 移除所在邊框的分頁
                            this.tabControl1.SelectedIndex = this.tabControl1.TabCount - 1; // 將所在邊框指定為最後一個
                            ((TextEditorControl)this.tabControl1.SelectedTab.Controls.Find("textEditorControl1", true).FirstOrDefault()).Focus();
                            return;
                        }
                    }
                }
            }
            ((TextEditorControl)this.tabControl1.SelectedTab.Controls.Find("textEditorControl1", true).FirstOrDefault()).Focus();
        }

        private void 結束程式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
