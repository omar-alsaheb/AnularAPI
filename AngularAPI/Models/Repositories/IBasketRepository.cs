using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularAPI.Models.Repositories
{
    public interface IBasketRepository
    {
        public Task<CustomerBasket> GetCustomerBasketAsync(string basketId);

        public Task<CustomerBasket> UpdateCustomerBasketAsync(CustomerBasket customerBasket);
        public Task<bool> DeleteCustomerBasketAsync(string basketId);

    }
}
