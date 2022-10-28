using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IV_bai2
{
    internal class Program
    {
        class SinhVien
        {
            private int _MSSV;
            private string _HoTen;
            private float _DiemLT;
            private float _DiemTH;


            public SinhVien()
            {
              
            }
            public SinhVien(int MSSV, string HoTen, float DiemLT, float DiemTH)
            {
                this._MSSV = MSSV;
                this._HoTen = HoTen;
                this._DiemLT = DiemLT;
                this._DiemTH = DiemTH;
            }

            public int MSSV
            {
                get { return _MSSV; }
                set { _MSSV = value; }
            }   
            public string HoTen
            {
                get { return _HoTen; }
                set { _HoTen = value; }
            }

            public float DiemLT
            {
                get { return _DiemLT; }
                set { _DiemLT = value; }
            }
            public float DiemTH
            {
                get { return _DiemTH; }
                set { _DiemTH = value; }
            }

            public double TinhDiemTrungBinh()
            {
                return (DiemTH + DiemLT) / 2.0;
            }

            public override string ToString()
            {
                Console.WriteLine($"{MSSV}\t {HoTen}\t {DiemLT}\t {DiemTH} \t {TinhDiemTrungBinh()}");
                return "";
            }
        }

        class HandleSinhVien
        {
            public void Main()
            {
                List<SinhVien> listSV = new List<SinhVien>();
                int n;
                Console.Write("Nhap so luong sinh vien: ");
                n = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    SinhVien sv = new SinhVien();

                    Console.WriteLine($"----Nhap Thong Tin Sinh Vien {i} -----");
                    Console.Write("MSSV: ");
                    sv.MSSV = Convert.ToInt32(Console.ReadLine());

                    Console.Write("HoTen: ");
                    sv.HoTen = Console.ReadLine();

                    Console.Write("DiemLT: ");
                    sv.DiemLT = float.Parse(Console.ReadLine());

                    Console.Write("DiemTH: ");
                    sv.DiemTH = float.Parse(Console.ReadLine());

                    listSV.Add(sv);
                    Console.WriteLine("---Thong Tin Chi Tiet---");
                }

                // In thong tin Sinh Vien
                Console.WriteLine("MSSV\tHoTen\tDiem LT\tDiemTH\tDiemTrungBinh");
                foreach (var sv in listSV)
                {
                    sv.ToString();
                }

            }

        }
        static void Main(string[] args)
        {
            HandleSinhVien hdsv = new HandleSinhVien();

            hdsv.Main();

            Console.ReadKey();
        }
    }
}
