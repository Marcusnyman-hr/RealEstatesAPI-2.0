using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstatesAPI.DTOS
{
    public class CreateCommentDto
    {
        public Guid RealEstateId { get; set; }
        public string Content { get; set; }
    }
}
