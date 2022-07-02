using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirst
{
    class DBCONfig:DbContext

    {
        public DBCONfig():base("conn")
        {
           Database.SetInitializer<DBCONfig>(new MYDBInitializer());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Teacher>().HasKey(c => c.teacherId);
            modelBuilder.Entity<Teacher>().Property(u => u.NationalID).IsRequired();
            modelBuilder.Entity<Teacher>().HasIndex(g => g.NationalID).IsUnique();
            modelBuilder.Entity<Teacher>().Property(d => d.Code).IsRequired();
            modelBuilder.Entity<Teacher>().Property(x => x.phone).IsOptional();

            modelBuilder.Configurations.Add(new SchoolConfigration());
        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<School> schools { get; set; }
        public DbSet<TeacherTransfere> TeacherTransfers { get; set; }


    }
}
