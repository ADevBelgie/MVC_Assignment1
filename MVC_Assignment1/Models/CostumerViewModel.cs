using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Assignment1.Models
{
    public class CostumerViewModel
    {
        public int CostumerId { get; set; } //PK
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int ShoppingBagId { get; set; } //FK
        public ShoppingBagViewModel ShoppingBag { get; set; }
    }
}
