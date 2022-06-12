using Application.Repository;
using Application.ViewModels;
using Database;
using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class RegionService
    {
        private readonly RegionRepository _regionRepository;

        public RegionService(ApplicationContext dbContext)
        {
            _regionRepository = new(dbContext);
        }

        public async Task Update(SaveRegionViewModel vm)
        {
            Region region = new();
            region.Id = vm.Id;
            region.Name = vm.Name;
            await _regionRepository.UpdateAsync(region);
        }

        public async Task Add(SaveRegionViewModel vm)
        {
            Region region = new();
            region.Name = vm.Name;
            await _regionRepository.AddAsync(region);
        }

        public async Task Delete(int id)
        {
            var pokemon = await _regionRepository.GetByIdAsync(id);
            await _regionRepository.DeleteAsync(pokemon);
        }

        public async Task<SaveRegionViewModel> GetByIdSaveViewModel(int id)
        {
            var region = await _regionRepository.GetByIdAsync(id);

            SaveRegionViewModel vm = new();
            vm.Id = region.Id;
            vm.Name = region.Name;

            return vm;
        }

        public async Task<List<RegionViewModel>> GetAllViewModel()
        {
            var regionList = await _regionRepository.GetAllAsync();
            return regionList.Select(region => new RegionViewModel
            {
                Id = region.Id,
                Name = region.Name,
            }).ToList();
        }
    }
}
