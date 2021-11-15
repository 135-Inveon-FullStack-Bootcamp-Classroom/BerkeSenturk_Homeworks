using System;

namespace structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.ShortEdge = 3;
            rectangle.LongEdge = 4;

            Console.WriteLine("class area calc :{0}", rectangle.Area());

            Rectangle_Struct rectangle_struct = new Rectangle_Struct(3,4);
            rectangle_struct.ShortEdge = 3;
            rectangle_struct.LongEdge = 4;

            Console.WriteLine("struct area calc :{0}", rectangle_struct.Area());

        }
    }

    class Rectangle
    {
        public int ShortEdge;
        public int LongEdge;

        public long Area()
        {
            return this.ShortEdge * this.LongEdge;
        }

    }
    struct Rectangle_Struct
    {
        public int ShortEdge;
        public int LongEdge;
    
        public Rectangle_Struct(int shortEdge, int longEdge)
        {
            LongEdge = longEdge;
            ShortEdge = shortEdge;
        }

        public long Area()
        {
            return this.ShortEdge * this.LongEdge;
        }
    }
}
