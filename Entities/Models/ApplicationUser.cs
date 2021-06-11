using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Entities.Models
{
    public class ApplicationUser : IdentityUser
    {
        public decimal Rating { get; set; }
        public int amountOfRatings { get; set; }
        public int RealEstates { get; set; }
    }
}
