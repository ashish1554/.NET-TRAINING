using AutoMapper;
using DAY1.DTO;
using DAY1.Model;

namespace DAY1.Mappings
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Product,ProductShowDto>();
            CreateMap<Product,CreateProductDto>().ReverseMap();
      

        }
    }
}
