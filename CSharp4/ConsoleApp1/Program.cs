using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
           
            double[] num = new double[3]; 
            var rand = new Random();
            for (int coun = 0; coun < num.GetLength(0); coun++)
            {
                num[coun] = rand.Next(0, 11);
                Console.Write("  ");
                Console.Write(num[coun]);
            }

            Console.ReadLine();
            



            //2
         
           Console.WriteLine("Введите кол-во элементов:         /3 лемента/ числа/5/10/21");
           int n = int.Parse(Console.ReadLine());
           int[] a = new int[n];
           for (int i = 0; i < n; i++)
           {
               Console.WriteLine("Введите {0}-й элемент", i + 1);
               a[i] = int.Parse(Console.ReadLine());

           }
           Console.WriteLine();
           for (int i = 0; i < n; i++)
           {
               Console.WriteLine(a[i] + " ");
           }

           Console.ReadLine();
          


            //3
            
            int centimeter = 345, hundred = centimeter / 100;
            Console.Write(hundred + " метра");
            Console.ReadLine();



            //4

            int day = 234;
            int weeks = day / 7;
            Console.Write(weeks + " недели");
            Console.ReadLine();



            //5
            Console.WriteLine("Введите двузначное число");
           int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Число десятков: " + (number / 10));
            Console.WriteLine("Число едениц: " + (number % 10));
            Console.WriteLine("Сумма чисел: " + ((number / 10) + (number % 10)));
            Console.WriteLine("Произведение цифр: " + ((number / 10) * (number % 10)));
            Console.ReadLine();

            //6

            bool A = true;
             bool B = false;
             bool C = false;
             Console.WriteLine(A || B);
             Console.WriteLine(A && B);
             Console.WriteLine(B || C);
             Console.ReadLine();
            


            //7
           
            Console.Write("Введите радиус круга: ");
            int rad = int.Parse(Console.ReadLine());
            double s1 =  Math.PI * rad * rad;
            Console.Write("Введите сторону квадрата: ");
            int side = int.Parse(Console.ReadLine());
            double rad2 = side * side;
            if (rad > rad2)
            {
                Console.WriteLine("Площадь круга больше");
            }
            else
            {
                Console.WriteLine("Площадь квадрата больше");
            }
            Console.ReadLine();
           


            //8
            
           
            Console.Write("Введите массу 1 предмета: ");
            int massOne = int.Parse(Console.ReadLine());
            Console.Write("Введите массу 2 предмета: ");
            int massTwo = int.Parse(Console.ReadLine());
            Console.Write("Введите объем 1 предмета: ");
            int volumeOne = int.Parse(Console.ReadLine());
            Console.Write("Введите объем 2 предмета: ");
            int volumeTwo = int.Parse(Console.ReadLine());

            int densityOne = massOne / volumeOne, densityTwo= volumeOne / volumeTwo;

            if (densityOne > densityTwo)
            {
                Console.WriteLine("плотность 1 предмета больше");
            }
            else if (densityOne < densityTwo)
            {
                Console.WriteLine("плотность 2 предмета больше");
            }
            else
            {
                Console.WriteLine("плотность 2-х предметов равна");
            }
            Console.ReadLine();
          


            //9
            
            double i1, i2;
            Console.WriteLine("Напряжение u1 и u2 = ");
            double u1 = double.Parse(Console.ReadLine());
            double u2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Сопротивление r1 и r2 = ");
            double r1 = double.Parse(Console.ReadLine());
            double r2 = double.Parse(Console.ReadLine());
            i1 = u1 / r1;
            i2 = u2 / r2;

            if (i1 > i2)
            {
                Console.WriteLine("Сила тока больше в первой цепи");
            }
            else 
            {
                Console.WriteLine("Сила тока больше во второй цепи");
            }
            Console.ReadLine();
            


            //10
            
       
            for (int i = 20; i < 35; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();


            Console.WriteLine("Введите первое число: ");
            int numberOne = int.Parse(Console.ReadLine());
            for (int i = 10; i < numberOne; i++)
            {
                Console.WriteLine((i) * (i));          
            }
            Console.WriteLine();


            Console.WriteLine("Введите второе число: ");
            int numberTwo = int.Parse(Console.ReadLine());
            for (int i = numberTwo; i < 50; i++)
            {
                Console.WriteLine((i) * (i) * (i));
            }

            Console.WriteLine("Введите третье число: ");
            int numberThree = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите четвертое число: ");
            int numberFour = int.Parse(Console.ReadLine());
            if (numberThree < numberFour)
            {
                while(numberThree<numberFour)
                {
                    numberThree++;
                    Console.WriteLine(numberThree);
                }
            }
            else while(numberFour< numberThree)
                {
                    numberFour++;
                    Console.WriteLine(numberFour);
                }
            Console.ReadLine();
        }
    }
}
