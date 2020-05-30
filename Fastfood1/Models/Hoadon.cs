using System;
using System.Collections.Generic;

namespace Fastfood1.Models
{
    public partial class Hoadon
    {
        public Hoadon()
        {
            Chitiethd = new HashSet<Chitiethd>();
        }

        public int UserId { get; set; }
        public DateTime Ngaylap { get; set; }
        public decimal Tongtien { get; set; }
        public int HoadonId { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Chitiethd> Chitiethd { get; set; }
    }
}
