using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Books.API.Models
{
    public class Book
    {

        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String Genre { get; set; }
        public String AuthorName { get; set; }
        public DateTime DateTime { get; set; }
    }
}
