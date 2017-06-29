using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Heroko.DTO
{
    public class CalculadoraDTO
    {
        [Required]
        [Display(Name = "Número 1")]
        public int Numero1 { get; set; }
        [Required]
        [Display(Name = "Número 2")]
        public int Numero2 { get; set; }
    }
}