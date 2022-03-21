using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission12.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    BookingId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(nullable: false),
                    TourSlot = table.Column<int>(nullable: false),
                    Booked = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.BookingId);
                });

            migrationBuilder.CreateTable(
                name: "Signups",
                columns: table => new
                {
                    SignupId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupName = table.Column<string>(nullable: false),
                    Size = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    AppointmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Signups", x => x.SignupId);
                    table.ForeignKey(
                        name: "FK_Signups_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "BookingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Booked", "Date", "TourSlot" },
                values: new object[] { 1, false, new DateTime(2022, 3, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Booked", "Date", "TourSlot" },
                values: new object[] { 2, false, new DateTime(2022, 3, 23, 9, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Booked", "Date", "TourSlot" },
                values: new object[] { 3, false, new DateTime(2022, 3, 23, 10, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Booked", "Date", "TourSlot" },
                values: new object[] { 4, false, new DateTime(2022, 3, 23, 11, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Booked", "Date", "TourSlot" },
                values: new object[] { 5, false, new DateTime(2022, 3, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Booked", "Date", "TourSlot" },
                values: new object[] { 6, false, new DateTime(2022, 3, 23, 13, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Booked", "Date", "TourSlot" },
                values: new object[] { 7, false, new DateTime(2022, 3, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Booked", "Date", "TourSlot" },
                values: new object[] { 8, false, new DateTime(2022, 3, 23, 15, 0, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Booked", "Date", "TourSlot" },
                values: new object[] { 9, false, new DateTime(2022, 3, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Booked", "Date", "TourSlot" },
                values: new object[] { 10, false, new DateTime(2022, 3, 23, 17, 0, 0, 0, DateTimeKind.Unspecified), 9 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Booked", "Date", "TourSlot" },
                values: new object[] { 11, false, new DateTime(2022, 3, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), 10 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Booked", "Date", "TourSlot" },
                values: new object[] { 12, false, new DateTime(2022, 3, 23, 19, 0, 0, 0, DateTimeKind.Unspecified), 11 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Booked", "Date", "TourSlot" },
                values: new object[] { 13, false, new DateTime(2022, 3, 23, 20, 0, 0, 0, DateTimeKind.Unspecified), 12 });

            migrationBuilder.CreateIndex(
                name: "IX_Signups_AppointmentId",
                table: "Signups",
                column: "AppointmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Signups");

            migrationBuilder.DropTable(
                name: "Appointments");
        }
    }
}
