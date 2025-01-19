using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass05
{
    interface IShape
    {
    double Area { get; }
    void DisplayShapeInfo();
    }

    interface ICircle : IShape
    {
        double Radius { get; set; }
    }

    interface IRectangle : IShape
    {
        double Width { get; set; }
        double Height { get; set; }
    }

    class Circle : ICircle
    {
        public double Radius { get; set; }
        public double Area => Math.PI * Radius * Radius;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle: Radius = {Radius}, Area = {Area:F2}");
        }
    }

    class Rectangle : IRectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area => Width * Height;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle: Width = {Width}, Height = {Height}, Area = {Area}");
        }
    }

}
