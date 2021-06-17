using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class RealEstate
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [MinLength(10)]
        [MaxLength(1000)]
        public string Description { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        [MinLength(4)]
        [MaxLength(4)]
        [Range(1600, 2100)]
        public int ConstructionYear { get; set; }
        public int SellingPrice { get; set; }
        public int RentingPrice { get; set; }
        public bool CanBeSold { get; set; }
        public bool CanBeRented { get; set; }
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string ImgUrl { get; set; }
        [ForeignKey("RealEstateTypeId")]
        public RealEstateType PropertyType { get; set; }
        public int RealEstateTypeId { get; set; }
        public ICollection<Comment> Comments { get; set; }
            = new List<Comment>();
    }
}
