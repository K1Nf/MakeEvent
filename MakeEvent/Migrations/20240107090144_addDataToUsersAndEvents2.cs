using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MakeEvent.Migrations
{
    /// <inheritdoc />
    public partial class addDataToUsersAndEvents2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "events",
                columns: new[] { "Id", "Date", "Description", "Dop_Information", "Location", "Max_Ghost", "Name", "Status", "TagId", "Time", "UserId" },
                values: new object[] { 5, new DateOnly(2024, 5, 23), "Наматаем пару кругов вокруг города на мотиках!", null, "Вокруг города", 4, "Катание на мотоиклах", "Запланировано", 6, new TimeOnly(23, 0, 0), 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "events",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
