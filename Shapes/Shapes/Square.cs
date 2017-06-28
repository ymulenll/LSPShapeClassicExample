﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : Rectangle
    {
        public override double Height
        {
            get
            {
                return base.Height;
            }
            set
            {
                base.Height = value;
                base.Width = value;
            }
        }

        public override double Width
        {
            get
            {
                return base.Width;
            }
            set
            {
                base.Height = value;
                base.Width = value;
            }
        }
    }
}
