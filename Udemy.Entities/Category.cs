﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Entities
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        [StringLength(80)]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
