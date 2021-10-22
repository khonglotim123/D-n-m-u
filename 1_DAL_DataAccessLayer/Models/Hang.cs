﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("Hang")]
    public partial class Hang
    {
        [Key]
        public int MaHang { get; set; }
        [Required]
        [StringLength(50)]
        public string TenHang { get; set; }
        public int SoLuong { get; set; }
        public double DonGiaBan { get; set; }
        public double DonGiaNhap { get; set; }
        [Required]
        [StringLength(400)]
        public string HinhAnh { get; set; }
        [StringLength(20)]
        public string GhiChu { get; set; }
        [Required]
        [StringLength(20)]
        public string MaNv { get; set; }
        public int? TrangThai { get; set; }
        [Column("id")]
        public int Id { get; set; }

        [ForeignKey(nameof(MaNv))]
        [InverseProperty(nameof(NhanVien.Hangs))]
        public virtual NhanVien MaNvNavigation { get; set; }
    }
}
