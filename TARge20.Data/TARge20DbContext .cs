using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARge20.Core.Domain;

namespace TARge20.Data
{
    public class TARge20DbContext : DbContext
    {

        public TARge20DbContext(DbContextOptions<TARge20DbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Children> Children { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<MainOffice> MainOffice { get; set; }
        public DbSet<JobTitle> JobTitle { get; set; }
        public DbSet<AccessPermission> AccessPermission { get; set; }
        public DbSet<Hints> Hints { get; set; }
        public DbSet<Appeals> Appeals { get; set; }
        public DbSet<BorrowedItems> BorrowedItems { get; set; }
        public DbSet<SickLeave> SickLeave { get; set; }
        public DbSet<HealthCheck> HealthCheck { get; set; }
        public DbSet<Vacations> Vacations { get; set; }

    }
}