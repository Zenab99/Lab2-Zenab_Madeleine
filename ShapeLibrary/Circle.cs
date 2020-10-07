using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ShapeLibrary
{
   public class Circle : Shape2D
    {
        private float _radius;
        private Vector3 _center;
        public override Vector3 Center
        {
            get
            {
                return _center;
            }
        }


        public Circle(Vector3 center, float radius)
        {
            _center = center;
            _radius = radius;
                       
        }

        public override float omkrets
        {
            get
            {
                return (float)((Math.PI * 2) * _radius);    
            } 
        }

        public override float area
        {
            get
            {
                return (float)(Math.PI  * _radius * _radius);
            }
        }       

        public override string ToString()
        {            
           return $"Cricle@({_center.X:0.0}, {_center.Y:0.0}) R= {_radius:0.0}";
        }  
    }
}

