using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularAPI.Models.Repositories
{
    public interface IServiceRepository<T>
    {
        public Task<IList<T>> ListAllAsync(string searchTerm,int? brandId,int? categoryId);
        public Task<T> GetByIdAsync(int id);
     
    }
}
