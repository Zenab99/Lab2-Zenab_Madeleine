using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using System.Drawing;

namespace ShapeLibrary
{
    public class Cuboid : Shape3D
    {
        
        private Vector3 _center { get; }
        public float _width;
        public float _height;
        public float _length;
        private Vector3 _Size { get; }
        public bool isCube
        {
            get
            {
                if ((_width == _height || _height == _length))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public override Vector3 Center
        {
            get
            {
                return _center;
            }
        }

        //Cube Con
        public Cuboid(Vector3 center, float width) 
        {
            _center = center;
            _width = width;
            _length = width;
            _height = width;       
           
        }

        // Cuboid Con
        public Cuboid(Vector3 center, Vector3 size) 
        { 
           _center = center;
            _Size = new Vector3(size.X, size.Y, size.Z);
            _width = size.X;
            _length = size.Y;
            _height = size.Z;

        }


        public override float volume
        {
            get
            {
                if (isCube == true)
                {
                    return (_width * _width) * _width; 
                }
                else
                {
                    return (_Size.X * _Size.Y) *_Size.Z;
                }

            }
        }




        public override float area
        {
            get
            {
                if (isCube == true)
                {
                    return 6f * _width;
                }
                else
                {
                    return 2f * (_height * _length) + (_length * _width) + (_width * _height);
                }
            }
        }

        public override string ToString()
        {
            if (isCube == true)
            {
                return $"Cube @({_center.X:0.0}, {_center.Y:0.0}, {_center.Z:0.0}): W= ({_width:0.0}) H= ({_height:0.0}) L= ({_length:0.0})";
            }
            else
            {
                return $"Cuboid @({_center.X:0.0}, {_center.Y:0.0}, {_center.Z:0.0}): W = ({_width:0.0}) H = ({_height:0.0}) L = ({_length:0.0}) ";
            }
        }
    }
       
}
