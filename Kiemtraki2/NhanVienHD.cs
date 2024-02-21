using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiemtraki2
{
    class NhanVienHD:NhanVien
    {

        private int doanhthu;

        public NhanVienHD() : base()
        {
        }

        public NhanVienHD(string maso, string hoten, int luongcung, int doanhthu) : base (maso, hoten, luongcung)
        {
            this.doanhthu = doanhthu;
        }

        public int DoanhThu
        {
            set { doanhthu = value; }
            get { return doanhthu; }
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap doanh thu :");
            this.doanhthu = int. Parse(Console.ReadLine());
        }

        public override int tinhLuong()
        {
            return LuongCung + doanhthu * 5/100;
        }
    }
}
