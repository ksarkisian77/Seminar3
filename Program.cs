/*class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Таблица кубов чисел от 1 до " + N + ":");
        for (int i = 1; i <= N; i++)
        {
            int cube = i * i * i;
            Console.WriteLine($"{i}^3 = {cube}");
        }
        Console.ReadLine();
    }
}
*/
/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите координаты точки A:");
        Console.Write("x1: ");
        double x1 =  Convert.ToInt32(Console.ReadLine());
        Console.Write("y1: ");
        double y1 =  Convert.ToInt32(Console.ReadLine());
        Console.Write("z1: ");
        double z1 =  Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите координаты точки B:");
        Console.Write("x2: ");
        double x2 =  Convert.ToInt32(Console.ReadLine());
        Console.Write("y2: ");
        double y2 =  Convert.ToInt32(Console.ReadLine());
        Console.Write("z2: ");
        double z2 =  Convert.ToInt32(Console.ReadLine());

        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

        Console.WriteLine("Расстояние между точкой A и точкой B: " + distance.ToString("F2"));

        Console.ReadLine();
    }
}
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите пятизначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsPalindrome(number))
        {
            Console.WriteLine("Да, это палиндром");
        }
        else
        {
            Console.WriteLine("Нет, это не палиндром");
        }
    }

    static bool IsPalindrome(int number)
    {
        string strNumber = number.ToString();
        int length = strNumber.Length;

        for (int i = 0; i < length / 2; i++)
        {
            if (strNumber[i] != strNumber[length - i - 1])
            {
                return false;
            }
        }

        return true;
    }
}




