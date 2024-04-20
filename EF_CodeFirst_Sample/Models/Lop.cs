namespace EF_CodeFirst_Sample.Models
{
    public class Lop
    {
        public int Id { get; set; }
        public string TenLop { get; set; }
        public int KhoaId { get; set; }
        public Khoa Khoa { get; set; }
    }
}
