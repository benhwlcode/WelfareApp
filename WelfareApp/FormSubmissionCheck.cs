using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WelfareApp
{
    public static class FormSubmissionCheck
    {

        public static bool CheckErrorProvider(Control.ControlCollection controls, ErrorProvider ep)
        {
            foreach (Control control in controls)
            {
                if (control.HasChildren)
                {
                    if (CheckErrorProvider(control.Controls, ep))
                    {
                        return true;
                    }
                }

                if (!control.HasChildren)
                {
                    string s = ep.GetError(control);

                    if (!s.IsNullOrEmpty())
                    {
                        
                        MessageBox.Show("Please resolve errors.");
                        return true;
                    }

                }
            }

            return false;
        }

        public static bool CheckEmptyTextBox(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control.HasChildren)
                {
                    if (CheckEmptyTextBox(control.Controls))
                    {
                        return true;
                    }
                }

                if (control is TextBox textBox && textBox.Visible && string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = " ";
                    textBox.Text = "";

                    // MessageBox.Show("Please fill in empty fields.");
                    // return true;
                    
                }

            }

            return false;
        }
    }
}
