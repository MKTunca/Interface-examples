using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculate[] calculates = new ICalculate[2]
            {
                new Triangle(),
                new Square()
            };
            foreach(var cal in calculates)
            {
                cal.CalculateArea(10,5);
            }
            ICircle[] circles = new ICircle[1]
            {
                new Circle()
            };
            foreach(var item in circles)
            {
                item.CalculateArea(2);
            }
            
            Console.ReadLine();
        }
    }
    interface ICalculate
    {
        void CalculateArea(double a,double b);
    }
    interface ICircle
    {
        void CalculateArea(double r);
    }
    class Triangle : ICalculate
    {
        public void CalculateArea(double a, double b)
        {
            double area = a * b / 2;
            Console.WriteLine("Area of this triangle is" + " " + area);
        }
    }
    class Square : ICalculate
    {
        public void CalculateArea(double a, double b)
        {
            double area = a * a;
            Console.WriteLine("Area of this square is" + " " + area);
        }
    }
    class Circle : ICircle
    {
        public void CalculateArea(double r)
        {
            double area = Math.PI * r * r;
            Console.WriteLine("Area of this circle is" + " " + area);
        }
    }
}
