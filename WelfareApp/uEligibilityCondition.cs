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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WelfareApp
{
    public partial class uEligibilityCondition : UserControl
    {
        List<string> conditions = new List<string>();

        TableLayoutPanelCellPosition activePosition; 
        TableLayoutPanelCellPosition inactivePosition;

        bool firstLoad = true;

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
            
        }

        

        private List<string> ReturnAllConditions()
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

        private List<string> ReturnEqualOrNot()
        {
            List<string> output = new List<string>();
            output.Add("=");            
            output.Add("!=");

            return output;
        }       

        private void comboBoxProperty_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeFields();

            if ((QueryProperty)comboBoxProperty.SelectedItem is QueryProperty.numberofchildren or 
                QueryProperty.numberofelderly or QueryProperty.rentalexpense or 
                QueryProperty.foodexpense or QueryProperty.tuitionexpense or 
                QueryProperty.utilityexpense or QueryProperty.spouseincome or
                QueryProperty.employmentincome or QueryProperty.donationincome or 
                QueryProperty.cashsavings)
            {

                conditions = ReturnAllConditions();
                comboBoxCondition.DataSource = conditions;

                CheckCellPosition(textBoxInput, comboBoxDynamic, activePosition, inactivePosition);

                textBoxInput.Visible = true;                
                return;
            }

            if ((QueryProperty)comboBoxProperty.SelectedItem is QueryProperty.iscitizen or
                QueryProperty.isindigenous or QueryProperty.isdisabled)
            {
                conditions = ReturnAllConditions();
                comboBoxCondition.DataSource = conditions;

                comboBoxCondition.SelectedIndex = 0;
                comboBoxCondition.Enabled = false;

                CheckCellPosition(comboBoxDynamic, textBoxInput, activePosition, inactivePosition);

                comboBoxDynamic.DataSource = Enum.GetValues(typeof(TrueFalse));
                comboBoxDynamic.Visible = true;    
                
                return;
            }

            if ((QueryProperty)comboBoxProperty.SelectedItem == QueryProperty.employmenttype)
            {
                conditions = ReturnAllConditions();
                comboBoxCondition.DataSource = conditions;

                comboBoxCondition.SelectedIndex = 0;
                comboBoxCondition.Enabled = false;

                CheckCellPosition(comboBoxDynamic, textBoxInput, activePosition, inactivePosition);

                comboBoxDynamic.DataSource = Enum.GetValues(typeof(EmploymentType));
                comboBoxDynamic.Visible = true;

                return;
            }

            if ((QueryProperty)comboBoxProperty.SelectedItem == QueryProperty.spouseId)
            {
                conditions = ReturnEqualOrNot();
                comboBoxCondition.DataSource = conditions;

                CheckCellPosition(textBoxInput, comboBoxDynamic, activePosition, inactivePosition);

                textBoxInput.Text = "0";
                textBoxInput.Visible = true;
                textBoxInput.Enabled = false;

                return;                
            }

        }

        private void InitializeFields()
        {
            if (firstLoad)
            {
                GetCellPosition();
                firstLoad = false;
            }

            comboBoxCondition.DataSource = null;            
            comboBoxCondition.Enabled = true;

            comboBoxDynamic.DataSource = null;
            comboBoxDynamic.Enabled = true;
            comboBoxDynamic.Visible = false;

            textBoxInput.Text = "";
            textBoxInput.Enabled = true;
            textBoxInput.Visible = false;
        }

        private void GetCellPosition()
        {
            activePosition = tableLayoutPanel1.GetCellPosition(comboBoxDynamic);
            inactivePosition = tableLayoutPanel1.GetCellPosition(textBoxInput);
        }

        private void CheckCellPosition(Control activeControl, Control inactiveControl,
            TableLayoutPanelCellPosition activePosition, TableLayoutPanelCellPosition inactivePosition)
        {
            TableLayoutPanelCellPosition currentPosition = tableLayoutPanel1.GetCellPosition(activeControl);

            if (currentPosition != activePosition)
            {
                tableLayoutPanel1.SetCellPosition(activeControl, activePosition);
                tableLayoutPanel1.SetCellPosition(inactiveControl, inactivePosition);

                tableLayoutPanel1.PerformLayout();
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
