using System;
using System.Collections.Generic;
using DAL.DomainClass;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context;

public partial class MyContext : DbContext
{
    public MyContext()
    {
    }

    public MyContext(DbContextOptions<MyContext> options)
        : base(options)
    {
    }
    public virtual DbSet<CaLamViec> CaLamViecs { get; set; }

    public virtual DbSet<ChatLieu> ChatLieus { get; set; }

    public virtual DbSet<ChiTietSanPham> ChiTietSanPhams { get; set; }

    public virtual DbSet<ChucVu> ChucVus { get; set; }

    public virtual DbSet<Doi> Dois { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<MauSac> MauSacs { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<Rank> Ranks { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    public virtual DbSet<Size> Sizes { get; set; }

    public virtual DbSet<Thongke> Thongkes { get; set; }

    public virtual DbSet<ThuongHieu> ThuongHieus { get; set; }

    public virtual DbSet<Tra> Tras { get; set; }

    public virtual DbSet<Voucher> Vouchers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=VANNTRONGG\\SQLEXPRESS;Initial Catalog=QLBanGiayTheThao_DuAn1;Integrated Security=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CaLamViec>(entity =>
        {
            entity.HasKey(e => e.IdCaLamViec).HasName("PK__CaLamVie__A8F5E8B544031CB4");

            entity.Property(e => e.IdCaLamViec).ValueGeneratedNever();
        });

        modelBuilder.Entity<ChatLieu>(entity =>
        {
            entity.HasKey(e => e.IdChatlieu).HasName("PK__ChatLieu__942B70D5021947AC");

            entity.Property(e => e.IdChatlieu).ValueGeneratedNever();
        });

        modelBuilder.Entity<ChiTietSanPham>(entity =>
        {
            entity.HasKey(e => e.IdChiTietSp).HasName("PK__ChiTietS__C95E75E50E0E6893");

            entity.Property(e => e.IdChiTietSp).ValueGeneratedNever();

            entity.HasOne(d => d.MaChatLieuNavigation).WithMany(p => p.ChiTietSanPhams).HasConstraintName("FK__ChiTietSa__MaCha__68487DD7");

            entity.HasOne(d => d.MaMauNavigation).WithMany(p => p.ChiTietSanPhams).HasConstraintName("FK__ChiTietSa__MaMau__66603565");

            entity.HasOne(d => d.MaSizeNavigation).WithMany(p => p.ChiTietSanPhams).HasConstraintName("FK__ChiTietSa__MaSiz__6754599E");

            entity.HasOne(d => d.MaSpNavigation).WithMany(p => p.ChiTietSanPhams).HasConstraintName("FK__ChiTietSan__MaSP__656C112C");

            entity.HasOne(d => d.MaThNavigation).WithMany(p => p.ChiTietSanPhams).HasConstraintName("FK__ChiTietSan__MaTH__693CA210");
        });

        modelBuilder.Entity<ChucVu>(entity =>
        {
            entity.HasKey(e => e.IdChucVu).HasName("PK__ChucVu__2765C9B5BDF004B7");

            entity.Property(e => e.IdChucVu).ValueGeneratedNever();
        });

        modelBuilder.Entity<Doi>(entity =>
        {
            entity.HasKey(e => e.IdDoi).HasName("PK__Doi__3E411440B62440FA");

            entity.Property(e => e.IdDoi).ValueGeneratedNever();

            entity.HasOne(d => d.MaHdctNavigation).WithMany(p => p.Dois).HasConstraintName("FK__Doi__MaHDCT__0A9D95DB");
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.IdHoaDon).HasName("PK__HoaDon__B060C52C40361953");

            entity.Property(e => e.IdHoaDon).ValueGeneratedNever();

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.HoaDons).HasConstraintName("FK__HoaDon__MaKh__01142BA1");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.HoaDons).HasConstraintName("FK__HoaDon__MaNV__00200768");

            entity.HasOne(d => d.MaSpNavigation).WithMany(p => p.HoaDons).HasConstraintName("FK__HoaDon__MaSp__7E37BEF6");

            entity.HasOne(d => d.MaVoucherNavigation).WithMany(p => p.HoaDons).HasConstraintName("FK__HoaDon__MaVouche__7F2BE32F");
        });

