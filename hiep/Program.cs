using System;

namespace _hiep

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PHAN MEM TINH DIEN TICH HINH THANG");

            double a, b, h;

            Console.Write("Nhap do dai canh day a: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Nhap do dai canh day b: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Nhap chieu cao h: ");
            h = double.Parse(Console.ReadLine());

            // Formula for the area of a trapezoid
            double area = ((a + b) * h) / 2;

            Console.WriteLine("Dien tich hinh thang = {0}", area);
        }
    }
}
