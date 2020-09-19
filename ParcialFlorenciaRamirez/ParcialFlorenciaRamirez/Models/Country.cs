using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace ParcialFlorenciaRamirez.Models
{
    public enum TypeCode
    {
        Americas=10,
        Europa=20,
        Asia=30,
        Africa=40,
        Oceania=50

    }
    public class Country
    {
        [Key]
        [StringLength(3,MinimumLength =3)]
        public string Alpha3Code { get; set; }

        [Required]
        public TypeCode Region { get; set; }

        [Required]
        public string Name { get; set; }

        
        public int Area { get; set; }

        [Required]
        public int CallingCode { get; set; }

        [Required]
        public string Lenguages { get; set; }

        [Url]
        [Required]
        public string Flag { get; set; }
    }
}