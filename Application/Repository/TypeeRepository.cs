using Database;
using Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository
{
    public class TypeeRepository
    {
        private readonly ApplicationContext _dbContext;

        public TypeeRepository(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Typee typee)
        {
            await _dbContext.Types.AddAsync(typee);
            await _dbContext.SaveChangesAsync();
        }
        public async Task UpdateAsync(Typee typee)
        {
            _dbContext.Entry(typee).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
        public async Task DeleteAsync(Typee typee)
        {
            _dbContext.Set<Typee>().Remove(typee);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Typee>> GetAllAsync()
        {
            return await _dbContext.Set<Typee>().ToListAsync();
        }

        public async Task<Typee> GetByIdAsync(int id)
        {
            return await _dbContext.Set<Typee>().FindAsync(id);
        }
        public string GetTypeeName(int id)
        {
            return _dbContext.Set<Typee>().FindAsync(id).Result.Name;
        }
    }
}
