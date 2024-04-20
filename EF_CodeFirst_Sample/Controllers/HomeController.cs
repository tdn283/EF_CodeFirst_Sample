using EF_CodeFirst_Sample.Data;
using EF_CodeFirst_Sample.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EF_CodeFirst_Sample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var sinhvien = _context.SinhViens.Where(x => x.NgaySinh.Year >= 2004 && x.NgaySinh.Year <= 2006 && x.Lop.Khoa.TenKhoa == "CNTT").ToList();

            return View(sinhvien);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
