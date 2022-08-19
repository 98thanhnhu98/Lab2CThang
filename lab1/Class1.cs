using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.NewFolder.NewFolder
{
    class Class1
    {
        static void bai1()
        {

        }
        static void Bai2()
        {

        }
        static void Baiw3()
        {
            Console.WriteLine("nhập");
            int date = int.Parse(Console.ReadLine());
            if (date == 1)
            {
                Console.WriteLine("Thứ 2");
            }
            if (date == 2)
            {
                Console.WriteLine("Thứ 3");
            }
            if (date == 3)
            {
                Console.WriteLine("Thứ 4");
            }
            if (date == 4)
            {
                Console.WriteLine("Thứ 5");
            }
            if (date == 5)
            {
                Console.WriteLine("Thứ 6");
            }
            if (date == 6)
            {
                Console.WriteLine("Thứ 7");
            }
            if (date == 7)
            {
                Console.WriteLine("Chủ Nhật");
            }
        }
        static void Bai4()
        {

        }
        static void Bai5()
        {
            int n;
            Console.WriteLine("\nNhap n = ");
            n = int.Parse(Console.ReadLine());
            int dem;

            for (int i = 2; i <= n; i++)
            {
                dem = 0;
                while (n % i == 0)
                {
                    ++dem;
                    n /= i;
                }
                if (dem != 0)
                {
                    if (dem > 1)
                    {
                        Console.WriteLine("%d^%d", i, dem);
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                    if (n > i)
                    {
                        Console.WriteLine(" * ");
                    }
                }
            }
        }

    }
}