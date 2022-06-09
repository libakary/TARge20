using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class JobTitle
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        [ForeignKey("DepartmentFK")]
        public virtual Department Department { get; set; }
        public Guid DepartmentFK { get; set; }

        public string Comment { get; set; }

    }
}
