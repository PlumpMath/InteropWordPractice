using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyWordDoc
{
    public class PrimaryInfo
    {
        int code;
        string name;
        DateTime testingDate;
        DateTime reportDate;
        string email;
        string address;
        DateTime dob;

        public PrimaryInfo() 
        {
            this.code = 7;
            this.name = "Tester Tester";
            this.testingDate = DateTime.Now;
            this.reportDate = DateTime.Now;
            this.dob = DateTime.Now;
            this.email = "Tester@gmail.com";
            this.address = "";
        }
    }
}
