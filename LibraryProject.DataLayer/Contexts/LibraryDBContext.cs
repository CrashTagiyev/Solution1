using LibraryProject.Models.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DataLayer.Contexts
{
    internal class LibraryDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies()
            .UseSqlServer("Data Source=DESKTOP-HFMQLBA\\MSSQLSERVER01;Initial Catalog=LibraryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }
       public virtual DbSet<Book> Books { get; set; }
       public virtual DbSet<Author> Authors { get; set; }
       public virtual DbSet<Category> Categories { get; set; }
       public virtual DbSet<Themes> Themes { get; set; }
       public virtual DbSet<Press> Presses { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Faculties> Faculties { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<Teachers> Teachers { get; set; }
        public virtual DbSet<Students> Students { get; set; }

        public virtual DbSet<SCards> S_Cards { get; set; }
        public virtual DbSet<Libs> Libs { get; set; }
        public virtual DbSet<TCards> T_Cards { get; set; }
    }
}
 