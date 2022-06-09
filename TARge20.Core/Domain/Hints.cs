using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Hints
    {
        [Key]
        public Guid Id { get; set; }
        public string Contents { get; set; }

        [ForeignKey("MainOfficeFK")]
        public virtual MainOffice MainOffice { get; set; }
        public Guid MainOfficeFK { get; set; }

        public DateTime EntryDate { get; set; }
        public string Comment { get; set; }
    }
}
