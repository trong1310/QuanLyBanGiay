using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("Doi")]
public partial class Doi
{
    [Key]
    [Column("idDoi")]
    public Guid IdDoi { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string MaDoi { get; set; } = null!;

    [StringLength(10)]
    public string TrangThai { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime NgayDoi { get; set; }

    [StringLength(250)]
    public string LyDo { get; set; } = null!;

    [StringLength(100)]
    public string DoiSangSp { get; set; } = null!;

    [Column("MaHDCT")]
    public Guid? MaHdct { get; set; }

    [ForeignKey("MaHdct")]
    [InverseProperty("Dois")]
    public virtual HoaDonChiTiet? MaHdctNavigation { get; set; }
}
