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

namespace WelfareApp
{
    public partial class uEligibilityCondition : UserControl
    {
        List<string> conditions = new List<string>();


        public uEligibilityCondition()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            InitializeBindings();
        }

        private void InitializeBindings()
        {

            comboBoxProperty.DataSource = null;
            comboBoxCondition.DataSource = null;

            comboBoxProperty.DataSource = Enum.GetValues(typeof(QueryProperty));

            conditions = returnConditions();
            comboBoxCondition.DataSource = conditions;
        }

        private List<string> returnConditions()
        {
            List<string> output = new List<string>();
            output.Add("=");
            output.Add(">");
            output.Add(">=");
            output.Add("<");
            output.Add("<=");
            output.Add("!=");

            return output;
        }

        private void comboBoxProperty_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCondition.Enabled = true;

            comboBoxDynamic.DataSource = null;
            comboBoxDynamic.Visible = false;

            textBoxInput.Text = "";
            textBoxInput.Visible = false;

            if ((QueryProperty)comboBoxProperty.SelectedItem is QueryProperty.numberofchildren or 
                QueryProperty.numberofelderly or QueryProperty.rentalexpense or 
                QueryProperty.foodexpense or QueryProperty.tuitionexpense or 
                QueryProperty.utilityexpense or QueryProperty.spouseincome or
                QueryProperty.employmentincome or QueryProperty.donationincome or 
                QueryProperty.cashsavings)
            {
                textBoxInput.Visible = true;
                return;
            }

            if ((QueryProperty)comboBoxProperty.SelectedItem is QueryProperty.iscitizen or
                QueryProperty.isindigenous or QueryProperty.isdisabled)
            {               

                comboBoxCondition.SelectedIndex = 0;
                comboBoxCondition.Enabled = false;


                comboBoxDynamic.DataSource = Enum.GetValues(typeof(TrueFalse));
                comboBoxDynamic.Visible = true;               
                return;


            }

            if ((QueryProperty)comboBoxProperty.SelectedItem == QueryProperty.employmenttype)
            {
                comboBoxCondition.SelectedIndex = 0;
                comboBoxCondition.Enabled = false;

                comboBoxDynamic.DataSource = Enum.GetValues(typeof(EmploymentType));
                comboBoxDynamic.Visible = true;
                return;
            }


        }

        public string selectedProperty
        {
            get { return comboBoxProperty.SelectedItem.ToString(); }
            set { comboBoxProperty.SelectedItem = value; }
        }

        public string selectedCondition
        {
            get { return comboBoxCondition.SelectedItem.ToString(); }
            set { comboBoxCondition.SelectedItem = value; }
        }

        public string inputNumber
        {
            get { return textBoxInput.Text; }
            set { textBoxInput.Text = value; }
        }

        public string selectedDynamic
        {
            get
            {
                if (comboBoxDynamic.SelectedItem != null)
                {
                    return ((int)comboBoxDynamic.SelectedItem).ToString();
                }

                return "";

            }
            set { comboBoxDynamic.SelectedItem = value; }
        }
    }
}
