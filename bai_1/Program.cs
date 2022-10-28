using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {   
        public class TaiKhoan
        {
            private long SoTaiKhoan;
            private string TenTaiKhoan;
            private double SoTien;

            public TaiKhoan()
            {

            }

            public TaiKhoan(long SoTaiKhoan, string TenTaiKhoan, double SoTien =10)
            {
                this.SoTaiKhoan = SoTaiKhoan;
                this.TenTaiKhoan = TenTaiKhoan;
                this.SoTien = SoTien;
            }

            public long getSoTaiKhoan()
            {
                return SoTaiKhoan;
            }

            public void setSoTaiKhoan(long SoTaiKhoan)
            {
                this.SoTaiKhoan = SoTaiKhoan;
            }


            public string getTenTaiKhoan()
            {
                return TenTaiKhoan;
            }

            public void setTenTaiKhoan(string TenTaiKhoan)
            {
                this.TenTaiKhoan = TenTaiKhoan;
            }

            public double getSoTien()
            {
                return SoTien;
            }

            public void setSoTien(double SoTien)
            {
                this.SoTien = SoTien;
            }

            public string toString()
            {
                Console.WriteLine("-------Thong tin tai khoan la-------- ");
                Console.WriteLine("So tai khoan: " + this.getSoTaiKhoan());
                Console.WriteLine("Ten tai khoan: " + this.getTenTaiKhoan());
                Console.WriteLine("So tien hien co la: " + this.getSoTien() + " USD");
                return "";
            }

            public bool NapTien(double st)
            {
                if (st > 0)
                {
                    this.SoTien = this.SoTien + st;
                    return true;
                }
                return false;
            }

            public bool RutTien(double st)
            {
                if (st > 0 && st < this.SoTien)
                {
                        this.SoTien = this.SoTien - (st*1.01);
                        return true;
                }
                else
                      return false;
            }
        }


        static void Main(string[] args)
        {
            TaiKhoan taiKhoan = new TaiKhoan(00192012, "Quoc Bao", 196999);
            taiKhoan.toString();
            Console.ReadKey();
        }
    }
}

