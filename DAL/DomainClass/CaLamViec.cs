using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("CaLamViec")]
public partial class CaLamViec
{
    [Key]
    [Column("idCaLamViec")]
    public Guid IdCaLamViec { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string MaCa { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ThoiGian { get; set; }

    [StringLength(30)]
    public string TrangThai { get; set; } = null!;

    [InverseProperty("MaCaNavigation")]
    public virtual ICollection<NhanVien> NhanViens { get; set; } = new List<NhanVien>();
}
