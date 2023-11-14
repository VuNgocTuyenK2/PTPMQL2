using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class HeThongPhanPhoi
    {
        [Key]
        public string? MaHTPP { get; set; }
        public string? TenHTPP { get; set; }
    }
}