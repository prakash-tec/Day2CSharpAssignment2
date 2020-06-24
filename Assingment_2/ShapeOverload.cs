using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_2
{
    public class ShapeOverload
    {
        public const double pI = 3.14;
       public void calculateArea(float x)
        {
            Console.WriteLine("Area of the square: " + x * x + " sq units");
        }
      public void calculateArea(float x, float y)
        {
            Console.WriteLine("Area of the rectangle: " + x * y + " sq units");
        }
       public void calculateArea(double r)
        {
            double area = pI * r * r;
            Console.WriteLine("Area of the circle: " + area + " sq units");
        }
    }
    public class ShapeOverload_Test
    {
        static void Main()
        {
            ShapeOverload shapeOverload = new ShapeOverload();
            shapeOverload.calculateArea(6.1f);
            shapeOverload.calculateArea(10, 22);
            shapeOverload.calculateArea(5.1);
            Console.ReadKey();
        }
    }
}
