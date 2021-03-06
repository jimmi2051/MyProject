namespace MyProject.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kho")]
    public partial class Kho
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaSP { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaPhieu { get; set; }

        public int? SoLuong { get; set; }

        public DateTime? NgayLap { get; set; }

        public DateTime? NgayXuat { get; set; }

        public virtual PhieuNhapXuat PhieuNhapXuat { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
