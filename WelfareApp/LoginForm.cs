using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WelfareAppClassLibrary;
using WelfareAppClassLibrary.DataConnection;
using WelfareAppClassLibrary.Models;

namespace WelfareApp
{
    public partial class LoginForm : Form
    {
        AgentModel userAgent = new AgentModel();

        public LoginForm()
        {
            InitializeComponent();

            textBoxUsernameValue.Text = "user";
            textBoxPasswordValue.Text = "password";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SqlConnector sql = new SqlConnector();
            Helper helper = new Helper();

            string userInput = textBoxUsernameValue.Text;
            string passwordInput = textBoxPasswordValue.Text;

            userAgent = sql.GetAgent(userInput);

            bool credientialsSuccessful = helper.CheckPassword(userAgent, passwordInput);

            if (credientialsSuccessful)
            {
                StartupForm startupForm = new StartupForm(userAgent);
                startupForm.Show();
            }
            else
            {
                MessageBox.Show("password or user is incorrect");
            }
        }

        private void buttonCsvForm_Click(object sender, EventArgs e)
        {
            CsvDataForm csvDataForm = new CsvDataForm();
            csvDataForm.Show();
        }
    }
}
