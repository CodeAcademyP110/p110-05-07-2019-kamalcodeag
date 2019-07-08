using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practice2.Models
{
    public class HousePhoto
    {
        public int Id { get; set; }

        [Required]
        public string Image { get; set; }
        public int HouseId { get; set; }
        public virtual House House { get; set; }
    }
}
