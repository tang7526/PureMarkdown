using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MarkdownSharp;
using NotepadPower;

namespace PureMarkdown
{
    public partial class editorControl : UserControl
    {
        private TabControl tabControl;

        public editorControl()
        {
            InitializeComponent();
        }

        public editorControl(TabControl tabControl)
        {
            InitializeComponent();
            this.tabControl = tabControl;
        }

        private void textEditorControl1_Load(object sender, EventArgs e)
        {

        }

        private void editorControl_Load(object sender, EventArgs e)
        {
            this.webBrowser1.DocumentText = "<HTML><BODY></BODY></HTML>"; // 建立新網頁
            //this.textEditorControl1.ActiveTextAreaControl.TextArea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEditorControl1_KeyDown);
            //this.textEditorControl1.ActiveTextAreaControl.TextArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textEditorControl1_MouseDown);
            //this.textEditorControl1.ActiveTextAreaControl.TextArea.DragDrop += new System.Windows.Forms.DragEventHandler(this.textEditorControl1_DragDrop);
        }

        private void textEditorControl1_TextChanged(object sender, EventArgs e)
        {
            if (this.tabControl.SelectedTab.Text.IndexOf('*', 0) < 0)
            {
                this.tabControl.SelectedTab.Text = "* " + this.tabControl.SelectedTab.Text;
            }

            Markdown markdown = new Markdown();
            string strHtml = markdown.Transform(this.textEditorControl1.Text);
            //this.webBrowser1.Document.Body.InnerHtml = FixHR(strHtml);
            this.webBrowser1.Document.Body.InnerHtml = strHtml;
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

        internal void SaveFile(string strFileName)
        {
            this.textEditorControl1.SaveFile(strFileName);
        }
    }
}
