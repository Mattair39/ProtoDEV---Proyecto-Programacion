using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProtoDEV___Proyecto_Programacion.Migrations
{
    /// <inheritdoc />
    public partial class ProyectoProgramacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SKU",
                table: "Producto",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SKU",
                table: "Producto");
        }
    }
}
