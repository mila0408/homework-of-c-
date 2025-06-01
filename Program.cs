using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace homework16._04._25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //задание 3
            // чтобы проверитть задание нужно закаментировать остальные задания 
            string line;
            string num = "";
            for (int i = 0; i < 4; i++)
            {
                line = Console.ReadLine();
                num = num + line;
            }
            int number = Int32.Parse(num);
            Console.WriteLine(number);

            //задание 4 

            Console.WriteLine("Please enter a six-digit number");
            string num;
            num = Console.ReadLine();
            if (num.Length != 6)
            {
                Console.WriteLine("The number was entered incorrectly");
            }
            else
            {
                Console.WriteLine("Please enter two numbers");
                int num1 = Int32.Parse((Console.ReadLine()));
                int num2 = Int32.Parse((Console.ReadLine()));
                char buf2 = num[num2 - 1];
                char buf1 = num[num1 - 1];
                var result = num.Select(x => x == buf1 ? buf2 : (x == buf2 ? buf1 : x)).ToArray();
                num = new String(result);



            }
            Console.WriteLine(num);

            //задание 6

            double num;
            Console.WriteLine(" from farenheit to celsius: 1");
            Console.WriteLine(" from celcius to farenheit: 2");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("enter the degrees:");
                    num = double.Parse(Console.ReadLine());
                    num = 5 / 9 * (num - 32);
                    Console.WriteLine(num.ToString());
                    return;

                case 2:
                    Console.WriteLine("enter the degrees:");
                    num = double.Parse(Console.ReadLine());
                    num = (num * 9) / 5 + 32;
                    Console.WriteLine(num.ToString());
                    return;
                default:
                    break;
            }

            //задание 7
            Console.WriteLine("enter the range:");
            int ot = int.Parse(Console.ReadLine());
            int do1 = int.Parse(Console.ReadLine());
            if (ot > do1)
            {
                int num = do1;
                do1 = ot;
                ot = num;
                for (int i = ot; i < do1; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i.ToString());
                    }
                }
            }
            else if (ot == do1) {
                Console.WriteLine("enter the range:");
                ot = int.Parse(Console.ReadLine());
                do1 = int.Parse(Console.ReadLine());
                for (int i = ot; i < do1; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i.ToString());
                    }
                }
            }
            else {
                for (int i = ot; i < do1; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i.ToString());
                    }
                }
            }

        }
    }
}
