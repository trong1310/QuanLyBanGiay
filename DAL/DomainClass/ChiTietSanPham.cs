using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("ChiTietSanPham")]
public partial class ChiTietSanPham
{
    [Key]
    [Column("idChiTietSp")]
    public Guid IdChiTietSp { get; set; }

    [Column("MASPCT")]
    [StringLength(10)]
    [Unicode(false)]
    public string Maspct { get; set; } = null!;

    public double Gia { get; set; }

    public int SoLuong { get; set; }

    [Column("MaSP")]
    public Guid? MaSp { get; set; }

    public Guid? MaMau { get; set; }

    public Guid? MaSize { get; set; }

    public Guid? MaChatLieu { get; set; }

    [Column("MaTH")]
    public Guid? MaTh { get; set; }

    [ForeignKey("MaChatLieu")]
    [InverseProperty("ChiTietSanPhams")]
    public virtual ChatLieu? MaChatLieuNavigation { get; set; }

    [ForeignKey("MaMau")]
    [InverseProperty("ChiTietSanPhams")]
    public virtual MauSac? MaMauNavigation { get; set; }

    [ForeignKey("MaSize")]
    [InverseProperty("ChiTietSanPhams")]
    public virtual Size? MaSizeNavigation { get; set; }

    [ForeignKey("MaSp")]
    [InverseProperty("ChiTietSanPhams")]
    public virtual SanPham? MaSpNavigation { get; set; }

    [ForeignKey("MaTh")]
    [InverseProperty("ChiTietSanPhams")]
    public virtual ThuongHieu? MaThNavigation { get; set; }
}
