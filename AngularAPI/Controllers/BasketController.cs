using AngularAPI.Models;
using AngularAPI.Models.Repositories;
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
    public class BasketController : ControllerBase
    {
        private readonly IBasketRepository basketRepository;

        public BasketController(IBasketRepository _basketRepository)
        {
            basketRepository = _basketRepository;
        }


        [HttpGet]
        public async Task<ActionResult<CustomerBasket>> GetBasketAsync(string Id)
        {
            var basket =await basketRepository.GetCustomerBasketAsync(Id);
            return Ok(basket ?? new CustomerBasket(Id));

        }
        [HttpPost]
        public async Task<ActionResult<CustomerBasket>> UpdateBasketAsync(CustomerBasket customerBasket)
        {
            var basket = await basketRepository.UpdateCustomerBasketAsync(customerBasket);
            return Ok(basket);

        }

        [HttpDelete]

        public async Task DeleteBasketAsync(string Id)
        {
            var basket = await basketRepository.DeleteCustomerBasketAsync(Id);

            
        }
    }
}
