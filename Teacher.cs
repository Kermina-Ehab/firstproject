using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefirst
{
   
    class Teacher
    {   
       
        public int teacherId { get; set; }
        
        public School schoolId { get; set; }
        public string Name { get; set; }
        public DateTime birthDate { get; set; }
        public int NationalID { get; set; } //unique
        public int Code { get; set; }  //unique
        
       
        public string Job { get; set; }
        public int phone { get; set; }
        public string Qualification { get; set; }
        public  DateTime QualificationData { get; set; }
        
        public DateTime HiringDate { get; set; }
        public string Address { get; set; }
        public string Notes { get; set; }



      }
}
