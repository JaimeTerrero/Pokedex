using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    public class Typee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Pokemon> PokemonsPrimary { get; set; }
        public ICollection<Pokemon> PokemonsSecondary { get; set; }
    }
}
