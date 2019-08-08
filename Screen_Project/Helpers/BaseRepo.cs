using Microsoft.EntityFrameworkCore;
using Screen_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Interfaces;

namespace WebApplication1.Helpers
{
    public class BaseRepo<T> : IBaseRepo<T> where T : class
    {
        private ScreenContext context;

        public BaseRepo(ScreenContext ScreenContext)
        {
           context = ScreenContext;
        }

        public async Task<T> GetAsync(int Y)
        {
            return await context.FindAsync<T>(Y);
        }

        public async Task<List<T>> GetAll()
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task<T> AddAsync(T Y)
        {
            await context.AddAsync(Y);
            await context.SaveChangesAsync();
            return Y;
        }

        public async Task<T> UpdateAsync(int id, T Y)
        {
            context.Update(Y);
            await context.SaveChangesAsync();
            return Y;
        }

        public async Task<bool> RemoveAsync(int id, T Y)
        {
            bool deleted = false;
            context.Remove(Y);
            await context.SaveChangesAsync();
            deleted = true;
            return deleted;
        }
    }
}
