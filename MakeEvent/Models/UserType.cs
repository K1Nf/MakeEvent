using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MakeEvent.Models
{
    public class UserType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Тип")]
        public string Name {  get; set; }
    }
}
