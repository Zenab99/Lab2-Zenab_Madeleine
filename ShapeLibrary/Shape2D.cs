using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ShapeLibrary
{
    public abstract class Shape2D : Shape
    {

        public abstract float omkrets { get; }

        public override Vector3 Center => throw new NotImplementedException();

        public override float area => throw new NotImplementedException();




    }
}
