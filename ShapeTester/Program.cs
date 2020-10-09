using System;
using System.Drawing;
using System.Numerics;
using ShapeLibrary;
using System.IO;
using System.Collections.Generic;

namespace ShapeTester
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Shape> form = new List<Shape>();
            float area = 0;
            float circumference = 0;
            float volume = 0;
            float objekt = 0;           
           

             for (int i = 0; i < 20; i++)
             {
                 form.Add(Shape.GenerateShape());
             }

            foreach (var shape in form)
            {
                Console.WriteLine(shape);
                area += shape.area;
                if (shape is Triangle)
                {
                    circumference += (shape as Triangle).Circumference;
                }

                if (shape is Shape3D)
                {

                    if (volume <= (shape as Shape3D).volume)
                    {
                        volume = (shape as Shape3D).volume;
                    }
                   
                }


            }
            for (int i = 0; i < form.Count; i++)
            {
                if ((form[i] as Shape3D)?.volume == volume)
                {
                    objekt = i;
                    
                }
            }



            Console.WriteLine("\n"+ $"Genomsnittet av area i listan är {area / form.Count:0.0}");
            Console.WriteLine($"Den totala omkretsen för alla Trianglar är {circumference:0.0}");
            Console.WriteLine($"Största objektet är {objekt} med volymen {volume:0.0}"); //("Den ränkar från 0, det vill säga första objektet ränkar som 0 sen upp.")



        }





    }

}
