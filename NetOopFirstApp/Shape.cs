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
    }

    public class Shape
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
        public Shape(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public Shape(Point point)
        {
            this.point = point;
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
    }
}

