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
                    SignupId = table.Column<int>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    TourSlot = table.Column<int>(nullable: false)
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
                    BookingId = table.Column<int>(nullable: false),
                    GroupName = table.Column<string>(nullable: false),
                    Size = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Signups", x => x.SignupId);
                    table.ForeignKey(
                        name: "FK_Signups_Appointments_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Appointments",
                        principalColumn: "BookingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Date", "SignupId", "TourSlot" },
                values: new object[] { 1, new DateTime(2022, 3, 23, 8, 0, 0, 0, DateTimeKind.Unspecified), null, 0 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Date", "SignupId", "TourSlot" },
                values: new object[] { 2, new DateTime(2022, 3, 23, 9, 0, 0, 0, DateTimeKind.Unspecified), null, 1 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Date", "SignupId", "TourSlot" },
                values: new object[] { 3, new DateTime(2022, 3, 23, 10, 0, 0, 0, DateTimeKind.Unspecified), null, 2 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Date", "SignupId", "TourSlot" },
                values: new object[] { 4, new DateTime(2022, 3, 23, 11, 0, 0, 0, DateTimeKind.Unspecified), null, 3 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Date", "SignupId", "TourSlot" },
                values: new object[] { 5, new DateTime(2022, 3, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), null, 4 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Date", "SignupId", "TourSlot" },
                values: new object[] { 6, new DateTime(2022, 3, 23, 13, 0, 0, 0, DateTimeKind.Unspecified), null, 5 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Date", "SignupId", "TourSlot" },
                values: new object[] { 7, new DateTime(2022, 3, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), null, 6 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Date", "SignupId", "TourSlot" },
                values: new object[] { 8, new DateTime(2022, 3, 23, 15, 0, 0, 0, DateTimeKind.Unspecified), null, 7 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Date", "SignupId", "TourSlot" },
                values: new object[] { 9, new DateTime(2022, 3, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), null, 8 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Date", "SignupId", "TourSlot" },
                values: new object[] { 10, new DateTime(2022, 3, 23, 17, 0, 0, 0, DateTimeKind.Unspecified), null, 9 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Date", "SignupId", "TourSlot" },
                values: new object[] { 11, new DateTime(2022, 3, 23, 18, 0, 0, 0, DateTimeKind.Unspecified), null, 10 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Date", "SignupId", "TourSlot" },
                values: new object[] { 12, new DateTime(2022, 3, 23, 19, 0, 0, 0, DateTimeKind.Unspecified), null, 11 });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "BookingId", "Date", "SignupId", "TourSlot" },
                values: new object[] { 13, new DateTime(2022, 3, 23, 20, 0, 0, 0, DateTimeKind.Unspecified), null, 12 });

            migrationBuilder.CreateIndex(
                name: "IX_Signups_BookingId",
                table: "Signups",
                column: "BookingId");
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
