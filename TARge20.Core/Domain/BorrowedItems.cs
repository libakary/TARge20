using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class BorrowedItems
    {
        [Key]
        public Guid Id { get; set; }

        public int ItemCode { get; set; }
        public string ItemName { get; set; }

        [ForeignKey("EmployeeFK")]
        public virtual Employee Employee { get; set; }
        public Guid EmployeeFK { get; set; }

        [ForeignKey("DepartmentFK")]
        public virtual Department Department { get; set; }
        public Guid DepartmentFK { get; set; }

        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string Comment { get; set; }
    }
}
