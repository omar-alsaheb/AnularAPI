using AngularAPI.DTOs;
using AngularAPI.Models;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularAPI.Helpers
{
    public class ProductUrlResolver : IValueResolver<Product, ProductDTO, string>
       
    {
        private readonly IConfiguration confgration;

        public ProductUrlResolver(IConfiguration confgration)
        {
            this.confgration = confgration;
        }
        public string Resolve(Product source, ProductDTO destination, string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.PictureUrl))
            {

                return confgration["APIUrl"] + source.PictureUrl;

            }
            else
            {
                return null;
            }
        }
    }
}
