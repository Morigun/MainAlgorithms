using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAlgorithms.SOLID.Examples
{
    public class Squad : Rectangle
    {
        public override int Width
        {
            get { return _width; }
            set { 
                _width = value; 
                _height = value; 
            }
        }
        public override int Height
        {
            get { return _height; }
            set 
            { 
                _height = value;
                _width = value;
            }
        }

    }
}
