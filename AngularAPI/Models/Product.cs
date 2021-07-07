using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularAPI.Models
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string PictureUrl { get; set; }
        public string Dsecription { get; set; }

        public decimal Price { get; set; }
        public string SKU { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }

        public int ProductCategoryId { get; set; }

        public virtual ProductBrand ProductBrand { get; set; }

        public int ProductBrandId { get; set; }
    }
}

// All code added by Omar