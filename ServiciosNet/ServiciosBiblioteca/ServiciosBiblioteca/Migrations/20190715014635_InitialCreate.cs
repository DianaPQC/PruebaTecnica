using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiciosBiblioteca.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblAutor",
                columns: table => new
                {
                    idAutor = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombres = table.Column<string>(maxLength: 150, nullable: false),
                    apellidos = table.Column<string>(maxLength: 150, nullable: false),
                    fechaNacimiento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblAutor", x => x.idAutor);
                });

            migrationBuilder.CreateTable(
                name: "tblCategoria",
                columns: table => new
                {
                    idCategoria = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(maxLength: 150, nullable: false),
                    descripcion = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCategoria", x => x.idCategoria);
                });

            migrationBuilder.CreateTable(
                name: "tblLibro",
                columns: table => new
                {
                    idLibro = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(maxLength: 250, nullable: false),
                    isbn = table.Column<int>(nullable: false),
                    idAutor = table.Column<int>(nullable: false),
                    idCategoria = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblLibro", x => x.idLibro);
                    table.ForeignKey(
                        name: "FK_tblLibro_tblAutor_idAutor",
                        column: x => x.idAutor,
                        principalTable: "tblAutor",
                        principalColumn: "idAutor",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblLibro_tblCategoria_idCategoria",
                        column: x => x.idCategoria,
                        principalTable: "tblCategoria",
                        principalColumn: "idCategoria",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblLibro_idAutor",
                table: "tblLibro",
                column: "idAutor");

            migrationBuilder.CreateIndex(
                name: "IX_tblLibro_idCategoria",
                table: "tblLibro",
                column: "idCategoria");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblLibro");

            migrationBuilder.DropTable(
                name: "tblAutor");

            migrationBuilder.DropTable(
                name: "tblCategoria");
        }
    }
}
