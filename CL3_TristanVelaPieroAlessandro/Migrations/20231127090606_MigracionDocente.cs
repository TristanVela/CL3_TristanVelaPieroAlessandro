using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CL3_TristanVelaPieroAlessandro.Migrations
{
    public partial class MigracionDocente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Docente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(nullable: true),
                    Apellidos = table.Column<string>(nullable: true),
                    DNI = table.Column<int>(nullable: false),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    GradoAcademico = table.Column<string>(nullable: true),
                    CentroEstudios = table.Column<string>(nullable: true),
                    AñosExperiencia = table.Column<int>(nullable: false),
                    AñosDocencia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docente", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Docente");
        }
    }
}
