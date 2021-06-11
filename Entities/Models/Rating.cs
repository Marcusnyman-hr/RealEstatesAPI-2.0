using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }
        public int Value { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }


    }
}
