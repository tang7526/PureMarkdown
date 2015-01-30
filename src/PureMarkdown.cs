using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using anrControls;
using ICSharpCode.TextEditor.Document;
using System.IO;
using MarkdownSharp;


namespace NotepadPower
{
    public partial class PureMarkdown : Form
    {
        public bool bPressBy新文件 = false;

        public PureMarkdown()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.webBrowser1.DocumentText = "<HTML><BODY></BODY></HTML>"; // 建立新網頁
            this.WindowState = FormWindowState.Maximized;  // 設定表單最大化    
            this.Text = "新文件";
            this.textEditorControl1.ActiveTextAreaControl.TextArea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEditorControl1_KeyDown);
            this.textEditorControl1.ActiveTextAreaControl.TextArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textEditorControl1_MouseDown);
            this.textEditorControl1.ActiveTextAreaControl.TextArea.DragDrop += new System.Windows.Forms.DragEventHandler(this.textEditorControl1_DragDrop);
        }

        private void textEditorControl1_TextChanged(object sender, EventArgs e)
        {
            if (bPressBy新文件 == false && this.Text.IndexOf('*', 0) < 0)
            {
                this.Text = "* " + this.Text;
            }
            else
            {
                bPressBy新文件 = false;
            }
            
            Markdown markdown = new Markdown();
            string strHtml = markdown.Transform(this.textEditorControl1.Text);
            this.webBrowser1.Document.Body.InnerHtml = FixHR(strHtml);
        }

        /// <summary>
        /// 因為在第一行打 --- 時，會跳出 HRESULT: 0x800A0259 的錯誤，所以建立這個 function 來修正。
        /// </summary>
        /// <param name="markdown"></param>
        private string FixHR(string strHtml)
        {
            string strResult = "";
            if (strHtml.StartsWith("<p><hr /></p>\n"))
            {
                strResult = "<hr />" + strHtml.Substring(14);
            }
            else
            {
                strResult = strHtml;
            }
            return strResult;
        }

        private void markdown語法說明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://markdown.tw/");
        }

        private void textEditorControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode.ToString() == "S")
            {
                SaveFile();
            }
        }

        private void 開啟檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(this.openFileDialog1.FileName))
                {
                    this.textEditorControl1.Text = sr.ReadToEnd();
                    this.Text = this.openFileDialog1.FileName;
                }
            }
        }

        private void 新文件ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bPressBy新文件 = true;
            this.Text = "新文件";
            this.textEditorControl1.Text = "";
            this.webBrowser1.DocumentText = "";
            this.Refresh();
        }

        private void 儲存檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void SaveFile()
        {
            if (this.Text == "新文件" || this.Text == "* 新文件")
            {
                SaveAs();
            }
            else
            {
                this.textEditorControl1.SaveFile(this.Text.Remove(0, 2));
                if (this.Text.IndexOf('*', 0) == 0)
                {
                    this.Text = this.Text.Remove(0, 2);
                }
            }
        }

        private void 另存新檔ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void SaveAs()
        {
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textEditorControl1.SaveFile(saveFileDialog1.FileName);
                this.Text = saveFileDialog1.FileName;
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
                    if (this.webBrowser1.Document != null)
                    {
                        strBody = this.webBrowser1.Document.Body.InnerHtml;
                    }
                    webBrowser1.DocumentText = "<html><head>"
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
                    sw.Write("<html>\n<head>\n<title></title>\n</head>\n<body>\n");
                    if (this.webBrowser1.Document != null)
                    {
                        sw.Write(this.webBrowser1.Document.Body.InnerHtml);
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
            if (e.Effect == DragDropEffects.Move)
            {
                string strDocPath = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
                using (StreamReader sr = new StreamReader(strDocPath))
                {
                    this.textEditorControl1.Text = sr.ReadToEnd();
                    this.Text = strDocPath;
                    this.Refresh();
                }
            }
        }
    }
}
