using EFCoreWinApp.Data.Model;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreWinApp.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("EmployeeConn")
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
