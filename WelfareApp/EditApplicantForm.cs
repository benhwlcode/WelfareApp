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
using WelfareAppClassLibrary.Models;

namespace WelfareApp
{
    public partial class EditApplicantForm : Form
    {
        uEditApplicant editApplicant = new uEditApplicant();
        ApplicantModel loadedApplicant = new ApplicantModel();

        ApplicantModel applicantToSave = new ApplicantModel();
        SpouseModel spouseToSave = new SpouseModel();   
        public EditApplicantForm(ApplicantModel input)
        {
            InitializeComponent();
            
            panelPlaceholder.Controls.Clear();
            panelPlaceholder.Controls.Add(editApplicant);

            loadedApplicant = input;

            LoadApplicantAndSpouseInfo();
        }

        private void buttonUpdateApplicant_Click(object sender, EventArgs e)
        {
            Logic logic = new Logic();

            applicantToSave = FillApplicantToSaveInfo();
            spouseToSave = FillSpouseToSaveInfo();

            logic.ApplicantUpdate(applicantToSave, spouseToSave, loadedApplicant);

        }

        public void LoadApplicantAndSpouseInfo()
        {

            editApplicant.applicantFirstName = loadedApplicant.firstName;
            editApplicant.applicationlicantLastName = loadedApplicant.lastName;
            editApplicant.applicantGender = loadedApplicant.gender;
            editApplicant.applicantBirthday = DateTime.Parse(loadedApplicant.birthday);
            editApplicant.applicantSinCard = loadedApplicant.sinCard;
            editApplicant.applicantMaritalStatus = loadedApplicant.maritalStatus;
            editApplicant.applicantPhone = loadedApplicant.phone;
            editApplicant.applicantEmail = loadedApplicant.email;
            editApplicant.applicantIsCitizen = loadedApplicant.isCitizen;
            editApplicant.applicantIsIndigenous = loadedApplicant.isIndigenous;
            editApplicant.applicantIsDisabled = loadedApplicant.isDisabled;

            if (loadedApplicant.spouseId != null)
            {
                editApplicant.spouseFirstName = loadedApplicant.spouseId.firstName;
                editApplicant.spouseLastName = loadedApplicant.spouseId.lastName;
                editApplicant.spouseGender = loadedApplicant.spouseId.gender;
                editApplicant.spouseBirthday = DateTime.Parse(loadedApplicant.spouseId.birthday);
                editApplicant.spouseSinCard = loadedApplicant.spouseId.sinCard;
                editApplicant.applicantMaritalStatus = loadedApplicant.spouseId.maritalStatus;
                editApplicant.spousePhone = loadedApplicant.spouseId.phone;
                editApplicant.spouseEmail = loadedApplicant.spouseId.email;
                editApplicant.spouseIsCitizen = loadedApplicant.spouseId.isCitizen;
                editApplicant.spouseIsIndigenous = loadedApplicant.spouseId.isIndigenous;
                editApplicant.spouseIsDisabled = loadedApplicant.spouseId.isDisabled;
            }

            editApplicant.residence = loadedApplicant.residenceStatus;
            editApplicant.address = loadedApplicant.streetAddress;
            editApplicant.city = loadedApplicant.city;
            editApplicant.province = loadedApplicant.province;
            editApplicant.moveInDate = DateTime.Parse(loadedApplicant.moveInDate);

            editApplicant.familySize = loadedApplicant.familySize.ToString();
            editApplicant.numberOfAdults = loadedApplicant.numberOfAdults.ToString();
            editApplicant.numberOfChildren = loadedApplicant.numberOfChildren.ToString();
            editApplicant.numberOfElderly = loadedApplicant.numberOfElderly.ToString();

            editApplicant.rentExpense = loadedApplicant.rentalExpense.ToString();
            editApplicant.utilitiesExpense = loadedApplicant.utilityExpense.ToString();
            editApplicant.foodExpense = loadedApplicant.foodExpense.ToString();
            editApplicant.tuitionExpense = loadedApplicant.tuitionExpense.ToString();

            editApplicant.employment = loadedApplicant.employmentType;
            editApplicant.employer = loadedApplicant.employer;
            editApplicant.position = loadedApplicant.position;
            editApplicant.startOfEmployment = DateTime.Parse(loadedApplicant.employmentStartDate);

            editApplicant.employmentIncome = loadedApplicant.employmentIncome.ToString();
            editApplicant.spouseIncome = loadedApplicant.spouseIncome.ToString();
            editApplicant.donationIncome = loadedApplicant.donationIncome.ToString();
            editApplicant.cashSavings = loadedApplicant.cashSavings.ToString();

        }

