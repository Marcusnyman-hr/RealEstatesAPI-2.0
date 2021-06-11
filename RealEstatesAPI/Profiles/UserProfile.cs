using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstatesAPI.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Entities.Models.ApplicationUser, DTOS.UserDto>()
                .ForMember(dest => dest.Comments, options => options.Ignore());
        }
    }
}
