﻿using System;
using System.Collections.Generic;

namespace Method_Overriding
{
    public class Canvas
    {

        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
