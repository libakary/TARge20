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
        public DbSet<Osakond> Osakond { get; set; }
        public DbSet<Peakontor> Peakontor { get; set; }
        public DbSet<Ametinimetus> Ametinimetus { get; set; }
        public DbSet<Ligipaasuluba> Ligipaasuluba { get; set; }
        public DbSet<Vihjed> Vihjed { get; set; }
        public DbSet<Palved> Palved { get; set; }
        public DbSet<LaenuTooted> LaenuTooted { get; set; }
        public DbSet<Haigusleht> Haigusleht { get; set; }
        public DbSet<TerviseKontroll> TerviseKontroll { get; set; }
        public DbSet<Puhkused> Puhkused { get; set; }

    }
}