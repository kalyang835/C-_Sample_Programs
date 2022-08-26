using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Z1.Model
{
    public class Leader
    {    [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int RollNo { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
       
        public int DOB { get; set; }
        







    }
}
