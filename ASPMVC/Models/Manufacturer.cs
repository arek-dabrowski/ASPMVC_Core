using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASPMVC.Models
{
    public class Manufacturer
    {
        public int ManufacturerID { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Country { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Headquarters { get; set; }

        [Display(Name = "Founded")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FoundDate { get; set; }
    }
}
