using Application.Services;
using Application.ViewModels;
using Database;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Pokedex.Controllers
{
    public class PokemonController : Controller
    {
        private readonly PokemonService _pokemonService;
        private readonly RegionService _regionService;
        private readonly TypeeService _typeeService;

        public PokemonController(ApplicationContext dbContext)
        {
            _pokemonService = new(dbContext);
            _regionService = new(dbContext);
            _typeeService = new(dbContext);
        }
        public async Task<IActionResult> Index()
        {
            return View(await _pokemonService.GetAllViewModel());
        }

        public async Task<IActionResult> Create()
        {
            return View("SavePokemon", await _pokemonService.GetRegionFinally());
        }

        [HttpPost]
        public async Task<IActionResult> Create(SavePokemonViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View("SavePokemon", vm);
            }

            await _pokemonService.Add(vm);
            return RedirectToRoute(new { controller = "Pokemon", action = "Index" });
        }

        public async Task<IActionResult> Edit(int id)
        {
            return View("SavePokemon", await _pokemonService.GetByIdSaveViewModel(id));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SavePokemonViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View("SavePokemon", vm);
            }

            await _pokemonService.Update(vm);
            return RedirectToRoute(new { controller = "Pokemon", action = "Index" });
        }
        public async Task<IActionResult> Delete(int id)
        {
            return View(await _pokemonService.GetByIdSaveViewModel(id));
        }

        [HttpPost]
        public async Task<IActionResult> DeletePost(int id)
        {
            await _pokemonService.Delete(id);
            return RedirectToRoute(new { controller = "Pokemon", action = "Index" });
        }
    }
}
