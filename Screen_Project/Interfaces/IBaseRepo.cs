using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication1.Interfaces
{
    public interface IBaseRepo<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<T> GetAsync(int id);
        Task<T> AddAsync(T Y);
        Task<T> UpdateAsync(int id, T Y);
        Task<bool> RemoveAsync(int id, T Y);


    }
}
