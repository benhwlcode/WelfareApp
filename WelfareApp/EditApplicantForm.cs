using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WelfareApp
{
    public partial class EditApplicantForm : Form
    {
        public EditApplicantForm()
        {
            InitializeComponent();

            uEditApplicant editApplicant = new uEditApplicant();
            panelPlaceholder.Controls.Clear();
            panelPlaceholder.Controls.Add(editApplicant);
        }
    }
}
