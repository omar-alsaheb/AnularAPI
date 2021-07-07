using AngularAPI.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularAPI.Models.Repositories
{
    public class CategoryRepository : IServiceRepository<ProductCategory>
    {
        private readonly AppDbContext appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<ProductCategory> GetByIdAsync(int id)
        {
            var categ = await appDbContext.ProductCategories.Where(x => x.Id == id).SingleOrDefaultAsync();
            return categ;
        }

        public async Task<IList<ProductCategory>> ListAllAsync(string searchTerm, int? brandId, int? categoryId)
        {
            var categ = await appDbContext.ProductCategories.ToListAsync();
            return categ;
        }
    }
}
