using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sha
{
    class Triangle : MyShape
    {

        public Triangle(string Type, int X, int Y) : base ( Type, X, Y)
        {

        }
        public override void Draw(Graphics g)
        {
            base.Draw(g);
            using(Pen selpen = new Pen(Color.Beige))
            {
                g.DrawRectangle(selpen, X, Y, 30, 70);
            }
        }
    }
}
