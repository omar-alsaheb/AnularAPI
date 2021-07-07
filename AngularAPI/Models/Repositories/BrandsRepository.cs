using AngularAPI.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularAPI.Models.Repositories
{
    public class BrandsRepository : IServiceRepository<ProductBrand>
    {
        private readonly AppDbContext appDbContext;

        public BrandsRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<ProductBrand> GetByIdAsync(int id)
        {

            var brands =await appDbContext.ProductBrands.Where(x => x.Id == id).SingleOrDefaultAsync();
            return brands;
        }


        public async Task<IList<ProductBrand>> ListAllAsync(string searchTerm, int? brandId, int? categoryId)
        {
            var brands = await appDbContext.ProductBrands.ToListAsync();

            return brands;
        }
    }
}
