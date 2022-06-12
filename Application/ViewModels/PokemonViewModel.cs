using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class PokemonViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string TipoPrimario { get; set; }
        public string TipoSecundario { get; set; }
        public int RegionId { get; set; }
        public string RegionName { get; set; }
    }
}
