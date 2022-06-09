using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Department
    {
        public Guid Id { get; set; }
        public int DepartmentNr { get; set; }
        public string DepartmentName { get; set; }
        public string Location { get; set; }
        public string PersonResponsible { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int EmployeeNumber { get; set; }
        public string Comment { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
