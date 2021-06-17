using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstatesAPI.Profiles
{
    public class RatingProfile : Profile
    {
        public RatingProfile()
        {
            CreateMap<DTOS.RateUserDto, Entities.Models.Rating>();
            CreateMap<DTOS.RateUserByUserNameDto, Entities.Models.Rating>();
        }
    }
}
