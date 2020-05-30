using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Fastfood1.Models
{
    public partial class FastfoodContext : DbContext
    {
        public FastfoodContext()
        {
        }

        public FastfoodContext(DbContextOptions<FastfoodContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Chitiethd> Chitiethd { get; set; }
        public virtual DbSet<Danhmuc> Danhmuc { get; set; }
        public virtual DbSet<Hoadon> Hoadon { get; set; }
        public virtual DbSet<Monan> Monan { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=DESKTOP-FC0IVIL;Database=Fastfood;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chitiethd>(entity =>
            {
                entity.Property(e => e.Thanhtien).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Hoadon)
                    .WithMany(p => p.Chitiethd)
                    .HasForeignKey(d => d.HoadonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Chitiethd_Hoadon");

                entity.HasOne(d => d.Monan)
                    .WithMany(p => p.Chitiethd)
                    .HasForeignKey(d => d.MonanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Chitiethd_Monan");
            });

            modelBuilder.Entity<Danhmuc>(entity =>
            {
                entity.Property(e => e.TenDanhmuc)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Hoadon>(entity =>
            {
                entity.Property(e => e.Ngaylap).HasColumnType("date");

                entity.Property(e => e.Tongtien).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Hoadon)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hoadon_User");
            });

            modelBuilder.Entity<Monan>(entity =>
            {
                entity.Property(e => e.Giaban).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Giamgia).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LoaiMonan)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Mota)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Photo).IsRequired();

                entity.Property(e => e.TenMonan)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.Danhmuc)
                    .WithMany(p => p.Monan)
                    .HasForeignKey(d => d.DanhmucId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Monan_Danhmuc");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Diachi)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Sodienthoai).HasColumnType("decimal(16, 4)");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
