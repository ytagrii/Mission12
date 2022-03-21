using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission12.Migrations
{
    public partial class newerr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 3, 23, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Date", "SignupId", "TourSlot" },
                values: new object[] { 2, new DateTime(2022, 3, 23, 9, 0, 0, 0, DateTimeKind.Unspecified), null, 2 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Date", "SignupId", "TourSlot" },
                values: new object[] { 3, new DateTime(2022, 3, 23, 10, 0, 0, 0, DateTimeKind.Unspecified), null, 3 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Date", "SignupId", "TourSlot" },
                values: new object[] { 4, new DateTime(2022, 3, 23, 11, 0, 0, 0, DateTimeKind.Unspecified), null, 4 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Date", "SignupId", "TourSlot" },
                values: new object[] { 5, new DateTime(2022, 3, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), null, 5 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Date", "SignupId", "TourSlot" },
                values: new object[] { 6, new DateTime(2022, 3, 23, 13, 0, 0, 0, DateTimeKind.Unspecified), null, 6 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 3, 21, 12, 43, 18, 930, DateTimeKind.Local).AddTicks(5795));
        }
    }
}
