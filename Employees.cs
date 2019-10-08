using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDHW.Data
{
    public class Employees
    {
     [Key]
     [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
     public int EID { get; set; }
     public string FN { get; set; }
     public string LN { get; set; }
     [ForeignKey("DID")]
     public Deaprtments DeptID { get; set; }
    }

}
