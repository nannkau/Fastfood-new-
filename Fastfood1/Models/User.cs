using System;
using System.Collections.Generic;

namespace Fastfood1.Models
{
    public partial class User
    {
        public User()
        {
            Hoadon = new HashSet<Hoadon>();
        }

        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Quyen { get; set; }
        public int Trangthai { get; set; }
        public decimal Sodienthoai { get; set; }
        public string Diachi { get; set; }

        public virtual ICollection<Hoadon> Hoadon { get; set; }
    }
}
