using System.ComponentModel.DataAnnotations;

namespace Ninhkhanhly22222.Models
{
    public class LopHoc
    {
        [Key]
        public string MaLop { get; set; }
        public string TenLop { get; set; }
    }
}