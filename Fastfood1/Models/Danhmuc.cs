using System;
using System.Collections.Generic;

namespace Fastfood1.Models
{
    public partial class Danhmuc
    {
        public Danhmuc()
        {
            Monan = new HashSet<Monan>();
        }

        public string TenDanhmuc { get; set; }
        public int DanhmucId { get; set; }

        public virtual ICollection<Monan> Monan { get; set; }
    }
}
