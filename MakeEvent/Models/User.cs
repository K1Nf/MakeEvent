using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using static System.Net.Mime.MediaTypeNames;

namespace MakeEvent.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }


        [Required]
        public int RoleId { get; set; }                // Обычный юзер, админ или незарег
        [ForeignKey("RoleId")]
        public Role? Role { get; set; }                // Обычный юзер, админ или незарег


        [Required]
        [Display(Name = "Тип юзера")]
        public int UserTypeId { get; set; }           // ЮрЛ, ФЛ, 
        [ForeignKey("UserTypeId")]
        public UserType? UserType { get; set; }           // ЮрЛ, ФЛ, 


        [Required(ErrorMessage = "Придумайте логин")]
        [Display(Name = "Ник")]
        public string NickName { get; set; }


        [Required(ErrorMessage = "Введите имя")]
        [Display(Name = "Имя")]
        public string First_Name { get; set; }             // имя


        [Required(ErrorMessage = "Введите фамилию")]
        [Display(Name = "Фамилия")]
        public string Last_Name { get; set; }              // фамилия


        [Required(ErrorMessage = "Введите отчество")]
        [Display(Name = "Отчество")]
        public string Middle_Name { get; set; }            // отчество
        

        [Display(Name = "Ссылка на фото-аватар")]
        public string? Image_link { get; set; }


        [Required(ErrorMessage = "Укажите телефон")]
        [Display(Name = "Телефон")]
        [MaxLength(11)]
        [MinLength(11)]
        
        public string? PhoneNumber { get; set; }


        [Required(ErrorMessage = "Введите электронную почту")]
        [Display(Name = "Электронная почта")]
        [EmailAddress]
        public string? Email { get; set; }
        

        [Required(ErrorMessage = "Укажите город")]
        [Display(Name = "Город")]
        public string City { get; set; }


        [Required]
        [Display(Name = "Рейтинг")]
        public double Rating { get; set; }


        [Required]
        public int Count_Rating { get; set; }

        [Required(ErrorMessage = "Расскажите о себе всем")]
        [Display(Name = "Информация о пользователе")]
        public string? Information { get; set; }


        [Display(Name = "ИНН")]
        [MaxLength(10)]
        [MinLength(10)]
        public int? INN { get; set; }                    // Для ЮрЛиц


        [Display(Name = "Юридический адрес")]
        public string? Address { get; set; }             // Для ЮрЛиц


        //[Required]                                      // at least 1
        [Display(Name = "Тэги")]
        public int TagId { get; set; }
        [ForeignKey("TagId")]
        public Tag? Tag { get; set; }


        [PasswordPropertyText]
        [Required(ErrorMessage = "Придумайте пароль")]
        [Display(Name = "Пароль")]
        public string Password { get; set; }


        [Required]
        [Display(Name = "Дата регистрации")]
        public DateOnly Registration_Date { get; set; }

    }
}
