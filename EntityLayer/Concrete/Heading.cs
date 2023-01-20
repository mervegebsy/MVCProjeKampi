using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    //diğer sınıflardan erişim sağlamak için access modifier public yapılır
    public class Heading
    {
        [Key]
        public int HeadingID { get; set; }
        [StringLength(50)]
        public string HeadingName { get; set; }
        public DateTime HeadingDate  { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category{ get; set; }
        //Başlıklar kendi içerisinde kategorilere ayrılır 
        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }
        public ICollection<Content> Contents { get; set; }
        //Başlık da içerikle ilişkilidir

    }
}
