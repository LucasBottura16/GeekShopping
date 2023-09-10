using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GeekShopping.productAPI.Data.Value_Objects
{
    public class ProductVO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal price { get; set; }
        public string Description { get; set; }
        public String CategoryName { get; set; }
        public string ImageURL { get; set; }
    }
}
