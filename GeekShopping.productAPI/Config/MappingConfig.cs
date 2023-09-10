using AutoMapper;
using GeekShopping.productAPI.Data.Value_Objects;
using GeekShopping.productAPI.Model;

namespace GeekShopping.productAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps() 
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductVO, Product>();
                config.CreateMap<Product, ProductVO>();
            });
            return mappingConfig;
        }  
    }
}
