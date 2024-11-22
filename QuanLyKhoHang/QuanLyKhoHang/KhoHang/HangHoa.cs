using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhoHang.KhoHang
{
    internal class HangHoa
    {
        private string hhMaHangHoa;
        private string hhTenHangHoa;
        private int hhSoLuong;
        private int hhGiaNhap;
        private int hhGiaBan;

        public HangHoa()
        {
            this.hhMaHangHoa = string.Empty;
            this.hhGiaNhap = 0;
            this.hhGiaBan = 0;
            this.hhTenHangHoa = string.Empty ;
            this.hhSoLuong = 0;
        }

        public HangHoa (string hhMaHangHoa, string hhTenHangHoa, int hhSoLuong, int hhGiaNhap, int hhGiaBan)
        {
            this.hhMaHangHoa = hhMaHangHoa;
            this.hhTenHangHoa = hhTenHangHoa;
            this.hhSoLuong = hhSoLuong;
            this.hhGiaNhap = hhGiaNhap;
            this.hhGiaBan = hhGiaBan;
        }

        public string HhMaHangHoa
        {
            get { return this.hhMaHangHoa; }
            set { this.hhMaHangHoa = value; }
        }

        public string HhTenHangHoa
        {
            get { return this.hhTenHangHoa; }
            set { this.hhTenHangHoa = value; }
        }

        public int HhSoLuong
        {
            get { return this.hhSoLuong; }
            set { this.hhSoLuong = value; }
        }

        public int HhGiaNhap
        {
            get { return this.hhGiaNhap; }
            set { this.hhGiaNhap = value;}  
        }

        public int HhGiaBan
        {
            get { return this.hhGiaBan; }
            set { this.hhGiaBan = value; }
        }


    }
}
