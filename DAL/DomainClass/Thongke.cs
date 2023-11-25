using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("THONGKE")]
public partial class Thongke
{
    [Key]
    [Column("idThongKe")]
    public Guid IdThongKe { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string MaThongKe { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime NgayThongKe { get; set; }

    [StringLength(40)]
    public string TongDoanhThu { get; set; } = null!;

    public int SoLuong { get; set; }

    [Column("MaHD")]
    public Guid? MaHd { get; set; }

    public Guid? MaNv { get; set; }

    [ForeignKey("MaHd")]
    [InverseProperty("Thongkes")]
    public virtual HoaDon? MaHdNavigation { get; set; }

    [ForeignKey("MaNv")]
    [InverseProperty("Thongkes")]
    public virtual NhanVien? MaNvNavigation { get; set; }
}
