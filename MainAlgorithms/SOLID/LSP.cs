using MainAlgorithms.SOLID.Examples;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainAlgorithms.SOLID
{
    public class RectangleTest
    {
        public int Perimetr(int width, int height)
        {
            Rectangle rectangle = InitRectangle();
            rectangle.Width = width;
            rectangle.Height = height;

            return rectangle.Perimetr();
        }
        public virtual Rectangle InitRectangle()
        {
            return new Rectangle();
        }
    }
    public class SquadTest : RectangleTest
    {
        public override Rectangle InitRectangle()
        {
            return new Squad();
        }
    }
    public class LSP
    {
        //Я не буду описывать тут какую-то логику, я просто разберу примеры,
        //которые показывают нарушение принципа подстановки Барбары Лисков

        //Первый пример это Rectangle и Squad, базовый и дочерний класс, в дочернем переопределена логика полей Width и Height

    }
}
