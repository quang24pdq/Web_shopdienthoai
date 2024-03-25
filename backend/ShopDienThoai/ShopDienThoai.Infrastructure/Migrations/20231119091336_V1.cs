using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopDienThoai.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class V1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CHUCVUNHANVIEN",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENCHUCVU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHUCVUNH__3214EC27466B620A", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KHACHHANG",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MAKHACHHANG = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    TENKHACHHANG = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DIACHI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SDT = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EMAIL = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__KHACHHAN__3214EC27E16D1A0B", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LOAISANPHAM",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENLOAISANPHAM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LOAISANP__3214EC273E162916", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PHUONGTHUCTHANHTOAN",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENPHUONGTHUC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PHUONGTH__3214EC27BC1E2B2C", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TINHTRANG",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TENTINHTRANG = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TINHTRAN__3214EC27DB0DC927", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NHANVIEN",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MANHANVIEN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    HOTEN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NGAYSINH = table.Column<DateTime>(type: "datetime", nullable: true),
                    DIACHI = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SDT = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    EMAIL = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CHUCVUID = table.Column<int>(type: "int", nullable: true),
                    GIOITINH = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__NHANVIEN__3214EC27E2664FA2", x => x.ID);
                    table.ForeignKey(
                        name: "FK__NHANVIEN__CHUCVU__3E52440B",
                        column: x => x.CHUCVUID,
                        principalTable: "CHUCVUNHANVIEN",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "AVARTARKHACHHANG",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDKHACHHANG = table.Column<int>(type: "int", nullable: true),
                    AVARTARKHACHHANG = table.Column<byte[]>(type: "image", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AVARTARK__3214EC27B25BA327", x => x.ID);
                    table.ForeignKey(
                        name: "FK__AVARTARKH__IDKHA__7A672E12",
                        column: x => x.IDKHACHHANG,
                        principalTable: "KHACHHANG",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SANPHAM",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MASANPHAM = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    TENSANPHAM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    KICHTHUOCMANHINH = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    HEDIEUHANH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BONHOTRONG = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TRONGLUONG = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DUNGLUONGPIN = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SOLUONGTON = table.Column<int>(type: "int", nullable: true),
                    MOTA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GIABAN = table.Column<int>(type: "int", nullable: true),
                    MAUSAC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BAOHANH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LOAISANPHAMID = table.Column<int>(type: "int", nullable: true),
                    BONHORAM = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SANPHAM__3214EC27B7205ED5", x => x.ID);
                    table.ForeignKey(
                        name: "FK__SANPHAM__LOAISAN__398D8EEE",
                        column: x => x.LOAISANPHAMID,
                        principalTable: "LOAISANPHAM",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "HOADON",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NGAYDATHANG = table.Column<DateTime>(type: "datetime", nullable: true),
                    NGAYGIAOHANG = table.Column<DateTime>(type: "datetime", nullable: true),
                    DIACHIGIAOHANG = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IDKHACHHANG = table.Column<int>(type: "int", nullable: true),
                    IDNHANVIEN = table.Column<int>(type: "int", nullable: true),
                    IDPHUONGTHUC = table.Column<int>(type: "int", nullable: true),
                    IDTINHTRANG = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HOADON__3214EC27266796F4", x => x.ID);
                    table.ForeignKey(
                        name: "FK__HOADON__IDKHACHH__46E78A0C",
                        column: x => x.IDKHACHHANG,
                        principalTable: "KHACHHANG",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK__HOADON__IDNHANVI__47DBAE45",
                        column: x => x.IDNHANVIEN,
                        principalTable: "NHANVIEN",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK__HOADON__IDPHUONG__48CFD27E",
                        column: x => x.IDPHUONGTHUC,
                        principalTable: "PHUONGTHUCTHANHTOAN",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK__HOADON__IDTINHTR__49C3F6B7",
                        column: x => x.IDTINHTRANG,
                        principalTable: "TINHTRANG",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "IMAGENHANVIEN",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDNHANVIEN = table.Column<int>(type: "int", nullable: true),
                    IMAGESTAFF = table.Column<byte[]>(type: "image", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__IMAGENHA", x => x.ID);
                    table.ForeignKey(
                        name: "FK__IMAGENHAN__IDNHA",
                        column: x => x.IDNHANVIEN,
                        principalTable: "NHANVIEN",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "BINHLUAN",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDKHACHHANG = table.Column<int>(type: "int", nullable: true),
                    IDSANPHAM = table.Column<int>(type: "int", nullable: true),
                    NOIDUNGBINHLUAN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    THOIGIANBINHLUAN = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BINHLUAN__3214EC271A4E82D3", x => x.ID);
                    table.ForeignKey(
                        name: "FK__BINHLUAN__IDKHAC__5070F446",
                        column: x => x.IDKHACHHANG,
                        principalTable: "KHACHHANG",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK__BINHLUAN__IDSANP__5165187F",
                        column: x => x.IDSANPHAM,
                        principalTable: "SANPHAM",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "IMAGESANPHAM",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDSANPHAM = table.Column<int>(type: "int", nullable: true),
                    IMAGESANPHAM = table.Column<byte[]>(type: "image", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__IMAGESAN__3214EC27A7A453DC", x => x.ID);
                    table.ForeignKey(
                        name: "FK__IMAGESANP__IDSAN__778AC167",
                        column: x => x.IDSANPHAM,
                        principalTable: "SANPHAM",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CHITIETHOADON",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDHOADON = table.Column<int>(type: "int", nullable: true),
                    IDSANPHAM = table.Column<int>(type: "int", nullable: true),
                    SOLUONG = table.Column<int>(type: "int", nullable: true),
                    DONGIA = table.Column<int>(type: "int", nullable: true),
                    THANHTIEN = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CHITIETH__3214EC27200E78CA", x => x.ID);
                    table.ForeignKey(
                        name: "FK__CHITIETHO__IDHOA__4CA06362",
                        column: x => x.IDHOADON,
                        principalTable: "HOADON",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK__CHITIETHO__IDSAN__4D94879B",
                        column: x => x.IDSANPHAM,
                        principalTable: "SANPHAM",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AVARTARKHACHHANG_IDKHACHHANG",
                table: "AVARTARKHACHHANG",
                column: "IDKHACHHANG");

            migrationBuilder.CreateIndex(
                name: "IX_BINHLUAN_IDKHACHHANG",
                table: "BINHLUAN",
                column: "IDKHACHHANG");

            migrationBuilder.CreateIndex(
                name: "IX_BINHLUAN_IDSANPHAM",
                table: "BINHLUAN",
                column: "IDSANPHAM");

            migrationBuilder.CreateIndex(
                name: "IX_CHITIETHOADON_IDHOADON",
                table: "CHITIETHOADON",
                column: "IDHOADON");

            migrationBuilder.CreateIndex(
                name: "IX_CHITIETHOADON_IDSANPHAM",
                table: "CHITIETHOADON",
                column: "IDSANPHAM");

            migrationBuilder.CreateIndex(
                name: "IX_HOADON_IDKHACHHANG",
                table: "HOADON",
                column: "IDKHACHHANG");

            migrationBuilder.CreateIndex(
                name: "IX_HOADON_IDNHANVIEN",
                table: "HOADON",
                column: "IDNHANVIEN");

            migrationBuilder.CreateIndex(
                name: "IX_HOADON_IDPHUONGTHUC",
                table: "HOADON",
                column: "IDPHUONGTHUC");

            migrationBuilder.CreateIndex(
                name: "IX_HOADON_IDTINHTRANG",
                table: "HOADON",
                column: "IDTINHTRANG");

            migrationBuilder.CreateIndex(
                name: "IX_IMAGENHANVIEN_IDNHANVIEN",
                table: "IMAGENHANVIEN",
                column: "IDNHANVIEN");

            migrationBuilder.CreateIndex(
                name: "IX_IMAGESANPHAM_IDSANPHAM",
                table: "IMAGESANPHAM",
                column: "IDSANPHAM");

            migrationBuilder.CreateIndex(
                name: "IX_NHANVIEN_CHUCVUID",
                table: "NHANVIEN",
                column: "CHUCVUID");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAM_LOAISANPHAMID",
                table: "SANPHAM",
                column: "LOAISANPHAMID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AVARTARKHACHHANG");

            migrationBuilder.DropTable(
                name: "BINHLUAN");

            migrationBuilder.DropTable(
                name: "CHITIETHOADON");

            migrationBuilder.DropTable(
                name: "IMAGENHANVIEN");

            migrationBuilder.DropTable(
                name: "IMAGESANPHAM");

            migrationBuilder.DropTable(
                name: "HOADON");

            migrationBuilder.DropTable(
                name: "SANPHAM");

            migrationBuilder.DropTable(
                name: "KHACHHANG");

            migrationBuilder.DropTable(
                name: "NHANVIEN");

            migrationBuilder.DropTable(
                name: "PHUONGTHUCTHANHTOAN");

            migrationBuilder.DropTable(
                name: "TINHTRANG");

            migrationBuilder.DropTable(
                name: "LOAISANPHAM");

            migrationBuilder.DropTable(
                name: "CHUCVUNHANVIEN");
        }
    }
}
