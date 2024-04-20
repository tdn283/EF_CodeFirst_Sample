namespace EF_CodeFirst_Sample.Models
{
    public class SinhVien
    {
        public int Id { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public int LopId { get; set; }
        public Lop Lop { get; set; }
    }
}
