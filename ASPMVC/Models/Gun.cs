using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASPMVC.Models
{
    public class Gun
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ProductionDate { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Select a Gun Type")]
        [DisplayFormat(NullDisplayText = "Type not set")]
        public GunType Type { get; set; }

        public string Caliber { get; set; }

        [Required]
        [Range(1, 10000)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public int ManufacturerID { get; set; }
        public Manufacturer Manufacturer { get; set; }
    }

    public enum GunType
    {
        None,

        [Description("Assault Rifle")]
        Assault,

        [Description("Pistol")]
        Pistol,

        [Description("Revolver")]
        Revolver,

        [Description("Shotgun")]
        Shotgun,

        [Description("Sniper Rifle")]
        Sniper
    }
}
