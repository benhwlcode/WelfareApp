using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace WelfareAppClassLibrary.Models
{
    public class DocumentModel
    {
        public string name { get; set; }
        public DocumentStatus status { get; set; }

        public string display
        {
            get
            {
                return $"{name} ({status.ToString()})";
            }
        }

    }
}
