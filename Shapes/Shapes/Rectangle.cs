using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle
    {
        public virtual double Height { get; set; }

        public virtual double Width { get; set; }

        public double CalculateArea()
        {
            return this.Height * this.Width;
        }
    }
}
