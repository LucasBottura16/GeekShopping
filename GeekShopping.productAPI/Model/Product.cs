using GeekShopping.productAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.productAPI.Model
{
    [Table("product")]
    public class Product : BaseEntity
    {
        [Column("name")]
        [Required]
        [StringLength(150)]  
        public string Name { get; set; }

        [Column("price")]
        [Required]
        [Range(1,1000)]
        public decimal Price { get; set; }

        [Column ("description")]
        [StringLength(500)]
        public string Description { get; set; }

        [Column("category_name")]
        [StringLength (50)]
        public String CategoryName { get; set; }

        [Column("image_url")]
        [Required]
        [StringLength(300)]
        public string ImageURL { get; set; }
    }
}
