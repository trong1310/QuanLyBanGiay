using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("ChucVu")]
public partial class ChucVu
{
    [Key]
    [Column("idChucVu")]
    public Guid IdChucVu { get; set; }

    [Column("MaCV")]
    [StringLength(10)]
    [Unicode(false)]
    public string MaCv { get; set; } = null!;

    [StringLength(50)]
    public string TenChucVu { get; set; } = null!;

    [InverseProperty("MaChucVuNavigation")]
    public virtual ICollection<NhanVien> NhanViens { get; set; } = new List<NhanVien>();
}
