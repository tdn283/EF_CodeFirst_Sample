using EF_CodeFirst_Sample.Models;
using System.Net;

namespace EF_CodeFirst_Sample.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            // add data to database for SinhVien
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                if (!context.Khoas.Any())
                {
                    context.Khoas.AddRange(new List<Khoa>()
                    {
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
                        }
                    });
                    context.SaveChanges();
                }

                //Lop
                if (context.Lops.Any())
                {
                    context.Lops.AddRange(new List<Lop>()
                    {
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
                        }
                    });
                }

                //SinhVien
                if (context.SinhViens.Any())
                {
                    context.SinhViens.AddRange(new List<SinhVien>()
                    {
                        new SinhVien()
                        {
                            Id = 1,
                            HoTen = "Truong Dinh Nhat",
                            NgaySinh = new DateTime(2003, 8, 2),
                            LopId = 1
                        },
                        new SinhVien()
                        {
                            Id = 2,
                            HoTen = "Nguyen Duy Tung",
                            NgaySinh = new DateTime(2005, 1, 7),
                            LopId = 2
                        },
                        new SinhVien()
                        {
                            Id = 3,
                            HoTen = "To Ngoc Hai",
                            NgaySinh = new DateTime(2006, 2, 4),
                            LopId = 3
                        }
                    });
                }
            }
        }
    }
}
