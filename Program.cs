using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirst
{
    class Program
    {
        static void Main(string[] args)
        {
             //Database.SetInitializer<DBCONfig>(new MYDBInitializer());
            DBCONfig db = new DBCONfig();
            

                var dep1 = new Department() { ID = 1, name = "bio201",schoolid=2 };
                db.departments.Add(dep1);
                db.SaveChanges();

            
        }
    }
}
