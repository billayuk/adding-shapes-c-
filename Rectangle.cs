using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sha
{
    class Rectangle: MyShape
    {
        public Rectangle (string type, int X, int Y) : base(type, X, Y)
        {

        }

        public override void Draw(Graphics g)
        {
            
           base.Draw(g);
            using( Pen selPen = new Pen(Color.Red))
            {
               


                g.DrawRectangle(selPen, X, Y, 40, 50);
            }
        }
        
            


        
       
    }
}
