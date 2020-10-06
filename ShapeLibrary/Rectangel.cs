﻿using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ShapeLibrary
{
    public class Rectangel : Shape2D
    {

        private float _width;
        private Vector3 _center;
        private Vector2 _size;
        public bool isSquare 
        {
            get 
            {
                if( _size.X == _size.Y)
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

        // con rec
        public Rectangel(Vector3 center,  Vector2 size)
        {
            _center = center;            
            _size = new Vector2(size.X, size.Y);
            
        }


        // con square
        public Rectangel(Vector3 center, float width)
        {
            _center = center;
            _width = width;
            _size.X = width;
            _size.Y = _size.X;

        }


        public override float omkrets
        {
            get
            {
                if(isSquare == true)
                {
                    return _width * 4 ;
                }
                else
                {
                    return (_size.X * 2) + (_size.Y * 2);
                }
               
            }
        }


        public override float area
        {
            get
            {
                return _size.X * _size.Y;
            }
        }

        public override string ToString()
        {
            if(isSquare == true)
            {
                return $"Square@({_center.X:0.0}, {_center.Y:0.0}) W= {_size.X:0.0}  H= {_size.Y:0.0} A ={area}";
            }
            else 
            {
                return $"Rectangle@({_center.X:0.0}, {_center.Y:0.0}) W= {_size.X:0.0}  H= {_size.Y:0.0} A= {area}";
            }          

        }






    }

   
}
