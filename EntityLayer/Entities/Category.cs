using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Category
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "Boş Geçilemez")]
        [Display(Name="Ad")]
        [StringLength(50,ErrorMessage ="MAX 50 Karakter Girebilirsiniz...")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "Açıklama")]
        [StringLength(50, ErrorMessage = "MAX 50 Karakter Girebilirsiniz...")]
        public String Description { get; set; }

        public virtual List <Product> Products { get; set; }
    }
}
