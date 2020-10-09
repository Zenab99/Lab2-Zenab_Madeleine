using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ShapeLibrary
{
    public abstract class Shape3D : Shape
    {
        public override Vector3 Center => throw new NotImplementedException();
        public override Vector2 Center2 => throw new NotImplementedException();

        public abstract float volume { get; }

        public override float area { get;  }


    }
}
