using EF_CodeFirst_Sample.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_CodeFirst_Sample.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<Lop> Lops { get; set; }
        public DbSet<Khoa> Khoas { get; set; }

        // seed data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Khoa>().HasData(
                new Khoa()
                {
                    Id = 1,
                    TenKhoa = "CNTT"
                },
                new Khoa()
                {
                    Id = 2,
                    TenKhoa = "DT"
                },
                new Khoa()
                {
                    Id = 3,
                    TenKhoa = "SPCN"
                });

            modelBuilder.Entity<Lop>().HasData(
                new Lop()
                {
                    Id = 1,
                    TenLop = "21T1",
                    KhoaId = 1
                },
                new Lop()
                {
                    Id = 2,
                    TenLop = "21T2",
                    KhoaId = 1
                },
                new Lop()
                {
                    Id = 3,
                    TenLop = "21T3",
                    KhoaId = 1
                });

            modelBuilder.Entity<SinhVien>().HasData(
                new SinhVien()
                {
                    Id = 1,
                    HoTen = "NTruong Dinh Nhat",
                    NgaySinh = new System.DateTime(2003, 8, 2),
                    LopId = 1
                },
                new SinhVien()
                {
                    Id = 2,
                    HoTen = "Nguyen Duy Tung",
                    NgaySinh = new System.DateTime(2005, 1, 2),
                    LopId = 2
                },
                new SinhVien()
                {
                    Id = 3,
                    HoTen = "To Ngoc Hai",
                    NgaySinh = new System.DateTime(2004, 2, 11),
                    LopId = 3
                });
        }
    }
}
