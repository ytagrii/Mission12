using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission12.Migrations
{
    public partial class oneday : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 1,
                column: "TourSlot",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 2,
                column: "TourSlot",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 3,
                column: "TourSlot",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 4,
                column: "TourSlot",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 5,
                column: "TourSlot",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 6,
                column: "TourSlot",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 7,
                column: "TourSlot",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 8,
                column: "TourSlot",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 9,
                column: "TourSlot",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 10,
                column: "TourSlot",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 11,
                column: "TourSlot",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 12,
                column: "TourSlot",
                value: 11);

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Date", "SignupId", "TourSlot" },
                values: new object[] { 13, new DateTime(2022, 3, 23, 20, 0, 0, 0, DateTimeKind.Unspecified), null, 12 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 13);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 1,
                column: "TourSlot",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 2,
                column: "TourSlot",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 3,
                column: "TourSlot",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 4,
                column: "TourSlot",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 5,
                column: "TourSlot",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 6,
                column: "TourSlot",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 7,
                column: "TourSlot",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 8,
                column: "TourSlot",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 9,
                column: "TourSlot",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 10,
                column: "TourSlot",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 11,
                column: "TourSlot",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "BookingId",
                keyValue: 12,
                column: "TourSlot",
                value: 12);
        }
    }
}
