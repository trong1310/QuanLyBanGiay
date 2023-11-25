using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("HoaDonChiTiet")]
public partial class HoaDonChiTiet
{
    [Key]
    [Column("idHoaDonCT")]
    public Guid IdHoaDonCt { get; set; }

    [Column("MaHDCT")]
    [StringLength(10)]
    [Unicode(false)]
    public string MaHdct { get; set; } = null!;

    public int SoLuong { get; set; }

    public double DonGia { get; set; }

    [StringLength(250)]
    public string GhiChu { get; set; } = null!;

    [Column("MaHD")]
    public Guid? MaHd { get; set; }

    [InverseProperty("MaHdctNavigation")]
    public virtual ICollection<Doi> Dois { get; set; } = new List<Doi>();

    [ForeignKey("MaHd")]
    [InverseProperty("HoaDonChiTiets")]
    public virtual HoaDon? MaHdNavigation { get; set; }

    [InverseProperty("MaHdctNavigation")]
    public virtual ICollection<Tra> Tras { get; set; } = new List<Tra>();
}
