using AutoMapper;
using PointOfSaleSystem.Models.Product;
using PointOfSaleSystem.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleSystem.Services.Profiles
{
    public class ProductProfile :Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductEntity, Models.ProductDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.BarcodePrefix, opt => opt.MapFrom(src => src.BarcodePrefix))
                .ForMember(dest => dest.UpdatedDate, opt => opt.MapFrom(src => src.UpdatedDate))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CreatedDate));

            CreateMap<CreateProductDto, ProductEntity>()
              //  .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
               // .ForMember(dest => dest.BarcodePrefix, opt => opt.MapFrom(src => src.BarcodePrefix))
                .ForMember(dest => dest.UpdatedDate, opt => opt.MapFrom(src => DateTime.Now))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => DateTime.Now));
        }
    }
}
