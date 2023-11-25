using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("RANKS")]
public partial class Rank
{
    [Key]
    [Column("RankID")]
    [StringLength(10)]
    [Unicode(false)]
    public string RankId { get; set; } = null!;

    [StringLength(100)]
    public string DieuKien { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string MucUuDai { get; set; } = null!;

    [StringLength(30)]
    public string TrangThai { get; set; } = null!;

    [StringLength(250)]
    public string MoTa { get; set; } = null!;

    public Guid? MaKh { get; set; }

    [ForeignKey("MaKh")]
    [InverseProperty("Ranks")]
    public virtual KhachHang? MaKhNavigation { get; set; }
}
