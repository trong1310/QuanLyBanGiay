using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("Tra")]
public partial class Tra
{
    [Key]
    [Column("idTra")]
    public Guid IdTra { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string MaTra { get; set; } = null!;

    [StringLength(10)]
    public string TrangThai { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime NgayDoi { get; set; }

    [StringLength(250)]
    public string LyDo { get; set; } = null!;

    [Column("MaHDCT")]
    public Guid? MaHdct { get; set; }

    [ForeignKey("MaHdct")]
    [InverseProperty("Tras")]
    public virtual HoaDonChiTiet? MaHdctNavigation { get; set; }
}
