
namespace _9_RectangleIntersection
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Rectangle
    {
        private string id;
        private double width;
        private double height;
        private double topLeftX;
        private double topLeftY;

        public Rectangle(string id, double width, double height, double topLeftX, double topLeftY)
        {
            this.id = id;
            this.width = width;
            this.height = height;
            this.topLeftX = topLeftX;
            this.topLeftY = topLeftY;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;

            }
        }

        public double TopLeftX
        {
            get
            {
                return this.topLeftX;
            }
            set
            {
                this.topLeftX = value;
            }
        }

        public double TopLeftY
        {
            get
            {
                return this.topLeftY;
            }
            set
            {
                this.topLeftY = value;
            }
        }

        static bool AreIntersected(Rectangle r1, Rectangle r2)
        {
            Queue<Tuple<double, double>> r2Edges = new Queue<Tuple<double, double>>();
            r2Edges.Enqueue(new Tuple<double, double>(r2.TopLeftX, r2.TopLeftY));
            r2Edges.Enqueue(new Tuple<double, double>(r2.TopLeftX + r2.Width, r2.TopLeftY));
            r2Edges.Enqueue(new Tuple<double, double>(r2.TopLeftX, r2.TopLeftY + r2.Height));
            r2Edges.Enqueue(new Tuple<double, double>(r2.TopLeftX + r2.Width, r2.TopLeftY + r2.Height));

            while (r2Edges.Count > 0)
            {
                var currentPoint = r2Edges.Dequeue();
                if (currentPoint.Item1 >= r1.TopLeftX && currentPoint.Item1 <= r1.TopLeftX + r1.Width &&
                currentPoint.Item2 >= r1.TopLeftY && currentPoint.Item2 <= r1.TopLeftY + r1.Height)
                {
                    return true;
                }
            }
            return false;
        }
      public bool AreIntersected(Rectangle r)
        {
            Queue<Tuple<double, double>> edges = new Queue<Tuple<double, double>>();
            edges.Enqueue(new Tuple<double, double>(this.TopLeftX, this.TopLeftY));
            edges.Enqueue(new Tuple<double, double>(this.TopLeftX + this.Width, this.TopLeftY));
            edges.Enqueue(new Tuple<double, double>(this.TopLeftX, this.TopLeftY + this.Height));
            edges.Enqueue(new Tuple<double, double>(this.TopLeftX + this.Width, this.TopLeftY + this.Height));

            while (edges.Count > 0)
            {
                var currentPoint = edges.Dequeue();
                if (currentPoint.Item1 >= r.TopLeftX && currentPoint.Item1 <= r.TopLeftX + r.Width &&
                currentPoint.Item2 >= r.TopLeftY && currentPoint.Item2 <= r.TopLeftY + r.Height)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
