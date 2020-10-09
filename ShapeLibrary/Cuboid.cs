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
        private Vector3 _Size { get; }
        public bool isCube
        {
            get
            {
                if (_Size.X == _Size.Y && _Size.X == _Size.Z)
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



        //Cube Constructor
        public Cuboid(Vector3 center, float width) 
        {
            _center = center;
            _Size = new Vector3(width, width, width);            
           
        }

        // Cuboid Constructor
        public Cuboid(Vector3 center, Vector3 size) 
        { 
           _center = center;
            _Size = size;           

        }


        public override float volume
        {
            get
            {                
                 return (_Size.X * _Size.Y) *_Size.Z;            

            }
        }

        public override float area
        {
            get
            {
                return 2F * (_Size.X * _Size.Y + _Size.Y * _Size.Z + _Size.Z * _Size.X);
            }
        }

        public override string ToString()
        {
            if (isCube == true)
            {
                return $"Cube @({_center.X:0.0}, {_center.Y:0.0}, {_center.Z:0.0}): w = {_Size.X:0.00}, h = {_Size.Y:0.00}, l = {_Size.Z:0.00}";
            }
            else
            {
                return $"Cuboid @({_center.X:0.0}, {_center.Y:0.0}, {_center.Z:0.0}):w = {_Size.X:0.00}, h = {_Size.Y:0.00}, l = {_Size.Z:0.00} ";
            }
        }
    }
       
}
