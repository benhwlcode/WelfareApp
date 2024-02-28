using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelfareAppClassLibrary.Models
{
    public class TestModel
    {
        public int testId { get; set; }
        public string testName { get; set; }

        public TestModel()
        {

        }


        public TestModel(string nameInput)
        {
            testName = nameInput;
        }
    }


}
