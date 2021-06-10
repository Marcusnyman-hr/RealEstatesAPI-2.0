using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstatesAPI.DTOS
{
    public class AuthorizedRealEstateDto
    {
        public DateTime CreatedOn { get; set; }
        public int ConstructionYear { get; set; }
        public string Address { get; set; }
        public string RealEstateType { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int SellingPrice { get; set; }
        public int RentingPrice { get; set; }
        public bool CanBeSold { get; set; }
        public bool CanBeRented { get; set; }
        public string Contact { get; set; }
        public int MyProperty { get; set; }
        public ICollection<CommentDto> Comments { get; set; }
    }
}
