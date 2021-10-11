using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("BangTam")]
    public partial class BangTam
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(50)]
        public string Manv { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string TenNv { get; set; }
        [StringLength(50)]
        public string DiaChi { get; set; }
        public byte? TinhTrang { get; set; }
        [StringLength(50)]
        public string MatKhau { get; set; }
        public byte? VaiTro { get; set; }
        public int? So { get; set; }
        public int? TrangThai { get; set; }
        public int? NhoMatKhau { get; set; }
    }
}
