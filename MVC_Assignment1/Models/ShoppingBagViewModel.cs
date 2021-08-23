using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Assignment1.Models
{
    public class ShoppingBagViewModel
    {
        public int ShoppingBagId { get; set; }//PK
        public int CostumerId { get; set; }//FK
        public DateTime TimeCreated { get; set; }
        public List<ShoppingItemViewModel> Items { get; set; }
    }
}
