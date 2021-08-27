using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC_Assignment1.Models
{
    public class ProductTShirtViewModel
    {
        [Key]
        public int ID { get; set; }
        [DisplayName("Naam")]
        public string Name { get; set; }
        [DisplayName("Prijs")]
        public double Price { get; set; }
        public string Picture { get; set; }
    }
}
