 using System;
using System.Numerics;

namespace ShapeLibrary
{
    public abstract class Shape
    {
        public abstract Vector3 Center { get; }
        public abstract Vector2 Center2 { get; }
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

        private static Triangle TC(Vector2 p1, Vector2 p2)
        {
            var CP = Vect2random();
            var p3X = CP.X * 3 - p1.X - p2.X;
            var p3Y = CP.Y * 3 - p1.Y - p2.Y;
            var p3 = new Vector2(p3X, p3Y);
            var triangle = new Triangle(p1, p2, p3);
            return triangle;
        }




        public static Shape GenerateShape(Vector3 center)
        {

            Vector2 c = new Vector2(center.X, center.Y);

            switch (random.Next(0, 7))
            {
                case 0:
                    return new Circle((c), Floatrandom());
                case 1:
                    return new Rectangle((c), Vect2random());
                case 2:
                    return new Rectangle((c), Floatrandom()); // Square
                case 3:
                    Vector2 p1 = Vect2random();
                    Vector2 p2 = Vect2random();
                    float p3X = (3 * center.X) - p1.X - p2.X;
                    float p3Y = (3 * center.Y) - p1.Y - p2.Y;
                    Vector2 p3 = new Vector2(p3X, p3Y);
                     return new Triangle(p1, p2, p3);                   
                case 4:
                    return new Cuboid(center, Floatrandom()); //Cube
                case 5:
                    return new Cuboid(center, Vect3random());
                case 6:
                    return new Sphere(center, Floatrandom());
                default:
                    return null;

            }
        }




        public static Shape GenerateShape()
         {

           
            float f = (float)(random.NextDouble() * 10f + 1f);


            switch (random.Next(0, 7))
            {
                 case 0:
                     return new Circle((Vect2random()), Floatrandom());
                case 1:
                    return new Rectangle((Vect2random()), Vect2random());
                  case 2:
                    return new Rectangle((Vect2random()), Floatrandom()); // Square
                case 3:
                   return new Triangle(Vect2random(), Vect2random(), Vect2random());
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
