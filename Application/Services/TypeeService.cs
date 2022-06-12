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
    public class TypeeService
    {
        private readonly TypeeRepository _typeeRepository;

        public TypeeService(ApplicationContext dbContext)
        {
            _typeeRepository = new(dbContext);
        }

        public async Task Update(SaveTypeeViewModel vm)
        {
            Typee typee = new();
            typee.Id = vm.Id;
            typee.Name = vm.Name;
            await _typeeRepository.UpdateAsync(typee);
        }

        public async Task Add(SaveTypeeViewModel vm)
        {
            Typee typee = new();
            typee.Name = vm.Name;
            await _typeeRepository.AddAsync(typee);
        }

        public async Task Delete(int id)
        {
            var typee = await _typeeRepository.GetByIdAsync(id);
            await _typeeRepository.DeleteAsync(typee);
        }

        public async Task<SaveTypeeViewModel> GetByIdSaveViewModel(int id)
        {
            var typee = await _typeeRepository.GetByIdAsync(id);

            SaveTypeeViewModel vm = new();
            vm.Id = typee.Id;
            vm.Name = typee.Name;

            return vm;
        }

        public async Task<List<TypeeViewModel>> GetAllViewModel()
        {
            var typeeList = await _typeeRepository.GetAllAsync();
            return typeeList.Select(typee => new TypeeViewModel
            {
                Id = typee.Id,
                Name = typee.Name,
            }).ToList();
        }
    }
}
