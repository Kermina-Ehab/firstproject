using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirst
{
    [Table("teacher transfer")]
    class TeacherTransfere
    {
        public int ID { get; set; }

        public Teacher teacherID { get; set; }

        public School fromSchool { get; set; }

        public School toSchool { get; set; }

        public DateTime Date { get; set; }

    }
}
