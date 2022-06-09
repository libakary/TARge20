using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class SickLeave
    {
        [Key]
        public Guid Id { get; set; }

        public int SickLeaveNr { get; set; }

        [ForeignKey("EmployeeFK")]
        public virtual Employee Employee { get; set; }
        public Guid EmployeeFK { get; set; }

        public DateTime OpenDate { get; set; }
        public DateTime CloseDate { get; set; }
        public string Comment { get; set; }
    }
}
