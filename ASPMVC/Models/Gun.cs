using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPMVC.Models
{
    public class Gun
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime ProductionDate { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
    }
}
