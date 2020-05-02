using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace test
{
    public class Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int x { get; set; }
        public int y { get; set; }

        public void Draw()
        {

        }
    }
    public class Text: Shape
    {
        public int FontSize { get; set; }
        public int FontName { get; set; }

    }
    class Program
    {

        public static void Main()
        {
            Text text = new Text();
            Shape shape = text;


            text.Width = 200;
            shape.Width = 100;// overwrites the value of text.wdth
            Console.WriteLine(text.Width);

            // StreamReader reader = new StreamReader(new MemoryStream());
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("lol");
            list.Add(new Text());
            // down cast
            Shape shap = new Text();
            // in shap. attributes of text are available

            Text textt = (Text)shap;
            // in textt. every property is available

            Console.ReadLine();
        }


    }

}
