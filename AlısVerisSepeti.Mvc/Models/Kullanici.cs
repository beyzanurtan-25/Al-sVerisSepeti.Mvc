using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AlısVerisSepeti.Mvc.Models
{
    public class Kullanici
    {
        public int kullaniciId { get; set; }
        [Display(Name ="Kullanıcı Adı")]
        [Required]
        public string kullaniciAd { get; set; }
        [Display(Name ="Şifre")]
        [Required]
        public string sifre { get; set; }
    }
}