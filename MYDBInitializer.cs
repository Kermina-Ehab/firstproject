using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirst
{
    class MYDBInitializer: DropCreateDatabaseIfModelChanges<DBCONfig>
    {
        protected override void Seed(DBCONfig context)
        {
            base.Seed(context);
            
            var school1 = new School() { ID=1,Name="saintMark",type="primary" };
            var school2 = new School() { ID = 2,  Name = "saintMark", type = "primary" };
            
            var dep1 = new Department() { ID = 1, name = "bio201",schoolid=1 };
            var dep2 = new Department() { ID = 2, name = "chem201", schoolid = 1 };
            var dep3 = new Department() { ID = 2, name = "chem20", schoolid = 1 };

            context.schools.Add(school1);
            context.schools.Add(school2);

            context.departments.Add(dep1);
            context.departments.Add(dep2);
            context.departments.Add(dep3);


            context.SaveChanges();

        }
    }
}
