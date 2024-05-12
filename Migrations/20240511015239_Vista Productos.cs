using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProtoDEV___Proyecto_Programacion.Migrations
{
    /// <inheritdoc />
    public partial class VistaProductos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Categoria",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    especificaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fabricante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    precioVenta = table.Column<double>(type: "float", nullable: false),
                    precio = table.Column<double>(type: "float", nullable: false),
                    precio50 = table.Column<double>(type: "float", nullable: false),
                    precio100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);
        }
    }
}
