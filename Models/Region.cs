using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoronaSymptoms.Models
{
    public class Region
    {
        [Key]
        public int RegionId { get; set; }
        
        [Required]
        [Display(Name = "Region")]
        public string RegionNavn { get; set; }
    }
}
