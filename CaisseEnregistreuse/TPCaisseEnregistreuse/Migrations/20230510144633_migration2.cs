using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TPCaisseEnregistreuse.Migrations
{
    /// <inheritdoc />
    public partial class migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: "https://m.media-amazon.com/images/I/41gXsVV+2aL._AC_SY355_.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: null);
        }
    }
}
