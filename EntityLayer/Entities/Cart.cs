using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        [Display(Name = "Ürün")]
        public String UrunId { get; set; }
        [Display(Name = "Adet")]
        public String Quantity { get; set; }
        [Display(Name = "Fiyat")]
        public String Price { get; set; }
        [Display(Name = "Tarih")]
        public String Date { get; set; }
        [Display(Name = "Resim")]
        public String Image { get; set; }
        [Display(Name = "Kullanıcı")]
        public String UserID { get; set; }

    }
}
