using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Culciar_Andrei_Lab2.Models
{
    public class Publisher
    {
        public int ID { get; set; }
        [Display(Name = "Publication")]
        public string PublisherName { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
