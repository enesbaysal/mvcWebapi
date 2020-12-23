using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcWebapi.Models
{
    public class Users
    {

        public int Id { get; set; }


        [Required(ErrorMessage = "{0} alanı boş geçilemez!")]
        [Display(Name = "Kullanıcı Adı :")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "{0} alanı boş geçilemez!")]
        [Display(Name = "Kullanıcı Soyadı :")]
        public string Soyad { get; set; }

        [Required(ErrorMessage = "{0} alanı boş geçilemez!")]
        [EmailAddress(ErrorMessage = "Geçersiz Email Adresi")]
        [Display(Name = "Kullanıcı Email :")]
        public string Email { get; set; }


        [Required(ErrorMessage = "{0} alanı boş geçilemez!")]
        [Display(Name = "Rolünüz :")]
        public string rolAd { get; set; }

       // public virtual Roles Role { get; set; }
     

    }
}