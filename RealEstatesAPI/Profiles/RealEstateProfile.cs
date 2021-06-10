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
            CreateMap<Entities.Models.RealEstate, DTOS.RealEstateDto>();
            CreateMap<Entities.Models.RealEstate, DTOS.AuthorizedRealEstateDto>();
        }
    }
}
