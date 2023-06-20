namespace MyWebApiApp.Data
{
    public class DonHangChiTiet
    {
        public Guid MaHh { get; set; }
        public Guid MaDh { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }
        public byte GiamGia { get; set; }

        //relationship
        public DonHang Donhang { get; set; }
        public HangHoa HangHoa { get; set; }

    }
}
