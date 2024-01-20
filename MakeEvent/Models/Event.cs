using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MakeEvent.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Добавьте название мероприятию")]
        [Display(Name = "Название мероприятия")]
        public string Name { get; set; }


        [Required]
        [Display(Name = "Организатор мероприятия")]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User? User { get; set; }


        [Required(ErrorMessage = "Укажите место проведения мероприятия")]
        [Display(Name = "Место проведения")]
        public string Location { get; set; }


        [Required(ErrorMessage = "Укажите дату мероприятия")]
        [Display(Name = "Дата проведения")]
        public DateOnly Date { get; set; }


        [Required(ErrorMessage = "Укажите время мероприятия")]
        [Display(Name = "Время проведения")]
        public TimeOnly? Time { get; set; }


        [Required(ErrorMessage = "Укажите максимальное количество гостей")]
        [Display(Name = "Максимальное количество гостей")]
        public int Max_Ghost { get; set; }


        [Required(ErrorMessage = "Добавьте тэги для мероприятия")] // at least 1
        [Display(Name = "Тэги")]
        public int TagId { get; set; }
        [ForeignKey("TagId")]
        public Tag? Tags { get; set; }


        [Required]
        [Display(Name = "Статус мероприятия")]
        public string Status { get; set; }

        [Required(ErrorMessage = "Добавьте описание мероприятия")]
        [Display(Name = "Описание мероприятия")]
        public string? Description { get; set; }


        [Display(Name = "Дополнительная информация о мероприятии")]
        public string? Dop_Information { get; set; }
    }
}
