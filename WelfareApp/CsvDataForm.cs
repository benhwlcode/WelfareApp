using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WelfareAppClassLibrary;
using WelfareAppClassLibrary.Models;
using WelfareAppClassLibrary.Validations;

namespace WelfareApp
{
    public partial class CsvDataForm : Form
    {
        public List<ApplicantModel> validReturn = new List<ApplicantModel>();

        public ApplicationModel insertApplication = new ApplicationModel();
        public ApplicantModel insertApplicant = new ApplicantModel();
        public SpouseModel insertSpouse = new SpouseModel();

        public ApplicantModel noLoadedApplicant = new ApplicantModel();

        public int testProgramId = 4012;
        public int testingRang = 200;


        public CsvDataForm()
        {
            InitializeComponent();
        }

        private void buttonInsertData_Click(object sender, EventArgs e)
        {
            Logic logic = new Logic();

            validReturn = GetDataSetApplicants();
            insertApplication = GetApplicationInformation();

            foreach (ApplicantModel app in validReturn)
            {
                insertApplicant = app;
                insertSpouse = app.spouseId;

                logic.ApplicationInsertAndUpdate("0", insertApplication, insertApplicant, 
                    insertSpouse, noLoadedApplicant);
            }


        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonShowValid_Click(object sender, EventArgs e)
        {

        }

        private void buttonShowInvalid_Click(object sender, EventArgs e)
        {

        }

        public ApplicationModel GetApplicationInformation()
        {
            Helper helper = new Helper();

            ApplicationModel output = new ApplicationModel();

            output.applicationId = 0;
            output.applicationId = 0;

            output.programId = testProgramId;
            output.agentId = 1;
            output.officeId = 1;
            output.supervisorId = 1;

            output.applicationProgress = ApplicationProgress.ongoing;
            output.eligibilityStatus = EligibilityStatus.pending;
            output.approvalStatus = ApprovalStatus.pending;
            output.paymentStatus = PaymentStatus.pending;

            output.signatureSigned = true;
            output.acceptedDate = DateOnly.FromDateTime(DateTime.Now).ToString();

            output.listOfDocuments = helper.ListOfAllDocumentsJson();

            return output;

        }


        private List<ApplicantModel> GetDataSetApplicants()
        {
            List<ApplicantModel> output = new List<ApplicantModel>();

            string personPath = @"C:\Users\benli\Documents\Coding\Kaggle\WelfareApp\person.csv";
            string addressPath = @"C:\Users\benli\Documents\Coding\Kaggle\WelfareApp\address.csv";
            string incomePath = @"C:\Users\benli\Documents\Coding\Kaggle\WelfareApp\income.csv";
            string familyPath = @"C:\Users\benli\Documents\Coding\Kaggle\WelfareApp\family.csv";
            string employmentPath = @"C:\Users\benli\Documents\Coding\Kaggle\WelfareApp\employment.csv";

            List<string> people = File.ReadAllLines(personPath).ToList();            
            List<string> addresses = File.ReadAllLines(addressPath).ToList();
            List<string> incomes = File.ReadAllLines(incomePath).ToList();
            List<string> families = File.ReadAllLines(familyPath).ToList();
            List<string> employments = File.ReadAllLines(employmentPath).ToList();

            people.Remove(people[0]);
            addresses.Remove(addresses[0]);
            incomes.Remove(incomes[0]);
            families.Remove(families[0]);
            employments.Remove(employments[0]);


            for (int i = 0; i < testingRang; i++)
            {             


                string[] person = people[i].Split(',');
                string[] spouse = people[testingRang+i].Split(",");
                string[] address = addresses[i].Split(',');
                string[] income = incomes[i].Split(',');
                string[] family = families[i].Split(',');
                string[] employment = employments[i].Split(',');

                ApplicantModel app = new ApplicantModel();
                SpouseModel spo = new SpouseModel();

                int currentAdults = 1;

                app.firstName = person[2];
                app.lastName = person[3];
                app.sinCard = GenerateSinCard();
                                
                if (family[6].Trim('"') != "Unknown")
                {
                    app.maritalStatus = 
                        (MaritalStatus)Enum.Parse(typeof(MaritalStatus), family[6].Trim('"'));
                    currentAdults++;
                }
                else if (family[6].Trim('"') == "Unknown")
                {
                    app.maritalStatus = MaritalStatus.Widowed;
                }

                app.birthday = GetCorrectDateTimeFormatDigits(person[5]);
                app.gender = (GenderType)Enum.Parse(typeof(GenderType), person[4]);
                app.email = person[7];
                app.phone = person[6];
                app.isCitizen = GenerateTrueFalse();
                app.isIndigenous = GenerateTrueFalse();
                app.isDisabled = GenerateTrueFalse();

                if (income[11] == "0")
                {
                    app.residenceStatus = ResidenceStatus.homeowner;
                }
                else
                {
                    app.residenceStatus = ResidenceStatus.renting;
                }

                app.streetAddress = address[2];
                app.city = address[0];
                app.province = ProvinceName.ON;
                app.moveInDate = GenerateRandomDate();

                app.familySize = currentAdults + Int32.Parse(family[4]);
                app.numberOfAdults = currentAdults;
                app.numberOfChildren = Int32.Parse(family[4]);
                app.numberOfElderly = 0;

                app.rentalExpense = Int32.Parse(income[11]);
                app.utilityExpense = GenerateLowExpense();
                app.foodExpense = GenerateHighExpense();
                app.tuitionExpense = GenerateMedExpense();

                if (employment[4] != "")
                {
                    app.employmentType = EmploymentType.unemployed;
                }
                else
                {
                    app.employmentType = EmploymentType.fulltime;
                }

                app.employer = employment[6];
                app.position = employment[5];
                app.employmentIncome = GetMonthlyIncome(income[2]);

                if (app.employmentType == EmploymentType.unemployed)
                {
                    app.employmentStartDate = GetCorrectDateTimeFormatChara(employment[4]);
                }
                else
                {
                    app.employmentStartDate = GetCorrectDateTimeFormatChara(employment[3]);
                }

                app.spouseIncome = GenerateHighExpense();
                app.donationIncome = GenerateMedExpense();
                app.cashSavings = GenerateHighExpense();

                if (app.maritalStatus != MaritalStatus.Married)
                {
                    app.spouseId = null;                    
                }
                else
                {
                    spo.firstName = spouse[2];
                    spo.lastName = spouse[3];
                    spo.sinCard = GenerateSinCard();
                    spo.maritalStatus = MaritalStatus.Married;
                    spo.birthday = GetCorrectDateTimeFormatDigits(spouse[5]);
                    spo.gender = (GenderType)Enum.Parse(typeof(GenderType), spouse[4]);
                    spo.email = spouse[7];
                    spo.phone = spouse[6];
                    spo.isCitizen = GenerateTrueFalse();
                    spo.isIndigenous = GenerateTrueFalse();
                    spo.isDisabled = GenerateTrueFalse();

                    app.spouseId = spo;
                }

                List<ValidationResult> results = new List<ValidationResult>();
                results.Clear();
                results = ValidationHelper.Validate(app);

                if (results.Count == 0)
                {
                    output.Add(app);
                }

                
            }

            return output;


        }

        private bool GenerateTrueFalse()
        {
            bool output;

            Random rng = new Random();
            List<bool> bools = new List<bool>();
            bools.Add(true);
            bools.Add(false);

            output = bools[rng.Next(bools.Count)];


            return output;
        }

        private string GetCorrectDateTimeFormatDigits(string input)
        {
            string output;

            DateTime date = DateTime.ParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            output = date.ToString("yyyy-MM-dd");         

            return output;
        }

        private string GetCorrectDateTimeFormatChara(string input)
        {
            string output;

            DateTime date = DateTime.ParseExact(input, "dd-MMM-yy", CultureInfo.InvariantCulture);
            output = date.ToString("yyyy-MM-dd");

            return output; 
        }


        private string GenerateSinCard()
        {
            string output = "";

            Random rng = new Random();

            for (int i = 0; i < 10; i++)
            {
                output += rng.Next(0, 10).ToString();
            }



            return output;
        }

        private int GenerateLowExpense()
        {
            int output;
            List<int> expenses = new List<int>();

            expenses.Add(60);
            expenses.Add(120);
            expenses.Add(180);
            expenses.Add(240);

            Random rng = new Random();

            output = expenses[rng.Next(expenses.Count)];

            return output;
        }

        private int GenerateMedExpense()
        {
            int output;
            List<int> expenses = new List<int>();

            expenses.Add(100);
            expenses.Add(200);
            expenses.Add(300);
            expenses.Add(400);

            Random rng = new Random();

            output = expenses[rng.Next(expenses.Count)];

            return output;
        }

        private int GenerateHighExpense()
        {
            int output;
            List<int> expenses = new List<int>();

            expenses.Add(500);
            expenses.Add(600);
            expenses.Add(700);
            expenses.Add(800);

            Random rng = new Random();

            output = expenses[rng.Next(expenses.Count)];

            return output;
        }

        private int GetMonthlyIncome(string input)
        {
            int output;
            decimal monthlyIncome = Int32.Parse(input) / 12;

            output = (int)Math.Round(monthlyIncome);

            return output;
        }

        private string GenerateRandomDate()
        {
            string output;

            Random rng = new Random();

            int year;
            int month;

            year = rng.Next(2010, 2025);
            month = rng.Next(1, 13);

            string dateString = $"{year}-{month}-01";
            DateTime date = DateTime.ParseExact(dateString, "yyyy-M-dd", CultureInfo.InvariantCulture);


            output = date.ToString("yyyy-MM-dd");
            return output;
        }

        private ProvinceName RandomizeProvince()
        {
            ProvinceName output;
            List<ProvinceName> allProvinces = new List<ProvinceName>();

            allProvinces.Add(ProvinceName.AB);
            allProvinces.Add(ProvinceName.BC);
            allProvinces.Add(ProvinceName.MB);
            allProvinces.Add(ProvinceName.NB);
            allProvinces.Add(ProvinceName.NL);
            allProvinces.Add(ProvinceName.NS);
            allProvinces.Add(ProvinceName.NT);
            allProvinces.Add(ProvinceName.NU);
            allProvinces.Add(ProvinceName.ON);
            allProvinces.Add(ProvinceName.PR);
            allProvinces.Add(ProvinceName.QC);
            allProvinces.Add(ProvinceName.SK);
            allProvinces.Add(ProvinceName.YT);

            Random rng = new Random();

            output = allProvinces[rng.Next(allProvinces.Count)];
            return output;
        }



    }
}
