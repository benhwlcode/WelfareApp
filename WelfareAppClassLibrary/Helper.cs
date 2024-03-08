using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WelfareAppClassLibrary.Models;

namespace WelfareAppClassLibrary
{
    public class Helper
    {

        public string ListOfAllDocumentsJson()
        {
            string output = "";

            List<DocumentModel> documents = new List<DocumentModel>();

            DocumentModel sinCard = new DocumentModel();
            sinCard.name = "Sin Card";
            sinCard.status = DocumentStatus.waiting;

            DocumentModel driversLicense = new DocumentModel();
            driversLicense.name = "Drivers License";
            driversLicense.status = DocumentStatus.waiting;

            DocumentModel rentalAgreement = new DocumentModel();
            rentalAgreement.name = "Rental Agreement";
            rentalAgreement.status = DocumentStatus.waiting;

            DocumentModel utilityBill = new DocumentModel();
            utilityBill.name = "Utility Bill";
            utilityBill.status = DocumentStatus.waiting;

            documents.Add(sinCard);
            documents.Add(driversLicense);
            documents.Add(utilityBill);
            documents.Add(rentalAgreement);

            output = JsonSerializer.Serialize(documents);

            return output;
        }



    }
}
