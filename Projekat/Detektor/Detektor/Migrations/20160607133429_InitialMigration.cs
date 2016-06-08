using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using Detektor.Models;
using Microsoft.Data.Entity;

namespace DetektorMigrations
{
    public partial class InitialMigration : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "DetektorLazi",
                columns: table => new
                {
                    id = table.Column(type: "INTEGER", nullable: false),
                    // .Annotation("Sqlite:Autoincrement", true)
                    ispitivac=table.Column(type:"TEXT", nullable:false),
                   sifra=table.Column(type:"TEXT", nullable:false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetektorLazi", x => x.id);
                });
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("DetektorLazi");
        }
    }
  
}

