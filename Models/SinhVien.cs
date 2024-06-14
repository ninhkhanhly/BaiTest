using System.ComponentModel.DataAnnotations;
namespace Ninhkhanhly22222.Models
{
    public class SinhVien{
        [Key]
        public string MaSinhVien { get; set; }
        public string HoTen { get; set; }
        public string MaLop { get; set; }
    }
}