using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirst
{
    class SchoolConfigration:EntityTypeConfiguration<School>
    {
        public SchoolConfigration()
        {
            this.ToTable("the school");
            this.HasKey(f => f.ID);
            this.Property(m => m.Name).HasMaxLength(100);
            this.HasMany(g => g.departmentID).WithRequired(h => h.school).HasForeignKey(h => h.schoolid);
        }
    }
}
