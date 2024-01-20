using System.ComponentModel.DataAnnotations;

namespace MakeEvent.Models
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Тэг")]
        public string Name { get; set; }
    }
}
