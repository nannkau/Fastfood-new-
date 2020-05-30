using System;
using System.Collections.Generic;

namespace Fastfood1.Models
{
    public partial class Monan
    {
        public Monan()
        {
            Chitiethd = new HashSet<Chitiethd>();
        }

        public string TenMonan { get; set; }
        public string LoaiMonan { get; set; }
        public decimal? Giaban { get; set; }
        public int Soluong { get; set; }
        public byte[] Photo { get; set; }
        public int Trangthai { get; set; }
        public string Mota { get; set; }
        public decimal Giamgia { get; set; }
        public int DanhmucId { get; set; }
        public int MonanId { get; set; }

        public virtual Danhmuc Danhmuc { get; set; }
        public virtual ICollection<Chitiethd> Chitiethd { get; set; }
    }
}
