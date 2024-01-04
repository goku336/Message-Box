using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraLayout.Utils;

namespace POS.MessageBox
{
    internal partial class frmMsgBox : XtraForm
    {       
        private MessageBoxButtons msgButtons { get; set; }
        private MessageBoxIcon Icon { get; set; }
        private string Prompt { get; set; }
        private DialogResult _dlgResult;

        private DialogResult dlgResult
        {
            get { return _dlgResult; }
            set 
            {
                _dlgResult = value;
                this.DialogResult = _dlgResult;
            }
        }

        internal frmMsgBox(string Prompt, string Caption, MessageBoxButtons Buttons, MessageBoxIcon Icon)
        {
            InitializeComponent();

            try
            {
                dlgResult = DialogResult.None;

                this.msgButtons = Buttons;
                this.Icon = Icon;
                this.Text = Caption;
                this.lblPrompt.Text = Prompt;

                ShowMessage();
            }
            catch (Exception)
            {
                throw;
            }
        }  

        private void ShowMessage()
        {
            try
            {
                if (msgButtons == MessageBoxButtons.OK)
                {
                    lciYes.Visibility = LayoutVisibility.Never;
                    lciNo.Visibility = LayoutVisibility.Never;
                    lciCancel.Visibility = LayoutVisibility.Never;                  
                }
                else if (msgButtons == MessageBoxButtons.OKCancel)
                {
                    lciYes.Visibility = LayoutVisibility.Never;
                    lciNo.Visibility = LayoutVisibility.Never;                    
                }
                else if (msgButtons == MessageBoxButtons.YesNo)
                {
                    lciOK.Visibility = LayoutVisibility.Never;
                    lciCancel.Visibility = LayoutVisibility.Never;
                }
                else if (msgButtons == MessageBoxButtons.YesNoCancel)
                {
                    lciOK.Visibility = LayoutVisibility.Never;                     
                }

                if (Icon == MessageBoxIcon.None)
                {
                    pctIcon.Image = null;
                    lciImage.Visibility = LayoutVisibility.Never;
                }
                else
                {
                    lciImage.Visibility = LayoutVisibility.Always;

                    if (Icon == MessageBoxIcon.Information || Icon == MessageBoxIcon.Asterisk)
                    {
                        pctIcon.Image = imgLstIcons.Images["Information.png"];
                    }
                    else if (Icon == MessageBoxIcon.Error || Icon == MessageBoxIcon.Hand || Icon == MessageBoxIcon.Stop)
                    {
                        pctIcon.Image = imgLstIcons.Images["Error.png"];
                    }
                    else if (Icon == MessageBoxIcon.Exclamation || Icon == MessageBoxIcon.Warning)
                    {
                        pctIcon.Image = imgLstIcons.Images["Warning.png"];
                    }                  
                    else if (Icon == MessageBoxIcon.Question)
                    {
                        pctIcon.Image = imgLstIcons.Images["Question.png"];
                    }
                }

                emptySpcLeft.Width = (emptySpcRight.Width / 2) + 10;
            }
            catch (Exception)
            {                
                throw;
            }
        }  

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
                SimpleButton btn = sender as SimpleButton;

                if (btn == btnOK)
                    dlgResult =  DialogResult.OK;
                else if (btn == btnYes)
                    dlgResult = DialogResult.Yes;
                else if (btn == btnNo)
                    dlgResult = DialogResult.No;
                else if (btn == btnCancel)
                    dlgResult = DialogResult.Cancel;

                this.Close();
            }
            catch (Exception)
            {                
                throw;
            }
        }
 
 
    }
}