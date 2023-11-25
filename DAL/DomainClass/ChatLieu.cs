using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("ChatLieu")]
public partial class ChatLieu
{
    [Key]
    [Column("idChatlieu")]
    public Guid IdChatlieu { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string MaChatLieu { get; set; } = null!;

    [StringLength(50)]
    public string LoaiChatLieu { get; set; } = null!;

    [StringLength(30)]
    public string TrangThai { get; set; } = null!;

    [InverseProperty("MaChatLieuNavigation")]
    public virtual ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; } = new List<ChiTietSanPham>();
}
