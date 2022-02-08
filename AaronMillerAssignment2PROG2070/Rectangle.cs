using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AaronMillerAssignment2PROG2070
{
    public class Rectangle
    {
        private int Length;
        private int Width;

        public Rectangle ()
        {
            Length = 1;
            Width = 1;
        }

        public Rectangle (int length, int width)
        {
            Length = length;
            Width = width;
        }

        public int GetLength()
        {
            return this.Length;
        }  
        public int SetLength(int length)
        {
            this.Length = length;
            return length;
        }
        public int GetWidth()
        {
            return this.Width;
        }
        public int SetWidth(int width)
        {
            this.Width = width;
            return Length;
        }  
        public int GetPerimeter()
        {
            int perimeter = (this.Width * 2) + (this.Length * 2);
            return perimeter;
        }
        public int GetArea()
        {
            int area = this.Width * this.Length;
            return area;
        }

    }
}
