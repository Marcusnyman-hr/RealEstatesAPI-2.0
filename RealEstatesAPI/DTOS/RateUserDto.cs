using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstatesAPI.DTOS
{
    public class RateUserDto
    {
        public string UserId { get; set; }
        [Range(1,5)]
        public int Value { get; set; }
    }
}
