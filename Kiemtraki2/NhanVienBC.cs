using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiemtraki2
{
    class NhanVienBC: NhanVien
    {
        private string mucxeploai;

        public NhanVienBC() : base()
        {
        }

        public NhanVienBC( string maso, string hoten, int luongcung, string mucxeploai): base( maso, hoten, luongcung)
        {
            this.mucxeploai = mucxeploai;
        }

        public string MucXepLoai
        {
            set { mucxeploai = value; }
            get { return mucxeploai; }
        }
        public override void Nhap()
        {
            base.Nhap(); 
            Console.Write("Nhap muc xep loai:");
            this.mucxeploai =Console.ReadLine();
        }

        public override int tinhLuong()
        {
            double luong;
           
            if (this.mucxeploai == "A")
            {
                luong = 1.8 * LuongCung + LuongCung;
            }
            else if (this.mucxeploai == "B")
            {
                luong = 1.2 * LuongCung + LuongCung;
            }
            if(this.mucxeploai=="C")
            {
                luong = 0.8 * LuongCung + LuongCung;
            }
            return tinhLuong();
        }
    }
}
