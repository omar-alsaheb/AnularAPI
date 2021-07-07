using Microsoft.EntityFrameworkCore.Migrations;

namespace AngularAPI.Migrations
{
    public partial class seed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Dsecription", "Name", "PictureUrl", "Price", "ProductBrandId", "ProductCategoryId", "SKU" },
                values: new object[] { 19, "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.", "Omar", "images/products/boot-ang1.png", 180m, 1, 3, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);
        }
    }
}
