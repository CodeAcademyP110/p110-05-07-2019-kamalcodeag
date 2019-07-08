using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practice2.Models
{
    public class House
    {
        public int Id { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        [StringLength(100)]
        public string Adress { get; set; }

        [Required]
        public string Description { get; set; }

        public ICollection<HousePhoto> HousePhotos { get; set; }
    }
}
