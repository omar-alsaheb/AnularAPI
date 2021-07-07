﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularAPI.Models
{
    public class ProductCategory
    {
        public int Id { get; set; }

        public string Name { get; set; }


        public virtual IList<Product> Products { get; set; }
    }
}
