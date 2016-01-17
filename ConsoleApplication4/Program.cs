using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    interface ISquareCalculatable
    {
        double Area();
    }

    class Rectangle : ISquareCalculatable
    {
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            string template = "width:{0} height:{1} area:{2}";
            return string.Format(template, width.ToString(), height, Area());
        }

        private double height;
        private double width;

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("negative or zero value is passed");
                }

                width = value;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("negative or zero value is passed");
                }

                height = value;
            }
        }

        public double Area()
        {
            return height * width;
        }
    }

    //class Square : IComparable
    //{
    //    public double Area()
    //    {
    //        return base.
    //    }

    //    public int CompareTo(object obj)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Rectangle r = new Rectangle();
                r.Height = 10;
                r.Width = 10;
                Console.WriteLine(r.Area());
                Console.WriteLine(r.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
