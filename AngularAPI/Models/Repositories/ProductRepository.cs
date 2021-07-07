using AngularAPI.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularAPI.Models.Repositories
{
    public class ProductRepository : IServiceRepository<Product>
    {
        private readonly AppDbContext appDbContext;

        public ProductRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<Product> GetByIdAsync(int id)
        {
            return await appDbContext.Products.Include(x => x.ProductCategory).Include(x => x.ProductBrand).Where(x => x.Id == id).SingleOrDefaultAsync();
        }

        public async Task<IList<Product>> ListAllAsync(string searchTerm, int? brandId, int? categoryId)

        {
            var products= await appDbContext.Products.Include(x => x.ProductCategory).Include(x => x.ProductBrand).ToListAsync(); //appDbContext.Products.Include(x => x.ProductCategory).Include(x => x.ProductBrand) -SQL Statemnt "join"

            if(searchTerm != null && searchTerm != "")
            {

                products = products.Where(x => x.Name.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 || x.Dsecription.Contains(searchTerm)).ToList();
            }

            if (brandId.HasValue)
            {
                products = products.Where(x => x.ProductBrandId == brandId).ToList();

            }
            else if (categoryId.HasValue)
            {
                products = products.Where(x => x.ProductCategoryId == categoryId).ToList();
            }
            // Here for make Sorting price (sort by descending and sort by ascending)

            /*
            switch (sort)
            { 
                case "PriceAsc":
                    products = await appDbContext.Products.OrderBy(x=>x.Price).Include(x => x.ProductCategory).Include(x => x.ProductBrand).ToListAsync();
                    break;
                case "PriceDesc":
                    products = await appDbContext.Products.OrderByDescending(x => x.Price).Include(x => x.ProductCategory).Include(x => x.ProductBrand).ToListAsync();
                    break;
            }
            */
            return products;
        }
    }
}
