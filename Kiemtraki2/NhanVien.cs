using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiemtraki2
{
    class NhanVien
    {
        private string maso;
        private string hoten;
        private int luongcung;
        
        public NhanVien()
        {

        }

        public NhanVien( string  maso, string hoten, int luongcung)
        {
            this.maso = maso;
            this.hoten = hoten;
            this.luongcung = luongcung;
        }
         
        public string MaSo 
        {
            set { this.maso = value; }
            get { return this.maso; }
        }

        public string HoTen
        {
            set { this.hoten = value; }
            get { return this.hoten; }
        }

        public int LuongCung
        {
            set { this.luongcung = value; }
            get { return this.luongcung; }
        }

        public  virtual void Nhap()
        {
            Console.Write("Nhap ma so nhan vien:");
            this.maso = Console.ReadLine();
            Console.Write("Nhap ho ten nhan vien:");
            this.hoten = Console.ReadLine();
            Console.Write("Nhap luong cung:");
            this.luongcung = int.Parse(Console.ReadLine());
        }

        public virtual int tinhLuong()
        {
            return luongcung;
        }
    }
}
