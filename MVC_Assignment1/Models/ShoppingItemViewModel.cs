using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Assignment1.Models
{
    public class ShoppingItemViewModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }//PK
        public int ShoppingBagId { get; set; }//FK
        public int ProductId { get; set; }//FK
        public ShoppingBagViewModel ShoppingBag { get; set; }
        public ProductTShirtViewModel Product { get; set; }
        [DisplayName("Aantal")]
        public int Amount { get; set; }
    }
}
