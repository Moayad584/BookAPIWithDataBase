using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
   public class Book
    {
        public int BookId { get; set; }
        [Required(ErrorMessage ="Invalid Empty Name")]
        [StringLength(50)]
        public string BookName { get; set; }

        [Required]
        [StringLength(10)]
        public string AuthorName { get; set; }
    }
}
