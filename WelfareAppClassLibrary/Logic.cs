using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WelfareAppClassLibrary.DataConnection;
using WelfareAppClassLibrary.Models;

namespace WelfareAppClassLibrary
{
    public class Logic
    {

        public void ApplicationInsertUpdateControl
            (string applicantInt, ApplicationModel saveApplication, 
            ApplicantModel saveApplicant, SpouseModel saveSpouse, ApplicantModel loadedApplicant)
        {
            SqlConnector sql = new SqlConnector();          


            if (applicantInt == "0" && saveApplication != null)
            {             
                sql.SaveToApplication(saveApplication, saveApplicant, saveSpouse);
                return;
            }

            saveApplicant.applicantId = loadedApplicant.applicantId;

            if (saveApplication != null)
            {
                sql.DeleteDuplicateApp(saveApplication.programId, saveApplicant.applicantId);
                sql.SaveToApplicationWithReturner(saveApplication, saveApplicant.applicantId);
            }

            if (saveSpouse != null && loadedApplicant.spouseId != null)
            {
                saveSpouse.spouseId = loadedApplicant.spouseId.spouseId;
            }

            if (saveSpouse != null && loadedApplicant.spouseId == null)
            {
                saveSpouse.spouseId = 0;
            }

            sql.UpdateApplicantEntry(saveApplicant, saveSpouse);

        }     


    }
}
