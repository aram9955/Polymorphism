using System;
using System.Collections.Generic;

namespace Polymorphism
{
    public class ShapeManager
    {
        public void ExecuteDraw(List<Shape> shapes)
        {

            for (int i = 0; i < shapes.Count; i++)
            {
                shapes[i].Draw();
            }

        }
    }
}