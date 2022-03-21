using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission12.Migrations
{
    public partial class newer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Date", "SignupId", "TourSlot" },
                values: new object[] { 1, new DateTime(2022, 3, 21, 12, 43, 18, 930, DateTimeKind.Local).AddTicks(5795), null, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 1);
        }
    }
}
