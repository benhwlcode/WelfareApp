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
    public partial class EditFilterForm : Form
    {
        public ListOfAppsForm parent;

        public uEditApplicant subEc;

        string constructedQuery = "";

        string prop = "";
        string cond = "";
        string dyna = "";
        string numb = "";

        List<uEligibilityCondition> conditions = new List<uEligibilityCondition>();


        public EditFilterForm(ListOfAppsForm parentInput)
        {
            InitializeComponent();
            parent = parentInput;
        }



        

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddQueryCondition();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            RemoveQueryCondition();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            constructedQuery = "";
            ReturnQuery();
            parent.filterCustom = constructedQuery;


            this.Close();

        }

        private void AddQueryCondition()
        {
            int row = tableLayoutPanelFilters.RowCount - 1;

            uEligibilityCondition ec = new uEligibilityCondition();
            tableLayoutPanelFilters.Controls.Add(ec, 0, row);

            tableLayoutPanelFilters.RowCount = tableLayoutPanelFilters.RowCount + 1;
            tableLayoutPanelFilters.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));

        }

        private void RemoveQueryCondition()
        {
            int row = tableLayoutPanelFilters.RowCount - 2;
            tableLayoutPanelFilters.Controls.RemoveAt(row);
            tableLayoutPanelFilters.RowCount = tableLayoutPanelFilters.RowCount - 1;
        }

        private void GetConditions(int input)
        {
            uEligibilityCondition ec =
                tableLayoutPanelFilters.GetControlFromPosition(0, input) as uEligibilityCondition;

            prop = ec.selectedProperty;
            cond = ec.selectedCondition;
            dyna = ec.selectedDynamic;
            numb = ec.inputNumber;

            if (constructedQuery == "")
            {
                constructedQuery += $"ap.{prop} {cond} {dyna}{numb} ";
                return;
            }

            constructedQuery += $"AND ap.{prop} {cond} {dyna}{numb} ";
        }

        private void ReturnQuery()
        {
            for (int i = 0; i < tableLayoutPanelFilters.RowCount - 1; i++)
            {
                GetConditions(i);

            }
        }

        
    }
}
