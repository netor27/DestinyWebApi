using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Destiny.Data.Migrations
{
    public partial class AddingManyToManyRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Perks_Weapons_WeaponId",
                table: "Perks");

            migrationBuilder.DropIndex(
                name: "IX_Perks_WeaponId",
                table: "Perks");

            migrationBuilder.DropColumn(
                name: "WeaponId",
                table: "Perks");

            migrationBuilder.CreateTable(
                name: "WeaponPerk",
                columns: table => new
                {
                    WeaponId = table.Column<int>(nullable: false),
                    PerkId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponPerk", x => new { x.WeaponId, x.PerkId });
                    table.ForeignKey(
                        name: "FK_WeaponPerk_Perks_PerkId",
                        column: x => x.PerkId,
                        principalTable: "Perks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeaponPerk_Weapons_WeaponId",
                        column: x => x.WeaponId,
                        principalTable: "Weapons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WeaponPerk_PerkId",
                table: "WeaponPerk",
                column: "PerkId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeaponPerk");

            migrationBuilder.AddColumn<int>(
                name: "WeaponId",
                table: "Perks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Perks_WeaponId",
                table: "Perks",
                column: "WeaponId");

            migrationBuilder.AddForeignKey(
                name: "FK_Perks_Weapons_WeaponId",
                table: "Perks",
                column: "WeaponId",
                principalTable: "Weapons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
