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
using WelfareAppClassLibrary.Validations;

namespace WelfareApp
{
    public partial class uEditApplicant : UserControl
    {

        public ErrorProvider error = new ErrorProvider();

        public uEditApplicant()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            UpdateInitialBindings();

            error.BlinkStyle = ErrorBlinkStyle.NeverBlink;
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

            if ((MaritalStatus)comboBoxMaritalStatusValue.SelectedItem == MaritalStatus.Married)
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

                labelSpouseMaritalStatusValue.Text = MaritalStatus.Married.ToString();

                textBoxSpousePhoneNumberValue.Visible = true;
                textBoxSpouseEmailAddressValue.Visible = true;

                radioButtonSpouseCitizenYes.Visible = true;
                radioButtonSpouseCitizenNo.Visible = true;
                radioButtonSpouseIndigenousYes.Visible = true;
                radioButtonSpouseIndigenousNo.Visible = true;
                radioButtonSpouseDisabledYes.Visible = true;
                radioButtonSpouseDisabledNo.Visible = true;
            }

            else
            {
                textBoxSpouseFirstNameValue.Visible = false;
                textBoxSpouseLastNameValue.Visible = false;
                comboBoxSpouseGenderValue.Visible = false;
                dateTimePickerSpouseDateOfBirthValue.Visible = false;
                textBoxSpouseSinCardValue.Visible = false;

                labelSpouseMaritalStatusValue.Text = "Not Applicapable";

                textBoxSpousePhoneNumberValue.Visible = false;
                textBoxSpouseEmailAddressValue.Visible = false;

                radioButtonSpouseCitizenYes.Visible = false;
                radioButtonSpouseCitizenNo.Visible = false;
                radioButtonSpouseIndigenousYes.Visible = false;
                radioButtonSpouseIndigenousNo.Visible = false;
                radioButtonSpouseDisabledYes.Visible = false;
                radioButtonSpouseDisabledNo.Visible = false;
            }
        }

        private void comboBoxEmploymentTypeValue_SelectedIndexChanged(object sender, EventArgs e)
        {


            CheckIfEmployed((EmploymentType)comboBoxEmploymentTypeValue.SelectedItem);
        }

        public void CheckIfEmployed(EmploymentType input)
        {
            if (input == EmploymentType.unemployed || input == EmploymentType.retired)
            {
                labelEmployerText.Text = "Latest Employer:";
                labelStartOfEmploymentText.Text = "Last Day:";

                textBoxEmployerValue.Visible = true;
                textBoxPositionValue.Visible = true;
                dateTimePickerStartOfEmploymentValue.Visible = true;
            }
            else if (input == EmploymentType.none)
            {
                labelEmployerText.Text = "Employer:";
                labelPositionText.Text = "Position";
                labelStartOfEmploymentText.Text = "Start Date:";

                textBoxEmployerValue.Text = "Not Available";
                textBoxPositionValue.Text = "Not Available";
                dateTimePickerStartOfEmploymentValue.Value = dateTimePickerDateOfBirthValue.Value;

                textBoxEmployerValue.Visible = false;
                textBoxPositionValue.Visible = false;
                dateTimePickerStartOfEmploymentValue.Visible = false;
            }
            else
            {
                labelEmployerText.Text = "Employer:";
                labelPositionText.Text = "Position";
                labelStartOfEmploymentText.Text = "Start Date:";

                textBoxEmployerValue.Visible = true;
                textBoxPositionValue.Visible = true;
                dateTimePickerStartOfEmploymentValue.Visible = true;
            }

        }

        private void textBoxFirstNameValue_TextChanged(object sender, EventArgs e)
        {
            error.SetError(textBoxFirstNameValue, 
                InputValidation.ValidLength(textBoxFirstNameValue.Text));
        }

        private void textBoxLastNameValue_TextChanged(object sender, EventArgs e)
        {
            error.SetError(textBoxLastNameValue,
                InputValidation.ValidLength(textBoxLastNameValue.Text));
        }

        private void dateTimePickerDateOfBirthValue_ValueChanged(object sender, EventArgs e)
        {
            error.SetError(dateTimePickerDateOfBirthValue,
                InputValidation.AdultsOnly(dateTimePickerDateOfBirthValue.Value));
        }

        private void textBoxSinCardValue_TextChanged(object sender, EventArgs e)
        {
            error.SetError(textBoxSinCardValue,
                InputValidation.MustBeTenDigits(textBoxSinCardValue.Text));
        }

        private void textBoxPhoneNumberValue_TextChanged(object sender, EventArgs e)
        {
            error.SetError(textBoxPhoneNumberValue,
                InputValidation.ValidPhoneNumber(textBoxPhoneNumberValue.Text));
        }

        private void textBoxEmailAddressValue_TextChanged(object sender, EventArgs e)
        {
            error.SetError(textBoxEmailAddressValue,
                InputValidation.ValidEmailAddress(textBoxEmailAddressValue.Text));
        }

        private void textBoxSpouseFirstNameValue_TextChanged(object sender, EventArgs e)
        {
            error.SetError(textBoxSpouseFirstNameValue,
                InputValidation.ValidLength(textBoxSpouseFirstNameValue.Text));
        }

        private void textBoxSpouseLastNameValue_TextChanged(object sender, EventArgs e)
        {
            error.SetError(textBoxSpouseLastNameValue,
                InputValidation.ValidLength(textBoxSpouseLastNameValue.Text));
        }

        private void dateTimePickerSpouseDateOfBirthValue_ValueChanged(object sender, EventArgs e)
        {
            error.SetError(dateTimePickerSpouseDateOfBirthValue,
                InputValidation.AdultsOnly(dateTimePickerSpouseDateOfBirthValue.Value));
        }

        private void textBoxSpouseSinCardValue_TextChanged(object sender, EventArgs e)
        {
            error.SetError(textBoxSpouseSinCardValue,
                InputValidation.MustBeTenDigits(textBoxSpouseSinCardValue.Text));
        }

        private void textBoxSpousePhoneNumberValue_TextChanged(object sender, EventArgs e)
        {
            error.SetError(textBoxSpousePhoneNumberValue,
                InputValidation.ValidPhoneNumber(textBoxSpousePhoneNumberValue.Text));
        }

        private void textBoxSpouseEmailAddressValue_TextChanged(object sender, EventArgs e)
        {
            error.SetError(textBoxSpouseEmailAddressValue,
                InputValidation.ValidEmailAddress(textBoxSpouseEmailAddressValue.Text));
        }

        private void textBoxStreetAddressValue_TextChanged(object sender, EventArgs e)
        {
            error.SetError(textBoxStreetAddressValue,
                InputValidation.ValidLength(textBoxStreetAddressValue.Text));
        }

        private void textBoxCityValue_TextChanged(object sender, EventArgs e)
        {
            error.SetError(textBoxCityValue,
                InputValidation.ValidLength(textBoxCityValue.Text));
        }

        private void dateTimePickerMoveInDateValue_ValueChanged(object sender, EventArgs e)
        {
            error.SetError(dateTimePickerMoveInDateValue,
                InputValidation.NoFutureDates(dateTimePickerMoveInDateValue.Value));
        }

        private void textBoxFamilySizeValue_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxNumberOfAdultsValue_TextChanged(object sender, EventArgs e)
        {
            error.SetError(textBoxNumberOfAdultsValue,
                InputValidation.MustBeNumber(textBoxNumberOfAdultsValue.Text));

            GetFamilySize(textBoxNumberOfAdultsValue.Text, textBoxNumberOfChildrenValue.Text, 
                textBoxNumberOfElderlyValue.Text);
        }

        private void textBoxNumberOfChildrenValue_TextChanged(object sender, EventArgs e)
        {
            error.SetError(textBoxNumberOfChildrenValue,
                InputValidation.MustBeNumber(textBoxNumberOfChildrenValue.Text));

            GetFamilySize(textBoxNumberOfAdultsValue.Text, textBoxNumberOfChildrenValue.Text,
                textBoxNumberOfElderlyValue.Text);
        }

        private void textBoxNumberOfElderlyValue_TextChanged(object sender, EventArgs e)
        {
            error.SetError(textBoxNumberOfElderlyValue,
                InputValidation.MustBeNumber(textBoxNumberOfElderlyValue.Text));

            GetFamilySize(textBoxNumberOfAdultsValue.Text, textBoxNumberOfChildrenValue.Text,
                textBoxNumberOfElderlyValue.Text);
        }

        private void textBoxRentMortgageValue_TextChanged(object sender, EventArgs e)
        {
            error.SetError(textBoxRentMortgageValue,
                InputValidation.OnlyTwoDecimals(textBoxRentMortgageValue.Text));
        }

        private void textBoxUtilitiesValue_TextChanged(object sender, EventArgs e)
        {
            error.SetError(textBoxUtilitiesValue,
                InputValidation.OnlyTwoDecimals(textBoxUtilitiesValue.Text));
        }

        private void textBoxFoodValue_TextChanged(object sender, EventArgs e)
        {
            error.SetError(textBoxFoodValue,
                InputValidation.OnlyTwoDecimals(textBoxFoodValue.Text));
        }

        private void textBoxTuitionValue_TextChanged(object sender, EventArgs e)
        {
            error.SetError(textBoxTuitionValue,
                InputValidation.OnlyTwoDecimals(textBoxTuitionValue.Text));
        }

        private void textBoxEmployerValue_TextChanged(object sender, EventArgs e)
        {
            error.SetError(textBoxEmployerValue,
                InputValidation.ValidLength(textBoxEmployerValue.Text));
        }

        private void textBoxPositionValue_TextChanged(object sender, EventArgs e)
        {
            error.SetError(textBoxPositionValue,
                InputValidation.ValidLength(textBoxPositionValue.Text));
        }

        private void dateTimePickerStartOfEmploymentValue_ValueChanged(object sender, EventArgs e)
        {
            error.SetError(dateTimePickerStartOfEmploymentValue,
                InputValidation.NoFutureDates(dateTimePickerStartOfEmploymentValue.Value));
        }

        private void textBoxEmploymentIncomeValue_TextChanged(object sender, EventArgs e)
        {
            error.SetError(textBoxEmploymentIncomeValue,
                InputValidation.OnlyTwoDecimals(textBoxEmploymentIncomeValue.Text));
        }

        private void textBoxSpouseIncomeValue_TextChanged(object sender, EventArgs e)
        {
            error.SetError(textBoxSpouseIncomeValue,
                InputValidation.OnlyTwoDecimals(textBoxSpouseIncomeValue.Text));
        }

        private void textBoxDonationIncomeValue_TextChanged(object sender, EventArgs e)
        {
            error.SetError(textBoxDonationIncomeValue,
                InputValidation.OnlyTwoDecimals(textBoxDonationIncomeValue.Text));
        }

        private void textBoxCashSavingsValue_TextChanged(object sender, EventArgs e)
        {
            error.SetError(textBoxCashSavingsValue,
                InputValidation.OnlyTwoDecimals(textBoxCashSavingsValue.Text));
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
                if (value)
                {
                    radioButtonCitizenYes.Checked = true;
                }
                else
                {
                    radioButtonCitizenNo.Checked = true;
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
                if (value)
                {
                    radioButtonIndigenousYes.Checked = true;
                }
                else
                {
                    radioButtonIndigenousNo.Checked = true;
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
                if (value)
                {
                    radioButtonDisabledYes.Checked = true;
                }
                else
                {
                    radioButtonDisabledNo.Checked = true;
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
                if (value)
                {
                    radioButtonSpouseCitizenYes.Checked = true;
                }
                else
                {
                    radioButtonSpouseCitizenNo.Checked = true;
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
                if (value)
                {
                    radioButtonSpouseIndigenousYes.Checked = true;
                }
                else
                {
                    radioButtonSpouseIndigenousNo.Checked = true;
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
                if (value)
                {
                    radioButtonSpouseDisabledYes.Checked = true;
                }
                else
                {
                    radioButtonSpouseDisabledNo.Checked = true;
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

        public void GetFamilySize(string adult, string children, string elderly)
        {
            int output = 0;
            
            int numberAdult = 0;
            int numberChildren = 0;
            int numberElderly = 0;

            Int32.TryParse(adult, out numberAdult);
            Int32.TryParse(children, out numberChildren);
            Int32.TryParse(elderly, out numberElderly);

            output += numberAdult + numberChildren + numberElderly;

            textBoxFamilySizeValue.Text = output.ToString();
        }

    }
}
