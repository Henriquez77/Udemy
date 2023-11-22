using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Entities
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        [StringLength(60)]
        public string Email { get; set; }
        [Required]
        [StringLength(100)]
        public string  Nombre { get; set; }
        public string Nacionalidad { get; set; }
    }
}
