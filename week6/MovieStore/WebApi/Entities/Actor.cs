using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Entities
{
    public class Actor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ActorId { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public virtual ICollection<Cast> Cast { get; set; }
    }
}