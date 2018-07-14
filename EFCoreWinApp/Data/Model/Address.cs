using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreWinApp.Data.Model
{
    public class Address
    {
        public int AddressID { get; set; }
        public string Address1 { get; set; }

        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
    }
}
