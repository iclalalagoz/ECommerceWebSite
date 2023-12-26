using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "Ad")]
        [StringLength(50, ErrorMessage = "MAX 50 Karakter Girebilirsiniz...")]
        public String Name { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "Soyad")]
        [StringLength(50, ErrorMessage = "MAX 50 Karakter Girebilirsiniz...")]
        public String SurName { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "E-Posta")]
        [StringLength(50, ErrorMessage = "MAX 50 Karakter Girebilirsiniz...")]
        [EmailAddress(ErrorMessage ="E-mail Formatı Şeklinde Giriniz...")]
        public String Email { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "Kullanıcı Adı")]
        [StringLength(50, ErrorMessage = "MAX 50 Karakter Girebilirsiniz...")]
        public String UserName { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "Şifre")]
        [StringLength(10, ErrorMessage = "MAX 10 Karakter Girebilirsiniz...")]
        [DataType(DataType.Password)]
        public String Password { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "Şifre")]
        [StringLength(10, ErrorMessage = "MAX 10 Karakter Girebilirsiniz...")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Şifreler Uyuşmuyor")]
        public String RePassword { get; set; }

        [StringLength(10, ErrorMessage = "MAX 10 Karakter Girebilirsiniz...")]
        public String Role { get; set; }


    }
}
