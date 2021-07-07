using AngularAPI.DTOs;
using AngularAPI.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularAPI.Helpers
{
    public class AutoMapperProfiles:Profile
    {

        public AutoMapperProfiles()
        {
            CreateMap<Product, ProductDTO>()
                .ForMember(opt => opt.ProductBrand, x => x.MapFrom(o => o.ProductBrand.Name))
                .ForMember(opt => opt.ProductCategory, x => x.MapFrom(o => o.ProductCategory.Name))
                .ForMember(op => op.PictureUrl, x => x.MapFrom<ProductUrlResolver>());
            
        }
    }
}
