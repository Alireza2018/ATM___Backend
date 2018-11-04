using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AtmMachine.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GiftCardDetails",
                columns: table => new
                {
                    GiftCardId = table.Column<Guid>(nullable: false),
                    CardNumber = table.Column<string>(nullable: true),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiftCardDetails", x => x.GiftCardId);
                });

            migrationBuilder.CreateTable(
                name: "ProfileDetails",
                columns: table => new
                {
                    ProfileId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileDetails", x => x.ProfileId);
                });

            migrationBuilder.CreateTable(
                name: "UserDetails",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    ProfileId = table.Column<Guid>(nullable: false),
                    PinCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetails", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "GiftCardDetails",
                columns: new[] { "GiftCardId", "Amount", "CardNumber" },
                values: new object[,]
                {
                    { new Guid("e652001d-8d64-4118-ac58-62b90a93c4da"), 50, "6104337968574416" },
                    { new Guid("52ca9ed2-a192-4d5f-bebf-4b9d5c879436"), 150, "6104337968575519" },
                    { new Guid("ca13a3d2-4fd9-4d8a-8789-6ef8c9f8bfb4"), 250, "6104337968576728" },
                    { new Guid("fc64e1f4-65b7-448a-a280-ea09f2a6693f"), 500, "6104570268579001" }
                });

            migrationBuilder.InsertData(
                table: "ProfileDetails",
                columns: new[] { "ProfileId", "Address", "Name", "PhoneNumber" },
                values: new object[] { new Guid("fa86431a-4029-4942-afab-daf566d2818e"), "Olav M.Troviks Vei 48, H0108", "Alireza Shoaei", "48686475" });

            migrationBuilder.InsertData(
                table: "UserDetails",
                columns: new[] { "UserId", "PinCode", "ProfileId" },
                values: new object[] { new Guid("cfc64e1f-65b7-448a-a280-ea09f2a6693f"), 4060, new Guid("fa86431a-4029-4942-afab-daf566d2818e") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GiftCardDetails");

            migrationBuilder.DropTable(
                name: "ProfileDetails");

            migrationBuilder.DropTable(
                name: "UserDetails");
        }
    }
}
