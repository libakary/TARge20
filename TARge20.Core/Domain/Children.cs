using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Children
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("EmployeeFK")]
        public virtual Employee Employee { get; set; }
        public Guid EmployeeFK { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string IdCode { get; set; }
        public string Comment { get; set; }
    }
}
