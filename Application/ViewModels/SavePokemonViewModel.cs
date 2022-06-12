using Database.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class SavePokemonViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe colocar el nombre del Pokemón")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Debe colocar la Url de la imagen del Pokemón")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Debe colocar el tipo primario del Pokemón")]
        public int TipoPrimario { get; set; }
        public int TipoSecundario { get; set; }
        [Required(ErrorMessage = "Debe colocar la región del Pokemón")]
        public int RegionId { get; set; }
        public List<Region> region { get; set; }
        //public List<SaveTypeeViewModel> saveTypeeViewModels { get; set; }
        public List<Typee> Typee{ get; set; }
    }
}
