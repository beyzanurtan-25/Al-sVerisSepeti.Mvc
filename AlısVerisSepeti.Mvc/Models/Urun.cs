using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AlısVerisSepeti.Mvc.Models
{
    public class Urun
    {
        public int UrunId { get; set; }
        [Required]
        [Display(Name = "Ürünün Adı")]
        public string UrunAd { get; set; }
        [Required]
        [Display(Name = "Ürünün Özelliği")]
        public string Ozellik { get; set; }
        [Required]
        [Display(Name = "Ürünün Fiyatı")]
        public int Fiyat { get; set; }
    }
}