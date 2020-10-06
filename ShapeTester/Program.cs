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

            float area = 0;
            float omkrets = 0;
            float volume = 0;
            float objekt = 0;


            List<Shape> form = new List<Shape>();

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
                    omkrets += (shape as Triangle).omkrets;
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
             Console.WriteLine($"Den totala omkretsen för alla Trianglar är {omkrets:0.0}");
            Console.WriteLine($"Största objektet är  {objekt} med volymen {volume:0.0}");



        }





    }

}
