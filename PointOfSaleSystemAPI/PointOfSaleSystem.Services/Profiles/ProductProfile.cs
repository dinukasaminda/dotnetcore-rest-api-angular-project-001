using AutoMapper;
using PointOfSaleSystem.Models.Products;
using PointOfSaleSystem.Services.Models;

namespace PointOfSaleSystem.Services.Profiles
{
    public class ProductProfile :Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, Models.ProductDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.BarcodePrefix, opt => opt.MapFrom(src => src.BarcodePrefix))
                .ForMember(dest => dest.UpdatedDate, opt => opt.MapFrom(src => src.UpdatedDate))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedDate));

            CreateMap<CreateProductDto, Product>()
              //  .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
               // .ForMember(dest => dest.BarcodePrefix, opt => opt.MapFrom(src => src.BarcodePrefix))
                .ForMember(dest => dest.UpdatedDate, opt => opt.MapFrom(src => DateTime.Now))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => DateTime.Now));
        }
    }
}
