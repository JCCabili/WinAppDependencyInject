using EFCoreWinApp.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreWinApp.Data
{
    class DBInitializer
    {
        public static void Seed()
        {
            using (var db = new EmployeeContext())
            {

                if (db.Employees.Count() == 0)
                {
                    var emp = new Employee();
                    emp.Name = "JC Cabili";
                    emp.Inital = "JC";
                    db.Employees.Add(emp);

                    var add1 = new Address { Address1 = "175 area 4 barangay botocan", EmployeeID = emp.EmployeeID };
                    var add2 = new Address { Address1 = "10 janet ext sanmiguel vill tandang sora", EmployeeID = emp.EmployeeID };

                    db.Addresses.Add(add1);
                    db.Addresses.Add(add2);
                }

    


               

                db.SaveChanges();
            }
        }
    }
}
