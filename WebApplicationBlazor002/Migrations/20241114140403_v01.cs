using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationBlazor002.Migrations
{
    /// <inheritdoc />
    public partial class v01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Proveedor",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RUC = table.Column<string>(type: "TEXT", nullable: false),
                    RazonSocial = table.Column<string>(type: "TEXT", nullable: false),
                    Direccion = table.Column<string>(type: "TEXT", nullable: false),
                    Telefono = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedor", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Amount = table.Column<double>(type: "REAL", nullable: false),
                    MinStock = table.Column<double>(type: "REAL", nullable: false),
                    MaxStock = table.Column<double>(type: "REAL", nullable: true),
                    ProveedorCodigo = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Productos_Proveedor_ProveedorCodigo",
                        column: x => x.ProveedorCodigo,
                        principalTable: "Proveedor",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Productos_ProveedorCodigo",
                table: "Productos",
                column: "ProveedorCodigo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Proveedor");
        }
    }
}
