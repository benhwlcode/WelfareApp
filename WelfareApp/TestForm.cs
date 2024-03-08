using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WelfareAppClassLibrary.DataConnection;
using WelfareAppClassLibrary.Models;

namespace WelfareApp
{
    public partial class TestForm : Form
    {

        public TestForm()
        {
            InitializeComponent();

            
        }

        private void buttonTestFunctionOne_Click(object sender, EventArgs e)
        {
            TestConnector test = new TestConnector();

            TestModel model = new TestModel(textBoxTestValue.Text);
            test.CreateTest(model);

        }



        private void buttonTestFunctionTwo_Click(object sender, EventArgs e)
        {
            
            
        }

        private void buttonTestFunctionThree_Click(object sender, EventArgs e)
        {

        }       

    }
}
