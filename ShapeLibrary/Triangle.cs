using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;


namespace ShapeLibrary
{
    public class Triangle  : Shape2D
    {
        private Vector3 _center;

        public override Vector3 Center
        {
            get
            {
                 Vector3 center = new Vector3((_a.X + _b.X + _c.X) / 3f, (_a.Y + _b.Y + _c.Y) / 3f, 0f);
                return _center;
            }
        }

        private Vector2 _a;
        private Vector2 _b;
        private Vector2 _c;
        
        public float Height { get; }
        public float Width { get; }

       

        public Triangle(Vector3 center, Vector2 a, Vector2 b, Vector2 c)
        {
            _center = center;
            _a = a;
            _b = b;
            _c = c;
           
           
        }

        public override float omkrets
        {
            get
            {
                var p1 = Math.Sqrt(Math.Pow(_b.X - _c.X, 2) + Math.Pow(_b.Y - _c.Y, 2));
                var p2 = Math.Sqrt(Math.Pow(_a.X - _c.X, 2) + Math.Pow(_a.Y - _c.Y, 2));
                var p3 = Math.Sqrt(Math.Pow(_a.X - _b.X, 2) + Math.Pow(_a.Y - _b.Y, 2));
                return (float)(p1 + p2 + p3);
            }
        }

        public override float area // Behövs fixas
        {
            get              
            {
                var p1 = Math.Sqrt(Math.Pow(_b.X - _c.X, 2) + Math.Pow(_b.Y - _c.Y, 2));
                var p2 = Math.Sqrt(Math.Pow(_a.X - _c.X, 2) + Math.Pow(_a.Y - _c.Y, 2));
                var p3 = Math.Sqrt(Math.Pow(_a.X - _b.X, 2) + Math.Pow(_a.Y - _b.Y, 2));
                return (float)((p1 + p2) * (p2 + p3) / 2);                
               
            }
        }

        public override string ToString()
        {
            return $"Triangle @({_center.X:0.0}, {_center.Y:0.0}) p1:({_a.X:0.0}, {_a.Y:0.0}), p2:({_b.X:0.0}, {_b.Y:0.0}), p3:({_c.X:0.0}, {_c.Y:0.0})";
        }







         

  
   


    }
}
