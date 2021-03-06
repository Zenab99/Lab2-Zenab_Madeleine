﻿using System;
using System.Drawing;
using System.Numerics;
using ShapeLibrary;
using System.IO;
using System.Collections.Generic;
using System.Linq;

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

            

           /* vvv  Test för att se om centerpoint i generate shape vvv
            Shape testObjekt = Shape.GenerateShape(new Vector3(1.2f, 0.4f, 3.3f));
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"X : {testObjekt.Center.X} Y : {testObjekt.Center.Y}");
            Console.ResetColor(); */


            Shape Biggestobjekt = Shape.GenerateShape();


            for (int i = 0; i < 20; i++)
             {
                 form.Add(Shape.GenerateShape());
             }

           Console.WriteLine("Generate random shapes");

            foreach (var shape in form)
            {
               
               Console.WriteLine($"{shape}");
                area += shape.area;
                if (shape is Triangle)
                {
                    circumference += (shape as Triangle).Circumference;
                }

                if (shape is Shape3D shape3D && volume <= (shape as Shape3D).volume)
                {
                        volume = (shape as Shape3D).volume;
                    Biggestobjekt = shape3D;    
                }


            }        
            Console.WriteLine("\n"+ $"Genomsnittet av area i listan är {area / form.Count:0.0}");
            Console.WriteLine($"Den totala omkretsen för alla Trianglar är {circumference:0.0}");
            Console.WriteLine($"Största objektet är [{Biggestobjekt}] med volymen {volume:0.0}"); 



        }





    }

}
