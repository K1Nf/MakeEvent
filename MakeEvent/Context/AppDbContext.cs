using Microsoft.EntityFrameworkCore;
using MakeEvent.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MakeEvent.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Event> events { get; set; }
        public DbSet<Role> roles { get; set; }
        public DbSet<Tag> tags { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<UserType> userTypes { get; set; }
        public DbSet<Event_Ghost> ghosts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>().HasData(
            new Event{ 
                Id = 1,
                Name = "Новый Год",
                UserId = 1,
                Location = "Район Самарово",
                Date = new (2023,12,31),
                Time = new TimeOnly(23, 59),
                Max_Ghost = 5,
                TagId = 1,
                Status = "Совершено",
                Description = "Отмечаем Новый год вместе!!!"
            },
            new Event
            {
                Id = 2,
                Name = "Пить пиво",
                UserId = 3,
                Location = "Район ОМК",
                Date = new(2024, 01, 08),
                Time = new TimeOnly(13, 00),
                Max_Ghost = 7,
                TagId = 1,
                Status = "Запланировано",
                Description = "Пьем пиво и готовимся к рабочей неделе"
            },
            new Event
            {
                Id = 3,
                Name = "Тренировка в тренажерном зале",
                UserId = 2,
                Location = "Район Учхоз",
                Date = new(2024, 01, 15),
                Time = new TimeOnly(15, 00),
                Max_Ghost = 3,
                TagId = 2,
                Status = "Запланировано",
                Description = "Поход в спортзал, чтобы стать гигачадами!!!"
            },
            new Event
            {
                Id = 5,
                Name = "Катание на мотоиклах",
                UserId = 2,
                Location = "Вокруг города",
                Date = new(2024, 05, 23),
                Time = new TimeOnly(23, 00),
                Max_Ghost = 4,
                TagId = 6,
                Status = "Запланировано",
                Description = "Наматаем пару кругов вокруг города на мотиках!"
            });

            modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 2,
                UserTypeId = 1,
                TagId = 1,
                RoleId = 2,
                Registration_Date = new DateOnly(2023, 05, 06),
                Rating = 9.42,
                PhoneNumber = "89527181234",
                Password = "Password",
                NickName = "Umom",
                Middle_Name = "Умомович",
                Last_Name = "Умомов",
                First_Name = "Умом",
                Count_Rating = 4,
                City = "Омск",
                Email = "umom322@mail.ru",
                Information = "Я - умом и это круто!",
                Image_link = ""
            },
            new User
            {
                Id = 3,
                UserTypeId = 2,
                TagId = 2,
                RoleId = 2,
                Registration_Date = new DateOnly(2024, 01, 02),
                Rating = 8,
                PhoneNumber = "89501234567",
                Password = "Password",
                NickName = "Noobas",
                Middle_Name = "Нубасович",
                Last_Name = "Черняков",
                First_Name = "Нубас",
                Count_Rating = 14,
                City = "Ульяновск",
                Email = "noobas2007@mail.ru",
                Information = "Я - noobas и я горжусь этим!",
                Image_link = ""

            },
            new User
            {
                Id = 4,
                UserTypeId = 2,
                TagId = 3,
                RoleId = 2,
                Registration_Date = new DateOnly(2024, 01, 02),
                Rating = 10,
                PhoneNumber = "89574238933",
                Password = "Password",
                NickName = "Sonya",
                Middle_Name = "Мариновна",
                Last_Name = "Репина",
                First_Name = "Соня",
                Count_Rating = 100,
                City = "Ханты-Мансийск",
                Email = "SonyaTheBestCat@mail.ru",
                Information = "Всем привет! Меня зовут Соня и я самая умная и красивая, в общем лучшая кошка в мире!",
                Image_link = ""

            },
            new User
            {
                Id = 5,
                UserTypeId = 2,
                TagId = 4,
                RoleId = 2,
                Registration_Date = new DateOnly(2023, 07, 22),
                Rating = 8.48,
                PhoneNumber = "89527382977",
                Password = "Password",
                NickName = "Margosha",
                Middle_Name = "Александрович",
                Last_Name = "Иванов",
                First_Name = "Евгений",
                Count_Rating = 3,
                City = "Владивосток",
                Email = "jendosVladivostok@mail.ru",
                Information = "Я красава",
                Image_link = ""

            });
        }
    }
}
