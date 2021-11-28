using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Entities
{
    public class Movie
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public int ProductionYear { get; set; }
        public string Budget { get; set; }
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
        public int DirectorId {get;set;}
        public virtual Director Director { get; set; }

        // listing the cast of the movie with ICollection
        public virtual ICollection<Cast> Cast { get; set; }
    }
}