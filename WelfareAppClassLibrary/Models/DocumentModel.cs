using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelfareAppClassLibrary.Models
{
    public class DocumentModel
    {
        public int documentId { get; set; }
        public bool isNeeded { get; set; }
        public string documentName { get; set; }
        public DocumentStatus documentStatus { get; set; }
                
    }
}
