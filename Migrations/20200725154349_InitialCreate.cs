﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodTruckRodeo.API.Migrations
{
  public partial class InitialCreate : Migration
  {// what will happen when migration is applied
    protected override void Up(MigrationBuilder migrationBuilder)
    {

      migrationBuilder.CreateTable(
          name: "Values",
          columns: table => new
          {
            Id = table.Column<int>(nullable: false)
                  .Annotation("Sqlite:Autoincrement", true),
            Name = table.Column<string>(nullable: true)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_Values", x => x.Id);
          });
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropTable(
          name: "Values");
    }
  }
}
