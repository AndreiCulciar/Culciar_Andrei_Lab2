using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Culciar_Andrei_Lab2.Models
{
    public class Authors
    {
        public int ID { get; set; }
        [Display(Name = "Author`s Name")]
        public string AuthorsName { get; set; }
        public ICollection<Book>? Books{ get; set; }
    }
}