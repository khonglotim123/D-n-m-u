using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("NhanVien")]
    public partial class NhanVien
    {
        public NhanVien()
        {
            Hangs = new HashSet<Hang>();
            KhachHangs = new HashSet<KhachHang>();
        }

        public int Id { get; set; }
        [Key]
        [StringLength(20)]
        public string MaNv { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [StringLength(50)]
        public string TeNv { get; set; }
        [Required]
        [StringLength(100)]
        public string DiaChi { get; set; }
        public byte TinhTrang { get; set; }
        [Required]
        [StringLength(50)]
        public string MatKhau { get; set; }
        public byte VaiTro { get; set; }
        public int? So { get; set; }
        public int? TrangThai { get; set; }

        [InverseProperty(nameof(Hang.MaNvNavigation))]
        public virtual ICollection<Hang> Hangs { get; set; }
        [InverseProperty(nameof(KhachHang.MaNvNavigation))]
        public virtual ICollection<KhachHang> KhachHangs { get; set; }
    }
}
