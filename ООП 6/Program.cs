using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_6
{
    //задание 1
    class Class1
    {
        public int numb1;
        public int numb2;
        public Class1()
        {

        }
        public Class1(int number)
        {
            numb1 = number;
        }
        public Class1(int number, int number2)
        {
            numb1 = number;
            numb2 = number2;
        }
        public void Print()
        {
            Console.WriteLine(numb1 + " " + numb2);
        }
    }
    
    //задание 2
    class Class2
    {
        private string line = "Пусто";
        public void Write()
        {

        }
        public void Write(string line2)
        {
            if (line2.Length > 10) line = "Слишком длинная строка";
            else line = line2;
        }
        public void Print()
        {
            Console.WriteLine(line);
        }
    }
     
    //задание 3
    class Class3
    {
        public double a;
        public double b;
        public double c;
        public Class3(int line1, int line2, int line3)
        {
            a = line1; b = line2; c = line3;
            if ((a + b > c) && (b + c > a) && (c + a > b))
                Console.WriteLine("Треугольник возможен");
            else
                Console.WriteLine("Треугольник не возможен");

            double A = (Math.Acos((Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c))) * (180 / Math.PI);
            double B = (Math.Acos((Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c))) * (180 / Math.PI);
            double C = (Math.Acos((Math.Pow(b, 2) + Math.Pow(a, 2) - Math.Pow(c, 2)) / (2 * b * a))) * (180 / Math.PI);

            Console.WriteLine("Угол A = {0:0.000}", A);
            Console.WriteLine("Угол B = {0:0.000}", B);
            Console.WriteLine("Угол C = {0:0.000}", C);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("ЗАДАНИЕ 1");
            Console.WriteLine("");

            Class1 argument = new Class1();
            argument.Print();
            Class1 argument1 = new Class1(137);
            argument1.Print();
            Class1 argument2 = new Class1(288, 300);
            argument2.Print();

            Console.WriteLine("");
            Console.WriteLine("ЗАДАНИЕ 2");
            Console.WriteLine("");

            Class2 text1 = new Class2();
            Class2 text2 = new Class2();
            Class2 text3 = new Class2();
            text1.Write();
            text1.Print();
            text2.Write("Привет!");
            text2.Print();
            text3.Write("Привет друг, как дела?");
            text3.Print();

            Console.WriteLine("");
            Console.WriteLine("ЗАДАНИЕ 3");
            Console.WriteLine("");

            Class3 triangle = new Class3(27, 5, 8);
            Console.WriteLine("");
            Class3 triangle2 = new Class3(9, 8, 7);

            Console.ReadKey();
        }
    }
}
