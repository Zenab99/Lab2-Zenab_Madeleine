 using System;
using System.Numerics;

namespace ShapeLibrary
{
    public abstract class Shape
    {
        public abstract Vector3 Center { get; }

        public abstract float area { get; }

        public static Random random = new Random();




        public static float Floatrandom() => (float)Math.Round(random.NextDouble() * 10 + 1);

        public static Vector3 Vect3random()
        {
            return new Vector3(Floatrandom(), Floatrandom(), Floatrandom());
        }

        public static Vector2 Vect2random()
        {
            return new Vector2(Floatrandom(), Floatrandom());
        }

      

        public static Shape GenerateShape()
         {
            
             float r = random.Next(0, 7);
            float f = (float)(random.NextDouble() * 10f + 1f);
            //Vector3 vect3ran() => new Vector3(Floatrandom(), Floatrandom(), Floatrandom());


            switch (r)
             {
                 case 0:
                     return new Circle(new Vector3( Vect2random(), 0), Floatrandom());
                case 1:
                    return new Rectangel(new Vector3(Vect2random(), 0), Vect2random());
                  case 2:
                    return new Rectangel(new Vector3(Vect2random(), 0), Floatrandom()); // Square
                case 3:
                   return new Triangle(new Vector3(Vect2random(), 0), Vect2random(), Vect2random(), Vect2random());
                 case 4:
                     return new Cuboid(Vect3random(), Floatrandom()); //Cube
                 case 5:
                     return new Cuboid(Vect3random(), Vect3random());
                case 6:                
                  return new Sphere(Vect3random(), Floatrandom());
                default:
                    return null;

            }
        }
        
        
    }
}
