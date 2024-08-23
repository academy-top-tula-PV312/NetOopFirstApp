using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetOopFirstApp
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }

    public abstract class Shape
    {
        Point point;

        public int X
        {
            get { return point.X; }
            set { point.X = value; }
        }

        public int Y
        {
            get { return point.Y; }
            set { point.Y = value; }
        }

        public Point Point
        {
            get { return point; }
            set { point = value; }
        }

        public Shape() { }

        public Shape(Point point) : this(point.X, point.Y) { }

        public Shape(int x, int y) 
        {
            this.point = new Point(x, y);
        }

        public abstract double Square();

        public virtual void Print()
        {
            Console.Write($"x = {X}, y = {Y}");
        }
        
    }

    class Rectangle : Shape
    {
        public int Width { set; get; }
        public int Height { set; get; }

        public Rectangle() { }
        public Rectangle(int x, int y, int width, int height)
            : base(x, y)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double Square()
        {
            return Width * Height;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($", width = {Width}, height = {Height}");
        }
    }

    class Circle : Shape
    {
        public int Radius { set; get; }
        public Circle() { }
        public Circle(int x, int y, int radius)
            : base(x, y)
        {
            this.Radius = radius;
        }

        public override double Square()
        {
            return 3.1416 * Radius * Radius;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($", radius = {Radius}");
        }
    }

    class Ellipse : Circle
    {
        public override void Print()
        {

        }
    }

    class Employee
    {
        public string? Name { set; get; }
        public int Age { set; get; }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }

        public override bool Equals(object? obj)
        {
            if(obj is Employee)
            {
                Employee e = (Employee)obj;
                return this.Name == e.Name && this.Age == e.Age;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return (Name + Age.ToString())!.GetHashCode();
        }
    }

    
}

