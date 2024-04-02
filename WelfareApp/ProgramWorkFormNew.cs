using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WelfareAppClassLibrary.Models;

namespace WelfareApp
{
    public partial class ProgramWorkFormNew : Form
    {
        ProgramModel currentProgram = new ProgramModel();

        List<ApplicationDisplay> programApplications = new List<ApplicationDisplay>();



        List<DocumentModel> selectedDocuments = new List<DocumentModel>();

        public ProgramWorkFormNew(ProgramModel selectedProgram)
        {
            InitializeComponent();
            currentProgram = selectedProgram;
        }

        private void InitializeBindings()
        {

        }


    }
}
