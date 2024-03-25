using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopDienThoai.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class V2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__SANPHAM__LOAISAN__398D8EEE",
                table: "SANPHAM");

            migrationBuilder.AddForeignKey(
                name: "FK__SANPHAM__LOAISAN__398D8EEE",
                table: "SANPHAM",
                column: "LOAISANPHAMID",
                principalTable: "LOAISANPHAM",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__SANPHAM__LOAISAN__398D8EEE",
                table: "SANPHAM");

            migrationBuilder.AddForeignKey(
                name: "FK__SANPHAM__LOAISAN__398D8EEE",
                table: "SANPHAM",
                column: "LOAISANPHAMID",
                principalTable: "LOAISANPHAM",
                principalColumn: "ID");
        }
    }
}
