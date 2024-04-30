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
    public partial class EditEligibilityForm : Form
    {

        public ProgramWorkFormNew parent;

        string constructedQuery = "";

        string prop = "";
        string cond = "";
        string dyna = "";
        string numb = "";

        List<uEligibilityCondition> conditions = new List<uEligibilityCondition>();

        public EditEligibilityForm(ProgramWorkFormNew parentInput)
        {
            InitializeComponent();
            parent = parentInput;

        }

        

        private void buttonAddCondition_Click(object sender, EventArgs e)
        {
            AddQueryCondition();
        }

        private void buttonRemoveCondition_Click(object sender, EventArgs e)
        {
            RemoveQueryCondition();
        }

        private void buttonApplyCondition_Click(object sender, EventArgs e)
        {
            constructedQuery = "";
            ReturnQuery();
            parent.customQuery = constructedQuery;
            parent.ApplyEligibility();

            this.Close();
        }

        private void AddQueryCondition()
        {
            int row = tableLayoutPanelConditions.RowCount - 1;
            
            uEligibilityCondition ec = new uEligibilityCondition();
            tableLayoutPanelConditions.Controls.Add(ec, 0, row);

            tableLayoutPanelConditions.RowCount = tableLayoutPanelConditions.RowCount + 1;
            tableLayoutPanelConditions.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));

        }

        private void RemoveQueryCondition()
        {
            int row = tableLayoutPanelConditions.RowCount - 2;            
            tableLayoutPanelConditions.Controls.RemoveAt(row);
            tableLayoutPanelConditions.RowCount = tableLayoutPanelConditions.RowCount - 1;
        }

        private void GetConditions(int input)
        {
            uEligibilityCondition ec =
                tableLayoutPanelConditions.GetControlFromPosition(0, input) as uEligibilityCondition;

            prop = ec.selectedProperty;
            cond = ec.selectedCondition;
            dyna = ec.selectedDynamic;
            numb = ec.inputNumber;

            if (constructedQuery == "")
            {
                constructedQuery += $"{prop} {cond} {dyna}{numb} ";
                return;
            }

            constructedQuery += $"AND {prop} {cond} {dyna}{numb} ";
        }

        private void ReturnQuery()
        {
            for (int i = 0; i < tableLayoutPanelConditions.RowCount - 1; i++)
            {
                GetConditions(i);

            }
        }




    }
}
