using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_bai1
{
    internal class Program
    {
        class HinhChuNhat
        {
            public double ChieuDai { set; get; }
            public double ChieuRong { set; get; }

            public double TinhDienTich()
            {
                return ChieuDai * ChieuRong;
            }
            public double TinhChuVi()
            {
                return (ChieuDai + ChieuRong) * 2;
            }

            public override string ToString()
            {
                Console.WriteLine("\n---Xuat Thong Tin Hinh Chu Nhat---");
                Console.WriteLine($"Chieu Dai: {ChieuDai} \t Chieu Rong: {ChieuRong} \t Chu Vi: {TinhChuVi()} \t Dien Tich: {TinhDienTich()}");
                return "";
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "20521097-Doan Quoc Bao";

            HinhChuNhat hcn = new HinhChuNhat();
            do
            {
                Console.WriteLine("--- Vui long nhap thong tin Hinh Chu Nhat---");
                Console.Write("+ Chieu Dai: ");
                hcn.ChieuDai = Convert.ToDouble(Console.ReadLine());

                Console.Write("+ Chieu Rong: ");
                hcn.ChieuRong = Convert.ToDouble(Console.ReadLine());

                if(hcn.ChieuDai <= 0 || hcn.ChieuRong <= 0)
                {
                    Console.WriteLine("WARNING: Chieu Dai va Chieu Rong Phai khac 0! Vui long nhap lai...");
                    Console.WriteLine("--------------------------------");
                }

            } while (hcn.ChieuDai <= 0 || hcn.ChieuRong <= 0);

            hcn.ToString();

            Console.ReadKey();
        }
    }
}
