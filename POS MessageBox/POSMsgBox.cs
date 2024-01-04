using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace POS.MessageBox
{
    public  class POSMsgBox
    {
        public static DialogResult Show(string Prompt)
        {
            DialogResult dlgResult;

            try
            {
                dlgResult = ShowMessage(Prompt);
            }
            catch (Exception)
            {
                throw;
            }

            return dlgResult;
        }

        public static DialogResult Show(string Prompt, string Caption)
        {
            DialogResult dlgResult;

            try
            {
                dlgResult = ShowMessage(Prompt, Caption);
            }
            catch (Exception)
            {                
                throw;
            }

            return dlgResult;
        }

        public static DialogResult Show(string Prompt, string Caption, MessageBoxButtons Buttons)
        {
            DialogResult dlgResult;

            try
            {
                dlgResult = ShowMessage(Prompt, Caption,Buttons);
            }
            catch (Exception)
            {
                throw;
            }

            return dlgResult;
        }

        public static DialogResult Show(string Prompt, string Caption, MessageBoxButtons Buttons, MessageBoxIcon Icon)
        {
            DialogResult dlgResult;

            try
            {
                dlgResult = ShowMessage(Prompt, Caption, Buttons,Icon);
               
            }
            catch (Exception)
            {
                throw;
            }

            return dlgResult;
        }

        private static DialogResult ShowMessage(string Prompt, string Caption = "", MessageBoxButtons Buttons = MessageBoxButtons.OK, MessageBoxIcon Icon = MessageBoxIcon.None)
        {
            DialogResult dlgResult;
           
            try
            {
                frmMsgBox frm = new frmMsgBox(Prompt, Caption, Buttons, Icon);

                dlgResult = frm.ShowDialog();
            }
            catch (Exception)
            {                
                throw;
            }

            return dlgResult;
        }

    }

}
