using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiemtraki2
{
    class QuanLyNV
    {
        private List<NhanVien> dsNV;
        public QuanLyNV()
        {
            dsNV = new List<NhanVien>();
        }

        public void NhapDS()
        {
            string tieptuc = "y";
            int chon;
            NhanVien nv;
            do
            {
                Console.Write("Chon loai nhan vien [1:Bien Che, 2:Hop Dong]:");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        nv = new NhanVienBC();
                        nv.Nhap(); 
                        dsNV.Add(nv); 
                        break;
                    case 2:
                        nv = new NhanVienHD();
                        nv.Nhap(); 
                        dsNV.Add(nv);
                        break;
                    default:
                        Console.WriteLine("Ban chon sai. Vui long chon 1 hoac 2.");
                        break;
                }

                Console.Write("Ban co muon tiep tuc khong? Y/N:");
                tieptuc = Console.ReadLine();
            } while (tieptuc.ToLower() == "y");
        }

        public void XuatDS()
        {
            Console.WriteLine($"{"Ma So",-10}  {"Ho Ten",20}  {"Luong Cung",10}  {"Luong",20}");
            foreach (NhanVien x in dsNV)
            {
                Console.WriteLine($"{x.MaSo,-10}  {x.HoTen,20}  {x.LuongCung,10}  {x.tinhLuong(),20:#,##0 vnd}");
            }
        }

        
        public int tinhTongLuong()
        {
            int sum = 0;
            foreach (NhanVien nv in dsNV)
            {
                sum += nv.tinhLuong();
            }

            return sum;
        }

        public double tinhLuongTrungBinh()
        {
            double LuongTB = 0;
            foreach (NhanVien nv in dsNV)
            {
                LuongTB = tinhTongLuong() / dsNV;
            }
            return LuongTB;
        }
    }
}

