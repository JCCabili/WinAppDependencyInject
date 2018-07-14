using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreWinApp.Data.Model
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Inital { get; set; }

        public virtual ICollection<Address> AddressList { get; set; }
    }
}
