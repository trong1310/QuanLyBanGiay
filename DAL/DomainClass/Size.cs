using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("Size")]
public partial class Size
{
    [Key]
    [Column("idSize")]
    public Guid IdSize { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MaSize { get; set; }

    [StringLength(50)]
    public string KichThuoc { get; set; } = null!;

    [StringLength(30)]
    public string TrangThai { get; set; } = null!;

    [InverseProperty("MaSizeNavigation")]
    public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; } = new List<ChiTietSanPham>();
}
