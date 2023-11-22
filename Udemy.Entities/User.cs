using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Entities
{
    public class User
    {
        [Key]
        [StringLength(40)]
        public string Email { get; set; }
        [Required]
        [StringLength(30)]
        public string Clave { get; set; }
        [Required]
        public int RolId { get; set; }
    }
}
