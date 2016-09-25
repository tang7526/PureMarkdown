﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MarkdownSharp;
using PureMarkdown;
using ICSharpCode.TextEditor;

namespace PureMarkdown
{
    public partial class editorControl : UserControl
    {
        private TabControl tabControl;
        private SaveFileDialog saveFileDialog1;
        private PureMarkdown.PureMarkdownForm pureMarkdown;

        public editorControl()
        {
            InitializeComponent();
        }

        public editorControl(TabControl tabControl)
        {
            InitializeComponent();
            this.tabControl = tabControl;
        }

        public editorControl(TabControl tabControl, SaveFileDialog saveFileDialog)
        {
            InitializeComponent();
            this.tabControl = tabControl;
            this.saveFileDialog1 = saveFileDialog;
        }

        public editorControl(PureMarkdown.PureMarkdownForm pureMarkdown, TabControl tabControl, SaveFileDialog saveFileDialog)
        {
            InitializeComponent();
            this.pureMarkdown = pureMarkdown;
            this.tabControl = tabControl;
            this.saveFileDialog1 = saveFileDialog;

        }

        private void textEditorControl1_Load(object sender, EventArgs e)
        {

        }

        private void editorControl_Load(object sender, EventArgs e)
        {
            this.webBrowser1.DocumentText = "<HTML><BODY></BODY></HTML>"; // 建立新網頁
            this.textEditorControl1.ActiveTextAreaControl.TextArea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEditorControl1_KeyDown);
            //this.textEditorControl1.ActiveTextAreaControl.TextArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textEditorControl1_MouseDown);
            //this.textEditorControl1.ActiveTextAreaControl.TextArea.DragDrop += new System.Windows.Forms.DragEventHandler(this.textEditorControl1_DragDrop);
        }

        private void textEditorControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode.ToString() == "S")
            {
                SaveFile(this.tabControl.SelectedTab);
            }
        }

        private void SaveFile(TabPage tab_page)
        {
            if (tab_page.Text.Contains("未命名"))
            {
                SaveAs(tab_page);
            }
            else
            {
                TextEditorControl text_editor = ((TextEditorControl)tab_page.Controls.Find("textEditorControl1", true).FirstOrDefault());
                text_editor.SaveFile(tab_page.ToolTipText);

                if (tab_page.Text.IndexOf('*', 0) == 0)
                {
                    tab_page.Text = tab_page.Text.Remove(0, 2);
                }
            }
        }

        private void SaveAs(TabPage tab_page)
        {
            this.saveFileDialog1.Filter = "Markdown files (*.md)|*.md|All files (*.*)|*.*";
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextEditorControl text_editor = ((TextEditorControl)tab_page.Controls.Find("textEditorControl1", true).FirstOrDefault());
                text_editor.SaveFile(this.saveFileDialog1.FileName);

                this.Text = this.saveFileDialog1.FileName + " - PureMarkdown";
                tab_page.Text = this.saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.LastIndexOf('\\') + 1);
                tab_page.ToolTipText = this.saveFileDialog1.FileName;
            }
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

        internal void FocusNewTabPage()
        {
            this.textEditorControl1.Focus();
        }
    }
}
