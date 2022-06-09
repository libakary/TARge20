using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class HealthCheck
    {
        [Key]
        public Guid Id { get; set; }

        public int HealthCheckNr { get; set; }

        [ForeignKey("EmployeeFK")]
        public virtual Employee Employee { get; set; }
        public Guid EmployeeFK { get; set; }

        public DateTime NextCheckupDate { get; set; }
        public string Result { get; set; }
        public string Comment { get; set; }
    }
}
