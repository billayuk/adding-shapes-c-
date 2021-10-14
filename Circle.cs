using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sha
{
    class Circle : MyShape
    {
        public Circle(string type, int X, int Y): base(type, X, Y)
        {

        }


        public override void Draw(Graphics g)
        {
            base.Draw(g);
            using( Pen SelPen = new Pen(Color.Blue))
            {
                g.DrawEllipse(SelPen, X, Y, 40,40);
            }
        }


    }
}
