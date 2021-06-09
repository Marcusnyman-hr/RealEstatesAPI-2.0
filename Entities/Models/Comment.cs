using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class Comment
    {
        [Key]
        public Guid Id { get; set; }
        public string Content { get; set; }
        public string UserName { get; set; }
        public DateTime CreatedOn { get; set; }
        [ForeignKey("RealEstateId")]
        public Guid RealEstateId { get; set; }
        public RealEstate RealEstate { get; set; }
        public Guid UserId { get; set; }
    }
}
