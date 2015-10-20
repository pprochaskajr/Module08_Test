using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08_Test
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangle r = new Rectangle();
            Shape s = new Shape();
           
             // This is the call to gt trhe area using an object s of the Shape class
            Console.WriteLine("This is the call to Area to get area  using an object of the Shape class..{0}...", s.Area(4.0, 5.0));
            Console.WriteLine();

            // This is the call to Area (within Shape) using r ( an object instantiation of the Rectangle class ) which inherits Shape

            Console.WriteLine("This is the call to Area (within the Shape class) from r ( an object instantiation of the Rectangle class " + 
                              "which inherits all Shape's characterisitcs) to get the area..{0}...", r.Area(4.0, 5.0));

            Console.ReadKey();
        }
    }

    class Shape
    {

        private double width;
        private double length;

        public Shape()
        {

            // default  constructor
        }

        // Width property

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        // Length property

        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        

        public double Area(double wid, double len)
        {
            return (wid * len);
        }

    }

    // example of Rectangle inheriting the characterisitcs of the class Shape

    class Rectangle : Shape
    {

        public void helloRectangle()
        {
            Console.WriteLine("Hello from Rectangle Class.....");

        }

    }

}
