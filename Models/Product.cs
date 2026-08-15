using System.ComponentModel.DataAnnotations.Schema;

namespace Computer_shop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string ImagePath { get; set; }

        // Foreign Key
        public int CategoryId { get; set; }

        // Navigation properties
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}
