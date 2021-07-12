using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularAPI.Models
{
    public class CustomerBasket
    {

        public string Id { get; set; }
        public IList<CustomerItem> Items { get; set; } = new List<CustomerItem>();
        public CustomerBasket(string Id)
        {
            this.Id = Id;
        }
        public CustomerBasket()
        {
          
        }
    }
}