        modelBuilder.Entity<HoaDonChiTiet>(entity =>
        {
            entity.HasKey(e => e.IdHoaDonCt).HasName("PK__HoaDonCh__4C84ED361E106603");

            entity.Property(e => e.IdHoaDonCt).ValueGeneratedNever();

            entity.HasOne(d => d.MaHdNavigation).WithMany(p => p.HoaDonChiTiets).HasConstraintName("FK__HoaDonChiT__MaHD__06CD04F7");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.IdKhachHang).HasName("PK__KhachHan__DAF646D0F1443E95");

            entity.Property(e => e.IdKhachHang).ValueGeneratedNever();
        });

        modelBuilder.Entity<MauSac>(entity =>
        {
            entity.HasKey(e => e.IdMauSac).HasName("PK__MauSac__C663C92136A94DF8");

            entity.Property(e => e.IdMauSac).ValueGeneratedNever();
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.IdNhanVien).HasName("PK__NhanVien__214E825890347D3C");

            entity.Property(e => e.IdNhanVien).ValueGeneratedNever();

            entity.HasOne(d => d.MaCaNavigation).WithMany(p => p.NhanViens).HasConstraintName("FK__NhanVien__MaCa__5629CD9C");

            entity.HasOne(d => d.MaChucVuNavigation).WithMany(p => p.NhanViens).HasConstraintName("FK__NhanVien__MaChuc__5535A963");
        });

        modelBuilder.Entity<Rank>(entity =>
        {
            entity.HasKey(e => e.RankId).HasName("PK__RANKS__B37AFB963E6216A5");

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.Ranks).HasConstraintName("FK__RANKS__MaKh__6FE99F9F");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.IdSanPham).HasName("PK__SanPham__B58D5DACF5084029");

            entity.Property(e => e.IdSanPham).ValueGeneratedNever();
        });

        modelBuilder.Entity<Size>(entity =>
        {
            entity.HasKey(e => e.IdSize).HasName("PK__Size__C69FA05B5529839D");

            entity.Property(e => e.IdSize).ValueGeneratedNever();
        });

        modelBuilder.Entity<Thongke>(entity =>
        {
            entity.HasKey(e => e.IdThongKe).HasName("PK__THONGKE__08113CFEEE675959");

            entity.Property(e => e.IdThongKe).ValueGeneratedNever();

            entity.HasOne(d => d.MaHdNavigation).WithMany(p => p.Thongkes).HasConstraintName("FK__THONGKE__MaHD__10566F31");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.Thongkes).HasConstraintName("FK__THONGKE__MaNv__114A936A");
        });

        modelBuilder.Entity<ThuongHieu>(entity =>
        {
            entity.HasKey(e => e.IdThuongHieu).HasName("PK__ThuongHi__909F29FCEF472174");

            entity.Property(e => e.IdThuongHieu).ValueGeneratedNever();
        });

        modelBuilder.Entity<Tra>(entity =>
        {
            entity.HasKey(e => e.IdTra).HasName("PK__Tra__020F13879B9A3BF6");

            entity.Property(e => e.IdTra).ValueGeneratedNever();

            entity.HasOne(d => d.MaHdctNavigation).WithMany(p => p.Tras).HasConstraintName("FK__Tra__MaHDCT__0D7A0286");
        });

        modelBuilder.Entity<Voucher>(entity =>
        {
            entity.HasKey(e => e.IdVouCher).HasName("PK__Voucher__BA9ED7CBD2C8F0FB");

            entity.Property(e => e.IdVouCher).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
