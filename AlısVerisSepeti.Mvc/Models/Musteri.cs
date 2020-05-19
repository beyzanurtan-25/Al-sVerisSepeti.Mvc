using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AlısVerisSepeti.Mvc.Models
{
    public class Musteri
    {
        public int MusteriId { get; set; }
        [Required]
        [Display(Name ="Müşterinin Adı")]
        public string MusteriAd { get; set; }
        [Required]
        [Display(Name = "Müşterinin Soyadı")]
        public string MusteriSoyad { get; set; }
        [Required]
        [Display(Name = "Şehir")]
        public string Sehir { get; set; }
    }
}