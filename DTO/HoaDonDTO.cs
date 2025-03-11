using System;

namespace DTO
{
    public class HoaDonDTO
    {
        private string _maHD;
        private string _maCTT;
        private int _giamGia;
        private int _phuThu;
        private DateTime _ngayThanhToan;
        private int _phuongThucThanhToan; // 0 là tiền mặt, 1 là chuyển khoản,...
        private int _xuLy; // 0 là chưa xóa, 1 là đã xóa
        private string _maCN; // Mã chi nhánh

        public HoaDonDTO()
        {
        }

        public HoaDonDTO(string maHD, string maCTT, int giamGia, int phuThu, DateTime ngayThanhToan, int phuongThucThanhToan, int xuLy, string maCN)
        {
            _maHD = maHD;
            _maCTT = maCTT;
            _giamGia = giamGia;
            _phuThu = phuThu;
            _ngayThanhToan = ngayThanhToan;
            _phuongThucThanhToan = phuongThucThanhToan;
            _xuLy = xuLy;
            _maCN = maCN;
        }

        public string MaHD { get => _maHD; set => _maHD = value; }
        public string MaCTT { get => _maCTT; set => _maCTT = value; }
        public int GiamGia { get => _giamGia; set => _giamGia = value; }
        public int PhuThu { get => _phuThu; set => _phuThu = value; }
        public DateTime NgayThanhToan { get => _ngayThanhToan; set => _ngayThanhToan = value; }
        public int PhuongThucThanhToan { get => _phuongThucThanhToan; set => _phuongThucThanhToan = value; }
        public int XuLy { get => _xuLy; set => _xuLy = value; }
        public string MaCN { get => _maCN; set => _maCN = value; } // Thêm property cho mã chi nhánh
    }
}
