

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WinFormsApp22.db
{
    public class SchoolContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source = school.db");
        }
        public DbSet<Student> studenst { get; set; }
        public DbSet<Subject> subjects { get; set; }
        public DbSet<RegForm> regForms { get; set; }

    }
}
