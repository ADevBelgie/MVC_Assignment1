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
        public int productID { get; set; }//FK
        public ProductTShirtViewModel product { get; set; }
        [DisplayName("Aantal")]
        public int Amount { get; set; }
    }
}
