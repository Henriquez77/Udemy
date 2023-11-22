using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy.Entities
{
    public class Chapter
    {
        [Key]
        public int ChapterId { get; set; }
    }
}
