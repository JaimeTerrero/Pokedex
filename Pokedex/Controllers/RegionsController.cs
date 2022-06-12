using Application.Services;
using Application.ViewModels;
using Database;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Pokedex.Controllers
{
    public class RegionsController : Controller
    {
        private readonly RegionService _regionService;

        public RegionsController(ApplicationContext dbContext)
        {
            _regionService = new(dbContext);
        }

        public async Task<IActionResult> Index()
        {
            return View(await _regionService.GetAllViewModel());
        }

        public IActionResult Create()
        {
            return View("SaveRegions", new SaveRegionViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Create(SaveRegionViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View("SaveRegions", vm);
            }

            await _regionService.Add(vm);
            return RedirectToRoute(new { controller = "Regions", action = "Index" });
        }

        public async Task<IActionResult> Edit(int id)
        {
            return View("SaveRegions", await _regionService.GetByIdSaveViewModel(id));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SaveRegionViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View("SaveRegions", vm);
            }

            await _regionService.Update(vm);
            return RedirectToRoute(new { controller = "Regions", action = "Index" });
        }
        public async Task<IActionResult> Delete(int id)
        {
            return View(await _regionService.GetByIdSaveViewModel(id));
        }

        [HttpPost]
        public async Task<IActionResult> DeletePost(int id)
        {
            await _regionService.Delete(id);
            return RedirectToRoute(new { controller = "Regions", action = "Index" });
        }
    }
}
