using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace WebApi
{
    public class Genre
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        
        public ICollection<Book> Books { get; set; }
    }
}