using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcWebapi.Models
{
    public class Roles
    {

        public int Id { get; set; }


        [Required(ErrorMessage = "{0} alanı boş geçilemez!")]
        [Display(Name = "Rolünüz :")]
        public string rolAdi { get; set; }

        

        //public ICollection<Users> User { get; set; }

    }
}