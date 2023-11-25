using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("SanPham")]
public partial class SanPham
{
    [Key]
    [Column("idSanPham")]
    public Guid IdSanPham { get; set; }

    [Column("MaSP")]
    [StringLength(10)]
    [Unicode(false)]
    public string MaSp { get; set; } = null!;

    [StringLength(250)]
    public string TenSanPham { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime NgayNhap { get; set; }

    public int SoLuong { get; set; }

    [StringLength(30)]
    public string TrangThai { get; set; } = null!;

    [InverseProperty("MaSpNavigation")]
    public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; } = new List<ChiTietSanPham>();

    [InverseProperty("MaSpNavigation")]
    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
