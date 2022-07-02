using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace codefirst
{   
    [Table("my dept")]
    class Department

    {
        [Key]
        
        public int ID { get; set; }
        [Required][Column("myname")]
        public string name { get; set; }
        public int schoolid { get; set; }

        public School school { get; set; }

    }
}
