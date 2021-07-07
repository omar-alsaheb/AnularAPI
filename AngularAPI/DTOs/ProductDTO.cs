using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularAPI.DTOs
{
    public class ProductDTO
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string PictureUrl { get; set; }
        public string Dsecription { get; set; }

        public decimal Price { get; set; }

        public string ProductCategory { get; set; }


        public string ProductBrand { get; set; }

    }
}
