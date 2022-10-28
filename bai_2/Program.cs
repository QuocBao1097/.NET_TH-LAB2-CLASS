using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau2
{
    class Sach
    {
        public long MaSach { get; set; }
        public string TenSach { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }
        public string NXB { get; set; }

        public Sach() { }
        public Sach(long maSach, string tenSach, double donGia, int soLuong, string nxb)
        {
            MaSach = maSach;
            TenSach = tenSach;
            DonGia = donGia;
            SoLuong = soLuong;
            NXB = nxb;
        }

        public override string ToString()
        {
            return "Sách";
        }
        public virtual double ThanhTien()
        {
            return 0;
        }
    }
    class SachTieuThuyet : Sach
    {
        public bool TinhTrang { get; set; }
        private double _thanhTien;
        public SachTieuThuyet() { }
        public SachTieuThuyet(long maSach, string tenSach, double donGia, int soLuong, string nxb, bool tTrang)
        {
            TinhTrang = tTrang;
            MaSach = maSach;
            TenSach = tenSach;
            DonGia = donGia;
            SoLuong = soLuong;
            NXB = nxb;
        }
        public override string ToString()
        {
            return "Sach Tieu Thuyet";
        }
        public override double ThanhTien()
        {
            if (TinhTrang == true)
            {
                _thanhTien = SoLuong * DonGia;
                return _thanhTien;
            }
            else
            {
                _thanhTien = SoLuong * DonGia * 0.02;
                return _thanhTien;
            }
        }
    }
    class SachTrinhTham : Sach
    {
        public float Thue { get; set; }

        public SachTrinhTham() { }
        public SachTrinhTham(long maSach, string tenSach, double donGia, int soLuong, string nxb, float thue)
        {
            Thue = thue;
            MaSach = maSach;
            TenSach = tenSach;
            DonGia = donGia;
            SoLuong = soLuong;
            NXB = nxb;
            Thue = thue;

        }
        public override string ToString()
        {
            return "Sach Trinh Tham";
        }
        public override double ThanhTien()
        {
            return SoLuong * DonGia + Thue;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "20521097-Doan Quoc Bao";

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.UTF8;

            SachTieuThuyet sachTieuThuyet = new SachTieuThuyet(123, "Lap Trinh Web", 1111, 4, "Sai Gon", true);
            Console.WriteLine("Ma Sach:" + sachTieuThuyet.MaSach);
            Console.WriteLine("Ten Sach:" + sachTieuThuyet.TenSach);
            Console.WriteLine("Don Gia:" + sachTieuThuyet.DonGia);
            Console.WriteLine("So Luong:" + sachTieuThuyet.SoLuong);
            Console.WriteLine("Nha Xuat Ban:" + sachTieuThuyet.NXB);
            Console.WriteLine("Thanh Tien: " + sachTieuThuyet.ThanhTien());
            Console.WriteLine("ToString: " + sachTieuThuyet.ToString());

            Console.ReadKey();
        }
    }
}
