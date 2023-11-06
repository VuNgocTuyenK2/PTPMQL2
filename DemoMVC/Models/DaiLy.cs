namespace DemoMVC.Models
{
    public class DaiLy : HeThongPhanPhoi
    {
        public required string MaDaiLy { get; set; }
        public required string TenDaiLy { get; set; }
        public required string DiaChi { get; set; }
        public required string NguoiDaiDien { get; set; }
        public required string DienThoai { get; set; }
    }
}