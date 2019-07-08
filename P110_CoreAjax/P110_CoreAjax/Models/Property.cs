using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace P110_CoreAjax.Models
{
    public class Property
    {
        public int Id { get; set; }
        public decimal Price { get; set; }

        [Required, StringLength(100)]
        public string Address { get; set; }

        [Required]
        public string Description { get; set; }

        //navigation property
        public virtual ICollection<PropertyPhoto> PropertyPhotos { get; set; }
    }
}
