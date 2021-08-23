using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Assignment1.Models
{
    public class ShoppingItemViewModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }//PK
        public int ShoppingBagId { get; set; }//FK
        public int productID { get; set; }//FK
        public ProductTShirtViewModel product { get; set; }
        public int Amount { get; set; }
    }
}
