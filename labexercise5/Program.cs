using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labexercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            ArrayList num = new ArrayList();

            //num[0] = "";
            //num[1] = "";
            //num[2] = "";
            //num[3] = "";
            //num[4] = "";


            // ArrayList before sorting
            //Console.WriteLine("ArrayList before sort:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter the num{i}:");
                num.Add(Console.ReadLine());
                //num[i] = Console.ReadLine();
                //Console.WriteLine("Enter the num2:");
                //num[1] = Console.ReadLine();
                //Console.WriteLine("Enter the num3:");
                //num[2] = Console.ReadLine();
                //Console.WriteLine("Enter the num4:");
                //num[3] = Console.ReadLine();
                //Console.WriteLine("Enter the num5:");
                //num[4] = Console.ReadLine();

            }
            //Console.ReadLine();



            //Console.WriteLine("ArrayList after sort:");


            //num.Sort();

            // ArrayList after sort
            foreach (object i in num)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }



}
   