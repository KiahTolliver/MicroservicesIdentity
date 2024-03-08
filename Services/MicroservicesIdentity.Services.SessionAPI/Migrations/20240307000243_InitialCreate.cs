using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MicroservicesIdentity.Services.SessionAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Abstract = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpeakerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "Abstract", "Date", "Location", "Name", "SpeakerName", "StartTime" },
                values: new object[,]
                {
                    { 1, "This talk is about X", new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Local), "Test Room 1", "The Best Talk Ever", "Jane Doe", new DateTime(2024, 3, 6, 16, 2, 42, 819, DateTimeKind.Local).AddTicks(4040) },
                    { 2, "This talk is about Y", new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Local), "Test Room 2", "The Second Best Talk Ever", "Jane Doe", new DateTime(2024, 3, 6, 16, 2, 42, 819, DateTimeKind.Local).AddTicks(4080) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sessions");
        }
    }
}
