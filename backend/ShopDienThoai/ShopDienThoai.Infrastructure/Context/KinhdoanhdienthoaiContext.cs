using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShopDienThoai.Domain.Entities;

namespace ShopDienThoai.Infrastructure.Context;

public partial class KinhdoanhdienthoaiContext : IdentityDbContext<ApplicationUser>
{
    public KinhdoanhdienthoaiContext()
    {
    }

    public KinhdoanhdienthoaiContext(DbContextOptions<KinhdoanhdienthoaiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Avartarkhachhang> Avartarkhachhangs { get; set; }

    public virtual DbSet<Binhluan> Binhluans { get; set; }

    public virtual DbSet<Chitiethoadon> Chitiethoadons { get; set; }

    public virtual DbSet<Chucvunhanvien> Chucvunhanviens { get; set; }

    public virtual DbSet<Hoadon> Hoadons { get; set; }

    public virtual DbSet<Imagenhanvien> Imagenhanviens { get; set; }

    public virtual DbSet<Imagesanpham> Imagesanphams { get; set; }

    public virtual DbSet<Khachhang> Khachhangs { get; set; }

    public virtual DbSet<Loaisanpham> Loaisanphams { get; set; }

    public virtual DbSet<Nhanvien> Nhanviens { get; set; }

    public virtual DbSet<Phuongthucthanhtoan> Phuongthucthanhtoans { get; set; }

    public virtual DbSet<Sanpham> Sanphams { get; set; }

    public virtual DbSet<Tinhtrang> Tinhtrangs { get; set; }

    //System
/*    public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }

    public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }

    public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }

    public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }

    public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }

    public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }*/
    //----------------------
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=localhost;Database=KINHDOANHDIENTHOAI;UID=sa;PWD=ducchinh;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Avartarkhachhang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AVARTARK__3214EC27B25BA327");

            entity.ToTable("AVARTARKHACHHANG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Avartarkhachhang1)
                .HasColumnType("image")
                .HasColumnName("AVARTARKHACHHANG");
            entity.Property(e => e.Idkhachhang).HasColumnName("IDKHACHHANG");

            entity.HasOne(d => d.IdkhachhangNavigation).WithMany(p => p.Avartarkhachhangs)
                .HasForeignKey(d => d.Idkhachhang)
                .HasConstraintName("FK__AVARTARKH__IDKHA__7A672E12");
        });

        modelBuilder.Entity<Binhluan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__BINHLUAN__3214EC271A4E82D3");

            entity.ToTable("BINHLUAN");

            entity.HasIndex(e => e.Idkhachhang, "IX_BINHLUAN_IDKHACHHANG");

