using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class AccessPermission
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("MainOfficeFK")]
        public virtual MainOffice MainOffice { get; set; }
        public Guid MainOfficeFK { get; set; }

        [ForeignKey("DepartmentFK")]
        public virtual Department Department { get; set; }
        public Guid DepartmentFK { get; set; }

        [ForeignKey("EmployeeFK")]
        public virtual Employee Employee { get; set; }
        public Guid EmployeeFK { get; set; }

        public DateTime ValidSince { get; set; }
        public DateTime ValidUntil { get; set; }
        public string Comment { get; set; }
    }
}
