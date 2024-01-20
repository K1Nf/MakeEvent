using System.ComponentModel.DataAnnotations;

namespace MakeEvent.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Роль")]
        public string Role_Name {  get; set; }
    }
}
