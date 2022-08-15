using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.NewFolder
{
    internal class Class2
    {


         /*     BÀI 1     */
        static void ex1()
        {
            DateTime now = DateTime.Now;
            Random rand = new Random((int)now.Millisecond);
            int[] Arr = new int[10];
            for (int x = 0; x < Arr.Length; ++x)
            {
                Arr[x] = rand.Next() % 100;
            }
            int Total = 0;
            Console.Write("Array values are ");
            foreach (int val in Arr)
            {
                Total += val;
                Console.Write(val + ", ");
            }
            Console.WriteLine("\nAnd the average is {0,0:F1}",
                              (double)Total / (double)Arr.Length);
            Console.ReadLine();
        }
        /*tatic void Main(string[] args)
        {
            ex1();
        }*/
    }



    /*     BÀI 2     */
    class Employee
    {
        private int empID;

        // constructor
        public Employee(int empID)
        {
            this.empID = empID;
        }
        public override string ToString()
        {
            return empID.ToString();
        }
    }


    class ObjectArray
    {
        public void Run()
        {
            int[] intArray;
            Employee[] empArray;
            intArray = new int[5];
            empArray = new Employee[3];

            // populate the array
            for (int i = 0; i < empArray.Length; i++)
            {
                empArray[i] = new Employee(i + 5);
            }

            Console.WriteLine("The int array...");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i].ToString());
            }

            Console.WriteLine("\nThe employee array...");
            for (int i = 0; i < empArray.Length; i++)
            {
                Console.WriteLine(empArray[i].ToString());
            }
        }
        /*tatic void Main(string[] args)
          {
              ObjectArray arr = new ObjectArray();
              arr.Run();
              Console.ReadLine();
          }*/
    }

    /*   Bài 3  Lab2*/
    class ArrayClass
    {
         void ex3()
        {
            int[] Arr = new int[12] { 29, 82, 42, 46, 54, 65, 50, 42, 5, 94, 19, 34 };
            Console.WriteLine("The first occurrence of 42 is at index "
                               + Array.IndexOf(Arr, 42));
            Console.WriteLine("The last occurrence of 42 is at index "
                               + Array.LastIndexOf(Arr, 42));
            int x = 0;
            while ((x = Array.IndexOf(Arr, 42, x)) >= 0)
            {
                Console.WriteLine("42 found at index " + x);
                ++x;
            }
            x = Arr.Length - 1;
            while ((x = Array.LastIndexOf(Arr, 42, x)) >= 0)
            {
                Console.WriteLine("42 found at index " + x);
                --x;
            }

            Console.WriteLine("Array that before sorted");
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine("{0} :      {1}", i + 1, Arr[i]);
            }
            Array.Sort(Arr);
            Console.WriteLine("Array that after sorted");
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine("{0} :      {1}", i + 1, Arr[i]);
            }
            Array.Reverse(Arr);
            Console.WriteLine("Array that after reserse");
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine("{0} :      {1}", i + 1, Arr[i]);
            }
            Console.ReadLine();
        }
     /*   public static void Main(string[] args)
        {
            ArrayClass arr = new ArrayClass();
            arr.ex3();
        }*/
    }
}