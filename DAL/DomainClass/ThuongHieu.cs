using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("ThuongHieu")]
public partial class ThuongHieu
{
    [Key]
    [Column("idThuongHieu")]
    public Guid IdThuongHieu { get; set; }

    [Column("MaTH")]
    [StringLength(10)]
    [Unicode(false)]
    public string MaTh { get; set; } = null!;

    [StringLength(50)]
    public string TenThuongHieu { get; set; } = null!;

    [StringLength(30)]
    public string TrangThai { get; set; } = null!;

    [InverseProperty("MaThNavigation")]
    public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; } = new List<ChiTietSanPham>();
}
