using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MakeEvent.Migrations
{
    /// <inheritdoc />
    public partial class addDataToUsersAndEvents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "events",
                columns: new[] { "Id", "Date", "Description", "Dop_Information", "Location", "Max_Ghost", "Name", "Status", "TagId", "Time", "UserId" },
                values: new object[] { 1, new DateOnly(2023, 12, 31), "Отмечаем Новый год вместе!!!", null, "Район Самарово", 5, "Новый Год", "Совершено", 1, new TimeOnly(23, 59, 0), 1 });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Address", "City", "Count_Rating", "Email", "First_Name", "INN", "Image_link", "Information", "Last_Name", "Middle_Name", "NickName", "Password", "PhoneNumber", "Rating", "Registration_Date", "RoleId", "TagId", "UserTypeId" },
                values: new object[,]
                {
                    { 2, null, "Омск", 4, "umom322@mail.ru", "Умом", null, "", "Я - умом и это круто!", "Умомов", "Умомович", "Umom", "Password", "89527181234", 9.4199999999999999, new DateOnly(2023, 5, 6), 2, 1, 1 },
                    { 3, null, "Ульяновск", 14, "noobas2007@mail.ru", "Нубас", null, "", "Я - noobas и я горжусь этим!", "Черняков", "Нубасович", "Noobas", "Password", "89501234567", 8.0, new DateOnly(2024, 1, 2), 2, 2, 2 },
                    { 4, null, "Ханты-Мансийск", 100, "SonyaTheBestCat@mail.ru", "Соня", null, "", "Всем привет! Меня зовут Соня и я самая умная и красивая, в общем лучшая кошка в мире!", "Репина", "Мариновна", "Sonya", "Password", "89574238933", 10.0, new DateOnly(2024, 1, 2), 2, 3, 2 },
                    { 5, null, "Владивосток", 3, "jendosVladivostok@mail.ru", "Евгений", null, "", "Я красава", "Иванов", "Александрович", "Margosha", "Password", "89527382977", 8.4800000000000004, new DateOnly(2023, 7, 22), 2, 4, 2 }
                });

            migrationBuilder.InsertData(
                table: "events",
                columns: new[] { "Id", "Date", "Description", "Dop_Information", "Location", "Max_Ghost", "Name", "Status", "TagId", "Time", "UserId" },
                values: new object[,]
                {
                    { 2, new DateOnly(2024, 1, 8), "Пьем пиво и готовимся к рабочей неделе", null, "Район ОМК", 7, "Пить пиво", "Запланировано", 1, new TimeOnly(13, 0, 0), 3 },
                    { 3, new DateOnly(2024, 1, 15), "Поход в спортзал, чтобы стать гигачадами!!!", null, "Район Учхоз", 3, "Тренировка в тренажерном зале", "Запланировано", 2, new TimeOnly(15, 0, 0), 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "events",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "events",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "events",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
