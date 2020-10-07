using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using System.IO;

namespace ShapeLibrary
{
    public class Sphere  : Shape3D
    {
        private Vector3 _center;
        public float _radius;
        public override Vector3 Center
        {
            get
            {
                return _center;
            }
        }

        public Sphere(Vector3 center, float radius)
        {
            _center = new Vector3(center.X, center.Y, center.Z);
            _radius = radius;            
           
        }

        public override float volume
        {
            get
            {
              return (float)(4 * Math.PI) * (float)Math.Pow(_radius, 3) / 3;

            }
        }

        public override float area
        {
            get
            {
                return (float)(4 * Math.PI) * (float)Math.Pow(_radius, 2);

            }
        }

        public override string ToString()
        {
            return $"Sphere @({_center.X:0.0}, {_center.Y:0.0}, {_center.Z:0.0}): r= {_radius:0.0}";
        }


    }
}
