using System;
using System.Collections.Generic;

namespace Fastfood1.Models
{
    public partial class Chitiethd
    {
        public int MonanId { get; set; }
        public int Soluong { get; set; }
        public decimal Thanhtien { get; set; }
        public int HoadonId { get; set; }
        public int ChitiethdId { get; set; }

        public virtual Hoadon Hoadon { get; set; }
        public virtual Monan Monan { get; set; }
    }
}
