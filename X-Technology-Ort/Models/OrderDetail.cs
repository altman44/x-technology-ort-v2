using System.Collections.Generic;

namespace X_Technology_ORT.Models
{
    public class OrderDetail
    {
        public OrderDetail()
        {
            Products = new List<Product>();
        }

        public int Id { get; set; }
        
        public int Quantity { get; set; }
        
        public float UnitPrice { get; set; }
        
        public List<Product> Products { get; }
    }
}