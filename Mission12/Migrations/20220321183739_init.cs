using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission12.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Signups",
                columns: table => new
                {
                    SignupId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupName = table.Column<string>(nullable: false),
                    Size = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Signups", x => x.SignupId);
                });

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
                    table.ForeignKey(
                        name: "FK_Appointments_Signups_SignupId",
                        column: x => x.SignupId,
                        principalTable: "Signups",
                        principalColumn: "SignupId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_SignupId",
                table: "Appointments",
                column: "SignupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Signups");
        }
    }
}
