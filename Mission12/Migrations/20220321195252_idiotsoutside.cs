using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission12.Migrations
{
    public partial class idiotsoutside : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Date", "SignupId", "TourSlot" },
                values: new object[] { 7, new DateTime(2022, 3, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), null, 7 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Date", "SignupId", "TourSlot" },
                values: new object[] { 8, new DateTime(2022, 3, 23, 15, 0, 0, 0, DateTimeKind.Unspecified), null, 8 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Date", "SignupId", "TourSlot" },
                values: new object[] { 9, new DateTime(2022, 3, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), null, 9 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Date", "SignupId", "TourSlot" },
                values: new object[] { 10, new DateTime(2022, 3, 23, 17, 0, 0, 0, DateTimeKind.Unspecified), null, 10 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Date", "SignupId", "TourSlot" },
                values: new object[] { 11, new DateTime(2022, 3, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), null, 11 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Date", "SignupId", "TourSlot" },
                values: new object[] { 12, new DateTime(2022, 3, 23, 19, 0, 0, 0, DateTimeKind.Unspecified), null, 12 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 12);
        }
    }
}
