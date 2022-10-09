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
    public class PokemonService
    {
        private readonly PokemonRepository _pokemonRepository;
        private readonly RegionRepository _regionRepository;
        private readonly TypeeRepository _typeRepository;


        public PokemonService(ApplicationContext dbContext)
        {
            _pokemonRepository = new(dbContext);
            _regionRepository = new(dbContext);
            _typeRepository = new(dbContext);
        }

        public async Task Update(SavePokemonViewModel vm)
        {
            Pokemon pokemon = new();
            pokemon.Id = vm.Id;
            pokemon.Name = vm.Name;
            pokemon.ImageUrl = vm.ImageUrl;
            pokemon.TipoPrimario = vm.TipoPrimario;
            pokemon.TipoSecundario = vm.TipoSecundario;
            pokemon.RegionId = vm.RegionId;
            await _pokemonRepository.UpdateAsync(pokemon);
        }

        public async Task Add(SavePokemonViewModel vm)
        {
            Pokemon pokemon = new();
            pokemon.Name = vm.Name;
            pokemon.ImageUrl = vm.ImageUrl;
            pokemon.TipoPrimario = vm.TipoPrimario;
            pokemon.TipoSecundario = vm.TipoSecundario;
            pokemon.RegionId = vm.RegionId;
            await _pokemonRepository.AddAsync(pokemon);
        }

        public async Task Delete(int id)
        {
            var pokemon = await _pokemonRepository.GetByIdAsync(id);
            await _pokemonRepository.DeleteAsync(pokemon);
        }

        public async Task<SavePokemonViewModel> GetByIdSaveViewModel(int id)
        {
            var pokemon = await _pokemonRepository.GetByIdAsync(id);
            var region = await _regionRepository.GetAllAsync();

            SavePokemonViewModel vm = new();
            vm.Id = pokemon.Id;
            vm.Name = pokemon.Name;
            vm.ImageUrl = pokemon.ImageUrl;
            vm.TipoPrimario = pokemon.TipoPrimario;
            vm.TipoSecundario = pokemon.TipoSecundario;
            vm.RegionId = pokemon.RegionId;
            return vm;
        }

        //public async Task<SavePokemonViewModel> GetRegionFinally()
        //{
        //    var region = await _regionRepository.GetAllAsync();

        //    SavePokemonViewModel vm = new();
        //    vm.region = region;
        //    return vm;
        //}

        //public async Task<SavePokemonViewModel> GetTypeeFinally()
        //{
        //    var typee = await _typeRepository.GetAllAsync();

        //    SavePokemonViewModel vm = new();
        //    vm.Typee = typee;
        //    return vm;
        //}

        public async Task<List<PokemonViewModel>> GetAllViewModel()
        {
            var pokemonList = await _pokemonRepository.GetAllAsync();
            return pokemonList.Select(pokemon => new PokemonViewModel
            {
                Id = pokemon.Id,
                Name = pokemon.Name,
                ImageUrl = pokemon.ImageUrl,
                TipoPrimario = _typeRepository.GetTypeeName(pokemon.TipoPrimario),
                TipoSecundario = _typeRepository.GetTypeeName(pokemon.TipoSecundario),
                RegionName = _regionRepository.GetRegionName(pokemon.RegionId)
            }).ToList();
        }
    }
}