        private ApplicantModel FillApplicantToSaveInfo()
        {
            ApplicantModel output = new ApplicantModel();

            output.applicantId = loadedApplicant.applicantId;

            output.firstName = editApplicant.applicantFirstName;
            output.lastName = editApplicant.applicationlicantLastName;
            output.gender = editApplicant.applicantGender;
            output.birthday = DateOnly.FromDateTime(editApplicant.applicantBirthday).ToString();
            output.sinCard = editApplicant.applicantSinCard;
            output.maritalStatus = editApplicant.applicantMaritalStatus;
            output.phone = editApplicant.applicantPhone;
            output.email = editApplicant.applicantEmail;
            output.isCitizen = editApplicant.applicantIsCitizen;
            output.isIndigenous = editApplicant.applicantIsIndigenous;
            output.isDisabled = editApplicant.applicantIsDisabled;

            output.spouseId = null;

            output.residenceStatus = editApplicant.residence;
            output.streetAddress = editApplicant.address;
            output.city = editApplicant.city;
            output.province = editApplicant.province;
            output.moveInDate = DateOnly.FromDateTime(editApplicant.moveInDate).ToString();

            output.familySize = Int32.Parse(editApplicant.familySize);
            output.numberOfAdults = Int32.Parse(editApplicant.numberOfAdults);
            output.numberOfChildren = Int32.Parse(editApplicant.numberOfChildren);
            output.numberOfElderly = Int32.Parse(editApplicant.numberOfElderly);

            output.rentalExpense = Int32.Parse(editApplicant.rentExpense);
            output.utilityExpense = Int32.Parse(editApplicant.utilitiesExpense);
            output.foodExpense = Int32.Parse(editApplicant.foodExpense);
            output.tuitionExpense = Int32.Parse(editApplicant.tuitionExpense);

            output.employmentType = editApplicant.employment;
            output.employer = editApplicant.employer;
            output.position = editApplicant.position;
            output.employmentStartDate = DateOnly.FromDateTime(editApplicant.startOfEmployment).ToString();

            output.employmentIncome = Int32.Parse(editApplicant.employmentIncome);
            output.spouseIncome = Int32.Parse(editApplicant.spouseIncome);
            output.donationIncome = Int32.Parse(editApplicant.donationIncome);
            output.cashSavings = Int32.Parse(editApplicant.cashSavings);

            return output;
        }

        private SpouseModel FillSpouseToSaveInfo()
        {
            SpouseModel output = new SpouseModel();

            if (editApplicant.applicantMaritalStatus == MaritalStatus.Married)
            {

                output.firstName = editApplicant.spouseFirstName;
                output.lastName = editApplicant.spouseLastName;
                output.gender = editApplicant.spouseGender;
                output.birthday = DateOnly.FromDateTime(editApplicant.spouseBirthday).ToString();
                output.sinCard = editApplicant.spouseSinCard;

                output.maritalStatus = editApplicant.applicantMaritalStatus;

                output.phone = editApplicant.spousePhone;
                output.email = editApplicant.spouseEmail;
                output.isCitizen = editApplicant.spouseIsCitizen;
                output.isIndigenous = editApplicant.spouseIsIndigenous;
                output.isDisabled = editApplicant.spouseIsDisabled;


                return output;
            }

            else
            {
                output = null;
                return output;
            }


        }
    }
}
