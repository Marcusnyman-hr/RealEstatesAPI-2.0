using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstatesAPI.DTOS
{
    public class CreateRealEstateDto
    {
        [Required(ErrorMessage = "Property title has to be provided.")]
        [MinLength(5, ErrorMessage = "Title has to contain atleast 5 characters")]
        [MaxLength(50, ErrorMessage = "Title can only contain 50 characters")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Property description has to be provided.")]
        [MinLength(10, ErrorMessage = "Description has to contain atleast 10 characters")]
        [MaxLength(1000, ErrorMessage = "Description can only contain 1000 characters")]
        public string Description { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        [Range(1600, 2100, ErrorMessage = "The constructionyear has to be between 1600 and 2100.")]
        public int ConstructionYear { get; set; }
        public int SellingPrice { get; set; }
        public int RentingPrice { get; set; }
        public int Type { get; set; }
    }
}