            entity.HasIndex(e => e.Idsanpham, "IX_BINHLUAN_IDSANPHAM");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idkhachhang).HasColumnName("IDKHACHHANG");
            entity.Property(e => e.Idsanpham).HasColumnName("IDSANPHAM");
            entity.Property(e => e.Noidungbinhluan).HasColumnName("NOIDUNGBINHLUAN");
            entity.Property(e => e.Thoigianbinhluan)
                .HasColumnType("datetime")
                .HasColumnName("THOIGIANBINHLUAN");

            entity.HasOne(d => d.IdkhachhangNavigation).WithMany(p => p.Binhluans)
                .HasForeignKey(d => d.Idkhachhang)
                .HasConstraintName("FK__BINHLUAN__IDKHAC__5070F446");

            entity.HasOne(d => d.IdsanphamNavigation).WithMany(p => p.Binhluans)
                .HasForeignKey(d => d.Idsanpham)
                .HasConstraintName("FK__BINHLUAN__IDSANP__5165187F");
        });

        modelBuilder.Entity<Chitiethoadon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CHITIETH__3214EC27200E78CA");

            entity.ToTable("CHITIETHOADON");

            entity.HasIndex(e => e.Idhoadon, "IX_CHITIETHOADON_IDHOADON");

            entity.HasIndex(e => e.Idsanpham, "IX_CHITIETHOADON_IDSANPHAM");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Dongia).HasColumnName("DONGIA");
            entity.Property(e => e.Idhoadon).HasColumnName("IDHOADON");
            entity.Property(e => e.Idsanpham).HasColumnName("IDSANPHAM");
            entity.Property(e => e.Soluong).HasColumnName("SOLUONG");
            entity.Property(e => e.Thanhtien).HasColumnName("THANHTIEN");

            entity.HasOne(d => d.IdhoadonNavigation).WithMany(p => p.Chitiethoadons)
                .HasForeignKey(d => d.Idhoadon)
                .HasConstraintName("FK__CHITIETHO__IDHOA__4CA06362");

            entity.HasOne(d => d.IdsanphamNavigation).WithMany(p => p.Chitiethoadons)
                .HasForeignKey(d => d.Idsanpham)
                .HasConstraintName("FK__CHITIETHO__IDSAN__4D94879B");
        });

        modelBuilder.Entity<Chucvunhanvien>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CHUCVUNH__3214EC27466B620A");

            entity.ToTable("CHUCVUNHANVIEN");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Tenchucvu)
                .HasMaxLength(50)
                .HasColumnName("TENCHUCVU");
        });

        modelBuilder.Entity<Hoadon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HOADON__3214EC27266796F4");

            entity.ToTable("HOADON");

            entity.HasIndex(e => e.Idkhachhang, "IX_HOADON_IDKHACHHANG");

            entity.HasIndex(e => e.Idnhanvien, "IX_HOADON_IDNHANVIEN");

            entity.HasIndex(e => e.Idphuongthuc, "IX_HOADON_IDPHUONGTHUC");

            entity.HasIndex(e => e.Idtinhtrang, "IX_HOADON_IDTINHTRANG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Diachigiaohang)
                .HasMaxLength(50)
                .HasColumnName("DIACHIGIAOHANG");
            entity.Property(e => e.Idkhachhang).HasColumnName("IDKHACHHANG");
            entity.Property(e => e.Idnhanvien).HasColumnName("IDNHANVIEN");
            entity.Property(e => e.Idphuongthuc).HasColumnName("IDPHUONGTHUC");
            entity.Property(e => e.Idtinhtrang).HasColumnName("IDTINHTRANG");
            entity.Property(e => e.Ngaydathang)
                .HasColumnType("datetime")
                .HasColumnName("NGAYDATHANG");
            entity.Property(e => e.Ngaygiaohang)
                .HasColumnType("datetime")
                .HasColumnName("NGAYGIAOHANG");

            entity.HasOne(d => d.IdkhachhangNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.Idkhachhang)
                .HasConstraintName("FK__HOADON__IDKHACHH__46E78A0C");

            entity.HasOne(d => d.IdnhanvienNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.Idnhanvien)
                .HasConstraintName("FK__HOADON__IDNHANVI__47DBAE45");

            entity.HasOne(d => d.IdphuongthucNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.Idphuongthuc)
                .HasConstraintName("FK__HOADON__IDPHUONG__48CFD27E");

            entity.HasOne(d => d.IdtinhtrangNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.Idtinhtrang)
                .HasConstraintName("FK__HOADON__IDTINHTR__49C3F6B7");
        });

        modelBuilder.Entity<Imagenhanvien>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__IMAGENHA");

            entity.ToTable("IMAGENHANVIEN");

            entity.HasIndex(e => e.Idnhanvien, "IX_IMAGENHANVIEN_IDNHANVIEN");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idnhanvien).HasColumnName("IDNHANVIEN");
            entity.Property(e => e.Imagestaff)
                .HasColumnType("image")
                .HasColumnName("IMAGESTAFF");

            entity.HasOne(d => d.IdnhanvienNavigation).WithMany(p => p.Imagenhanviens)
                .HasForeignKey(d => d.Idnhanvien)
                .HasConstraintName("FK__IMAGENHAN__IDNHA");
        });

        modelBuilder.Entity<Imagesanpham>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__IMAGESAN__3214EC27A7A453DC");

            entity.ToTable("IMAGESANPHAM");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idsanpham).HasColumnName("IDSANPHAM");
            entity.Property(e => e.Imagesanpham1)
                .HasColumnType("image")
                .HasColumnName("IMAGESANPHAM");

            entity.HasOne(d => d.IdsanphamNavigation).WithMany(p => p.Imagesanphams)
                .HasForeignKey(d => d.Idsanpham)
                .HasConstraintName("FK__IMAGESANP__IDSAN__778AC167")
                ;
        });

        modelBuilder.Entity<Khachhang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__KHACHHAN__3214EC27E16D1A0B");

            entity.ToTable("KHACHHANG");

            entity.Property(e => e.Id).HasColumnName("ID");
            /*entity.Property(e => e.Avartar)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AVARTAR");*/
            entity.Property(e => e.Diachi)
                .HasMaxLength(50)
                .HasColumnName("DIACHI");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Makhachhang)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAKHACHHANG");
            entity.Property(e => e.Sdt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SDT");
            entity.Property(e => e.Tenkhachhang)
                .HasMaxLength(50)
                .HasColumnName("TENKHACHHANG");
        });

        modelBuilder.Entity<Loaisanpham>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LOAISANP__3214EC273E162916");

            entity.ToTable("LOAISANPHAM");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Tenloaisanpham)
                .HasMaxLength(50)
                .HasColumnName("TENLOAISANPHAM");
        });

        modelBuilder.Entity<Nhanvien>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NHANVIEN__3214EC27E2664FA2");

            entity.ToTable("NHANVIEN");

            entity.HasIndex(e => e.Chucvuid, "IX_NHANVIEN_CHUCVUID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Chucvuid).HasColumnName("CHUCVUID");
            entity.Property(e => e.Diachi)
                .HasMaxLength(50)
                .HasColumnName("DIACHI");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Gioitinh).HasColumnName("GIOITINH");
            entity.Property(e => e.Hoten)
                .HasMaxLength(50)
                .HasColumnName("HOTEN");
            entity.Property(e => e.Manhanvien)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MANHANVIEN");
            entity.Property(e => e.Ngaysinh)
                .HasColumnType("datetime")
                .HasColumnName("NGAYSINH");
            entity.Property(e => e.Sdt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SDT");

            entity.HasOne(d => d.Chucvu).WithMany(p => p.Nhanviens)
                .HasForeignKey(d => d.Chucvuid)
                .HasConstraintName("FK__NHANVIEN__CHUCVU__3E52440B");
        });

        modelBuilder.Entity<Phuongthucthanhtoan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PHUONGTH__3214EC27BC1E2B2C");

            entity.ToTable("PHUONGTHUCTHANHTOAN");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Tenphuongthuc)
                .HasMaxLength(50)
                .HasColumnName("TENPHUONGTHUC");
        });

        modelBuilder.Entity<Sanpham>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SANPHAM__3214EC27B7205ED5");

            entity.ToTable("SANPHAM");

            entity.HasIndex(e => e.Loaisanphamid, "IX_SANPHAM_LOAISANPHAMID");

            entity.Property(e => e.Id).HasColumnName("ID");
            /*entity.Property(e => e.Anhsanpham)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ANHSANPHAM");*/
            entity.Property(e => e.Baohanh)
                .HasMaxLength(50)
                .HasColumnName("BAOHANH");
            entity.Property(e => e.Bonhoram)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BONHORAM");
            entity.Property(e => e.Bonhotrong)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BONHOTRONG");
            entity.Property(e => e.Dungluongpin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DUNGLUONGPIN");
            entity.Property(e => e.Giaban).HasColumnName("GIABAN");
            entity.Property(e => e.Hedieuhanh)
                .HasMaxLength(50)
                .HasColumnName("HEDIEUHANH");
            entity.Property(e => e.Kichthuocmanhinh)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KICHTHUOCMANHINH");
            entity.Property(e => e.Loaisanphamid).HasColumnName("LOAISANPHAMID");
            entity.Property(e => e.Masanpham)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MASANPHAM");
            entity.Property(e => e.Mausac)
                .HasMaxLength(50)
                .HasColumnName("MAUSAC");
            entity.Property(e => e.Mota).HasColumnName("MOTA");
            entity.Property(e => e.Soluongton).HasColumnName("SOLUONGTON");
            entity.Property(e => e.Tensanpham)
                .HasMaxLength(50)
                .HasColumnName("TENSANPHAM");
            entity.Property(e => e.Trongluong)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TRONGLUONG");

            entity.HasOne(d => d.Loaisanpham).WithMany(p => p.Sanphams)
                .HasForeignKey(d => d.Loaisanphamid)
                .HasConstraintName("FK__SANPHAM__LOAISAN__398D8EEE")
                .OnDelete(DeleteBehavior.Cascade);

        });

        modelBuilder.Entity<Tinhtrang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TINHTRAN__3214EC27DB0DC927");

            entity.ToTable("TINHTRANG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Tentinhtrang)
                .HasMaxLength(50)
                .HasColumnName("TENTINHTRANG");
        });

        OnModelCreatingPartial(modelBuilder);
    }

/*    protected void MappingModelIdentity(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AspNetRoleClaims>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("AspNer")
        });
    }*/


    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
