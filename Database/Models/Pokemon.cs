using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public int TipoPrimario { get; set; }
        public int TipoSecundario { get; set; }

        public int RegionId { get; set; }
        public Region Region { get; set; }

        public Typee Type{ get; set; }
    }
}
