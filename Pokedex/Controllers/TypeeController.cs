using Application.Services;
using Application.ViewModels;
using Database;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Pokedex.Controllers
{
    public class TypeeController : Controller
    {
        private readonly TypeeService _typeeService;

        public TypeeController(ApplicationContext dbContext)
        {
            _typeeService = new(dbContext);
        }

        public async Task<IActionResult> Index()
        {
            return View(await _typeeService.GetAllViewModel());
        }

        public IActionResult Create()
        {
            return View("SaveTypee", new SaveTypeeViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Create(SaveTypeeViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View("SaveTypee", vm);
            }

            await _typeeService.Add(vm);
            return RedirectToRoute(new { controller = "Typee", action = "Index" });
        }

        public async Task<IActionResult> Edit(int id)
        {
            return View("SaveTypee", await _typeeService.GetByIdSaveViewModel(id));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SaveTypeeViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View("SaveTypee", vm);
            }

            await _typeeService.Update(vm);
            return RedirectToRoute(new { controller = "Typee", action = "Index" });
        }
        public async Task<IActionResult> Delete(int id)
        {
            return View(await _typeeService.GetByIdSaveViewModel(id));
        }

        [HttpPost]
        public async Task<IActionResult> DeletePost(int id)
        {
            await _typeeService.Delete(id);
            return RedirectToRoute(new { controller = "Typee", action = "Index" });
        }
    }
}
