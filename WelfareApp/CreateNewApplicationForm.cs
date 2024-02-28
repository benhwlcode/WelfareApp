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
    public partial class CreateNewApplicationForm : Form
    {
        public CreateNewApplicationForm()
        {
            InitializeComponent();

            uEditApplicant editApplicant = new uEditApplicant();
            panelPlaceholder.Controls.Clear();
            panelPlaceholder.Controls.Add(editApplicant);
        }

        private void buttonLoadApplicantData_Click(object sender, EventArgs e)
        {
            LoadApplicantForm loadApplicantForm 
                = new LoadApplicantForm();

            loadApplicantForm.Show();
        }
    }
}
