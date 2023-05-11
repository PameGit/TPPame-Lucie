using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TPCaisseEnregistreuse.Migrations
{
    /// <inheritdoc />
    public partial class AjoutImageURL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageURL",
                value: "https://www.valrhona-ensemble.fr/media/catalog/product/cache/b0b97e8afa64efe2e2cbbf9acc352179/t/a/tablette-ivoire-framboise_1_.jpg");

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageURL",
                value: "https://image.darty.com/darty?type=image&source=/market/2020/10/02/15687657_1507_1.jpg&width=267&height=400&quality=90&effects=Pad(CC,FFFFFF)");

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageURL",
                value: "https://dyson-h.assetsadobe2.com/is/image/content/dam/dyson/images/products/primary/419649-01.png?$responsive$&cropPathE=mobile&fit=stretch,1&wid=440");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "Produits",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageURL",
                value: null);
        }
    }
}
