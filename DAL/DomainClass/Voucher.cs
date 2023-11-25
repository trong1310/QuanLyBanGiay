using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("Voucher")]
public partial class Voucher
{
    [Key]
    [Column("idVouCher")]
    public Guid IdVouCher { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string MaVoucher { get; set; } = null!;

    [StringLength(50)]
    public string TenVoucher { get; set; } = null!;

    [StringLength(250)]
    public string MoTa { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string TrangThai { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime NgayBatDau { get; set; }

    [Column(TypeName = "date")]
    public DateTime NgayKetThuc { get; set; }

    [InverseProperty("MaVoucherNavigation")]
    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
