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
    public partial class uEditApplicant : UserControl
    {
        public uEditApplicant()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            UpdateInitialBindings();
        }

        public void UpdateInitialBindings()
        {
            comboBoxGenderValue.DataSource = Enum.GetValues(typeof(GenderType));
            comboBoxMaritalStatusValue.DataSource = Enum.GetValues(typeof(MaritalStatus));
            comboBoxSpouseGenderValue.DataSource = Enum.GetValues(typeof(GenderType));
            comboBoxResidenceStatusValue.DataSource = Enum.GetValues(typeof(ResidenceStatus));
            comboBoxProvinceValue.DataSource = Enum.GetValues(typeof(ProvinceName));
            comboBoxEmploymentTypeValue.DataSource = Enum.GetValues(typeof(EmploymentType));

        }

        private void comboBoxMaritalStatusValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isMarried;

            if ((MaritalStatus)comboBoxMaritalStatusValue.SelectedItem == MaritalStatus.married)
            {
                isMarried = true;
            }
            else
            {
                isMarried = false;  
            }

            CheckIfMarried(isMarried);
        }


        public void CheckIfMarried(bool married)
        {
            if (married)
            {
                textBoxSpouseFirstNameValue.Visible = true;
                textBoxSpouseLastNameValue.Visible = true;
                comboBoxSpouseGenderValue.Visible = true;
                dateTimePickerSpouseDateOfBirthValue.Visible = true;
                textBoxSpouseSinCardValue.Visible = true;

                labelSpouseMaritalStatusValue.Text = MaritalStatus.married.ToString();

                textBoxSpousePhoneNumberValue.Visible = true;
                textBoxSpouseEmailAddressValue.Visible = true;

                radioButtonSpouseCitizenYes.Visible = true;
                radioButtonSpouseCitizenNo.Visible = true;
                radioButtonSpouseIndigenousYes.Visible = true;
                radioButtonSpouseIndigenousNo.Visible = true;
                radioButtonSpouseDisabledYes.Visible = true;
                radioButtonSpouseDisabledYes.Visible = true;
            }

            else
            {
                textBoxSpouseFirstNameValue.Visible = false;
                textBoxSpouseLastNameValue.Visible = false;
                comboBoxSpouseGenderValue.Visible = false;
                dateTimePickerSpouseDateOfBirthValue.Visible = false;
                textBoxSpouseSinCardValue.Visible = false;

                labelSpouseMaritalStatusValue.Text = MaritalStatus.inapplicable.ToString();

                textBoxSpousePhoneNumberValue.Visible = false;
                textBoxSpouseEmailAddressValue.Visible = false;

                radioButtonSpouseCitizenYes.Visible = false;
                radioButtonSpouseCitizenNo.Visible = false;
                radioButtonSpouseIndigenousYes.Visible = false;
                radioButtonSpouseIndigenousNo.Visible = false;
                radioButtonSpouseDisabledYes.Visible = false;
                radioButtonSpouseDisabledYes.Visible = false;
            }
        }

        

        public string applicantFirstName
        {
            get { return textBoxFirstNameValue.Text; }
            set { textBoxFirstNameValue.Text = value; }
        }

        public string applicationlicantLastName
        {
            get { return textBoxLastNameValue.Text; }
            set { textBoxLastNameValue.Text = value; }
        }

        public GenderType applicantGender
        {
            get { return (GenderType)comboBoxGenderValue.SelectedItem; }
            set { comboBoxGenderValue.SelectedItem = value; }
        }

        public DateTime applicantBirthday
        {
            get { return dateTimePickerDateOfBirthValue.Value; }
            set { dateTimePickerDateOfBirthValue.Value = value; }
        }

        public string applicantSinCard
        {
            get { return textBoxSinCardValue.Text; }
            set { textBoxSinCardValue.Text = value; }
        }

        public MaritalStatus applicantMaritalStatus
        {
            get { return (MaritalStatus)comboBoxMaritalStatusValue.SelectedItem; }
            set { comboBoxMaritalStatusValue.SelectedItem = value; }
        }

        public string applicantPhone
        {
            get { return textBoxPhoneNumberValue.Text; }
            set { textBoxPhoneNumberValue.Text = value; }
        }

        public string applicantEmail
        {
            get { return textBoxEmailAddressValue.Text; }
            set { textBoxEmailAddressValue.Text = value; }
        }

        public bool applicantIsCitizen
        {
            get
            {
                if (radioButtonCitizenYes.Checked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set
            {
                if (radioButtonCitizenYes.Checked)
                {
                    radioButtonCitizenYes.Checked = value;
                }
                else
                {
                    radioButtonCitizenNo.Checked = value;
                }
            }
        }

        public bool applicantIsIndigenous
        {
            get
            {
                if (radioButtonIndigenousYes.Checked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set
            {
                if (radioButtonIndigenousYes.Checked)
                {
                    radioButtonIndigenousYes.Checked = value;
                }
                else
                {
                    radioButtonIndigenousNo.Checked = value;
                }
            }
        }

        public bool applicantIsDisabled
        {
            get
            {
                if (radioButtonDisabledYes.Checked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set
            {
                if (radioButtonDisabledYes.Checked)
                {
                    radioButtonDisabledYes.Checked = value;
                }
                else
                {
                    radioButtonDisabledNo.Checked = value;
                }
            }
        }

        public string spouseFirstName
        {
            get { return textBoxSpouseFirstNameValue.Text; }
            set { textBoxSpouseFirstNameValue.Text = value; }
        }

        public string spouseLastName
        {
            get { return textBoxSpouseLastNameValue.Text; }
            set { textBoxSpouseLastNameValue.Text = value; }
        }

        public GenderType spouseGender
        {
            get { return (GenderType)comboBoxSpouseGenderValue.SelectedItem; }
            set { comboBoxSpouseGenderValue.SelectedItem = value; }
        }

        public DateTime spouseBirthday
        {
            get { return dateTimePickerSpouseDateOfBirthValue.Value; }
            set { dateTimePickerSpouseDateOfBirthValue.Value = value; }
        }

        public string spouseSinCard
        {
            get { return textBoxSpouseSinCardValue.Text; }
            set { textBoxSpouseSinCardValue.Text = value; }
        }

        public string spousePhone
        {
            get { return textBoxSpousePhoneNumberValue.Text; }
            set { textBoxSpousePhoneNumberValue.Text = value; }
        }

        public string spouseEmail
        {
            get { return textBoxSpouseEmailAddressValue.Text; }
            set { textBoxSpouseEmailAddressValue.Text = value; }
        }

        public bool spouseIsCitizen
        {
            get
            {
                if (radioButtonSpouseCitizenYes.Checked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set
            {
                if (radioButtonSpouseCitizenYes.Checked)
                {
                    radioButtonSpouseCitizenYes.Checked = value;
                }
                else
                {
                    radioButtonSpouseCitizenNo.Checked = value;
                }
            }
        }

        public bool spouseIsIndigenous
        {
            get
            {
                if (radioButtonSpouseIndigenousYes.Checked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set
            {
                if (radioButtonSpouseIndigenousYes.Checked)
                {
                    radioButtonSpouseIndigenousYes.Checked = value;
                }
                else
                {
                    radioButtonSpouseIndigenousNo.Checked = value;
                }
            }
        }

        public bool spouseIsDisabled
        {
            get
            {
                if (radioButtonSpouseDisabledYes.Checked)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set
            {
                if (radioButtonSpouseDisabledYes.Checked)
                {
                    radioButtonSpouseDisabledYes.Checked = value;
                }
                else
                {
                    radioButtonSpouseDisabledNo.Checked = value;
                }
            }
        }

        public ResidenceStatus residence
        {
            get { return (ResidenceStatus)comboBoxResidenceStatusValue.SelectedItem; }
            set { comboBoxResidenceStatusValue.SelectedItem = value; }
        }

        public string address
        {
            get { return textBoxStreetAddressValue.Text; }
            set { textBoxStreetAddressValue.Text = value; }
        }

        public string city
        {
            get { return textBoxCityValue.Text; }
            set { textBoxCityValue.Text = value; }
        }

        public ProvinceName province
        {
            get { return (ProvinceName)comboBoxProvinceValue.SelectedItem; }
            set { comboBoxProvinceValue.SelectedItem = value; }
        }

        public DateTime moveInDate
        {
            get { return dateTimePickerMoveInDateValue.Value; }
            set { dateTimePickerMoveInDateValue.Value = value; }
        }


        public string familySize
        {
            get { return textBoxFamilySizeValue.Text; }
            set { textBoxFamilySizeValue.Text = value; }
        }

        public string numberOfAdults
        {
            get { return textBoxNumberOfAdultsValue.Text; }
            set { textBoxNumberOfAdultsValue.Text = value; }
        }

        public string numberOfChildren
        {
            get { return textBoxNumberOfChildrenValue.Text; }
            set { textBoxNumberOfChildrenValue.Text = value; }
        }

        public string numberOfElderly
        {
            get { return textBoxNumberOfElderlyValue.Text; }
            set { textBoxNumberOfElderlyValue.Text = value; }
        }

        public string rentExpense
        {
            get { return textBoxRentMortgageValue.Text; }
            set { textBoxRentMortgageValue.Text = value; }
        }

        public string utilitiesExpense
        {
            get { return textBoxUtilitiesValue.Text; }
            set { textBoxUtilitiesValue.Text = value; }
        }

        public string foodExpense
        {
            get { return textBoxFoodValue.Text; }
            set { textBoxFoodValue.Text = value; }
        }

        public string tuitionExpense
        {
            get { return textBoxTuitionValue.Text; }
            set { textBoxTuitionValue.Text = value; }
        }

        public EmploymentType employment
        {
            get { return (EmploymentType)comboBoxEmploymentTypeValue.SelectedItem; }
            set { comboBoxEmploymentTypeValue.SelectedItem = value; }
        }

        public string employer
        {
            get { return textBoxEmployerValue.Text; }
            set { textBoxEmployerValue.Text = value; }
        }

        public string position
        {
            get { return textBoxPositionValue.Text; }
            set { textBoxPositionValue.Text = value; }
        }

        public DateTime startOfEmployment
        {
            get { return dateTimePickerStartOfEmploymentValue.Value; }
            set { dateTimePickerStartOfEmploymentValue.Value = value; }
        }

        public string employmentIncome
        {
            get { return textBoxEmploymentIncomeValue.Text; }
            set { textBoxEmploymentIncomeValue.Text = value; }
        }

        public string spouseIncome
        {
            get { return textBoxSpouseIncomeValue.Text; }
            set { textBoxSpouseIncomeValue.Text = value; }
        }

        public string donationIncome
        {
            get { return textBoxDonationIncomeValue.Text; }
            set { textBoxDonationIncomeValue.Text = value; }
        }

        public string cashSavings
        {
            get { return textBoxCashSavingsValue.Text; }
            set { textBoxCashSavingsValue.Text = value; }
        }

    }
}
