using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3
{
    internal class Program
    {
        public static double GetAverage <T>(List <T> numberList)
        {
            double avg = 0.0;
            foreach (var number in numberList)
            {
                avg += Convert.ToDouble(number);
            }
            return avg / numberList.Count;
        }

        static void Main(string[] args)
        {
            //Console.Title = "Doan Quoc Bao- 20521097";
            List<int> listInt = new List<int> { 1, 2, 3, 7};
            List<double> listDouble = new List<double> { 4.4f, 3.4f, 12.8f, 23.6f };
            Console.WriteLine($"Trung Binh cua list int: { GetAverage(listInt)}");
            Console.WriteLine($"Trung Binh cua list double: { GetAverage(listDouble)}");
            Console.ReadKey();
        }
    }
}
