using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstatesAPI.DTOS
{
    public class UserDto
    {
        public string UserName { get; set; }
        public int RealEstates { get; set; }
        public int Comments { get; set; }
        public double Rating { get; set; }
    }
}
