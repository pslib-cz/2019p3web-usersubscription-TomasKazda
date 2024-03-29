﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace UserSubscription.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    CountryCode = table.Column<string>(nullable: false),
                    Agreed = table.Column<bool>(nullable: false),
                    Confirmed = table.Column<bool>(nullable: false),
                    ConfirmationCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "Agreed", "ConfirmationCode", "Confirmed", "CountryCode", "Email", "FirstName", "Gender", "LastName" },
                values: new object[] { 1, true, "FGC12556", true, "CZ", "john@doe.com", "John", 0, "Doe" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subscriptions");
        }
    }
}
