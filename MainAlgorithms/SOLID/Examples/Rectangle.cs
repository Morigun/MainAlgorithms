using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAlgorithms.SOLID.Examples
{
    public class Rectangle
    {
        protected int _width;

        public virtual int Width
        {
            get { return _width; }
            set { _width = value; }
        }
        protected int _height;

        public virtual int Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public int Perimetr()
        {
            return 2 * Height + 2 * Width;
        }
    }
}
