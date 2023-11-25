using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("NhanVien")]
public partial class NhanVien
{
    [Key]
    [Column("idNhanVien")]
    public Guid IdNhanVien { get; set; }

    [Column("MaNV")]
    [StringLength(10)]
    [Unicode(false)]
    public string MaNv { get; set; } = null!;

    [StringLength(50)]
    public string TenNhanVien { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string SoDienThoai { get; set; } = null!;

    [StringLength(50)]
    public string Email { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string GioiTinh { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime NgaySinh { get; set; }

    [StringLength(250)]
    public string DiaChi { get; set; } = null!;

    [StringLength(30)]
    public string MatKhau { get; set; } = null!;

    [StringLength(30)]
    public string TrangThai { get; set; } = null!;

    public Guid? MaChucVu { get; set; }

    public Guid? MaCa { get; set; }

    [InverseProperty("MaNvNavigation")]
    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();

    [ForeignKey("MaCa")]
    [InverseProperty("NhanViens")]
    public virtual CaLamViec? MaCaNavigation { get; set; }

    [ForeignKey("MaChucVu")]
    [InverseProperty("NhanViens")]
    public virtual ChucVu? MaChucVuNavigation { get; set; }

    [InverseProperty("MaNvNavigation")]
    public virtual ICollection<Thongke> Thongkes { get; set; } = new List<Thongke>();
}
