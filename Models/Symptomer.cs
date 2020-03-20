using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoronaSymptoms.Models
{
    public class Symptomer
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime Date { get; set; }

        [Range(1, 150)]
        [Required]
        public string Alder { get; set; }

        [Required]
        public string Køn { get; set; }

        [Required]
        public string Region { get; set; }

        [Display(Name = "Symptomer")]
        [Required]
        public bool SymptomerBool { get; set; }

        public bool Nyser { get; set; }

        public bool Hoster { get; set; }

        public bool Feber { get; set; }

        public bool Muskelømhed { get; set; }

        public bool Diarre { get; set; }

        public bool Opkast { get; set; }

        public bool Hovedpine { get; set; }

        public bool Halsonde { get; set; }

        public bool Stakåndethed { get; set; }

        public bool Udmattet { get; set; }

        public bool Sansetab { get; set; }

        public string Andet { get; set; }
    }
}
