using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstatesAPI.Profiles
{
    public class RealEstateProfile : Profile
    {
        public RealEstateProfile()
        {
            CreateMap<Entities.Models.RealEstate, DTOS.RealEstateForListDto>();
            CreateMap<Entities.Models.RealEstate, DTOS.RealEstateDto>()
                .ForMember(
                dest => dest.RealEstateType,
                opt => opt.MapFrom(src => src.PropertyType.Name)
                );
            CreateMap<Entities.Models.RealEstate, DTOS.AuthorizedRealEstateDto>();
            CreateMap<Entities.Models.RealEstate, DTOS.CreatedRealEstateDto>();
            CreateMap<DTOS.CreateRealEstateDto, Entities.Models.RealEstate>()
                .ForMember(
                dest => dest.RealEstateTypeId,
                opt => opt.MapFrom(src => src.Type)
                )
                .ForMember(
                dest => dest.CanBeRented,
                opt => opt.MapFrom
                (src => src.RentingPrice.Equals(0) ? false : true)
                )
                .ForMember(
                dest => dest.CanBeSold,
                opt => opt.MapFrom
                (src => src.SellingPrice.Equals(0) ? false : true)
                );
        }
    }
}
