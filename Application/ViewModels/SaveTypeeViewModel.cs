using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class SaveTypeeViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre del tipo es obligatorio")]
        public string Name { get; set; }
    }
}
