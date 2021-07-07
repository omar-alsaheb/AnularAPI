using AngularAPI.DTOs;
using AngularAPI.Models;
using AngularAPI.Models.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IServiceRepository<Product> productRepository;
        private readonly IMapper mapper;
        private readonly IServiceRepository<ProductBrand> brandRepository;
        private readonly IServiceRepository<ProductCategory> categoryRepository;

        public ProductController(IServiceRepository<Product> _productRepository,IMapper mapper,IServiceRepository<ProductBrand> _brandRepository,IServiceRepository<ProductCategory> _categoryRepository)
        {
            this.mapper = mapper;
            brandRepository = _brandRepository;
            categoryRepository = _categoryRepository;
            productRepository = _productRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Product>>> GetProducts(string searchTerm, int? brandId, int? categoryId)
        {

            var products = await productRepository.ListAllAsync(searchTerm, brandId,  categoryId);
            var productsDTO = mapper.Map<IList<ProductDTO>>(products); // This line for DTO (Specific the field what you want exactly)
            return Ok(productsDTO);
        }
        [HttpGet("Product/{id}")]
        public async Task<ActionResult<Product>> GetProducts(int id)
        {
            var products = await productRepository.GetByIdAsync(id);
            var productsDTO = mapper.Map<ProductDTO>(products); // This line for DTO (Specific the field what you want exactly)

            return Ok(productsDTO);
        }

        [HttpGet("Brands/{id}")]
        public async Task<ActionResult<ProductBrand>> GetBrandsId(int id)
        {
            var brands = await brandRepository.GetByIdAsync(id);

            return Ok(brands);
        }

        [HttpGet("Brands")]
        public async Task<ActionResult<IList<ProductBrand>>> GetBrands(string sort, int? brandId, int? categoryId)
        {
            var barnds = await brandRepository.ListAllAsync(sort, brandId, categoryId);
            return Ok(barnds);
        }

        [HttpGet("Category/{id}")]
        public async Task<ActionResult<ProductBrand>> GetCategoryId(int id)
        {
            var Category = await categoryRepository.GetByIdAsync(id);

            return Ok(Category);
        }

        [HttpGet("Category")]
        public async Task<ActionResult<IList<ProductBrand>>> GetCategory(string sort, int? brandId, int? categoryId)
        {
            var Category = await categoryRepository.ListAllAsync(sort, brandId, categoryId);
            return Ok(Category);
        }
    }
}
