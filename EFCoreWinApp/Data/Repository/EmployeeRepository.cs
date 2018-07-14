using EFCoreWinApp.Data.Interface;
using EFCoreWinApp.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreWinApp.Data.Repository
{
    public class EmployeeRepository : Repository<Employee>, IEmployee
    {
        public IEnumerable<Employee> GetAllWithAddress()
        {
          return _context.Employees
                .Include("AddressList");
        }
    }
}
