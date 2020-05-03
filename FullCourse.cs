using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace test
{
   

    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach(var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        

        public virtual void Draw()
        {

        }
       

    }
    
    public class Circle:Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw cirlce");
        }
    }
    public class Rectangle: Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw rectangle");
        }
    }
    class Program
    {

        public static void Main()
        {
            var shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);

            
            Console.ReadLine();
        }


    }

}
