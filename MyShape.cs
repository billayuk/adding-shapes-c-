using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sha
{
    public class MyShape
    {
        string _type;
        int _x;
        int _y;

        public  MyShape(string type, int x, int y)
        {
            _type = type;
            _x = x;
            _y = y;

        }
        public string type
        {
            get
            {
                return _type;
            }
        } 
        public int X
        {
            get
            {
                return _x;
            }
        }
        public int Y
        {
            get
            {
                return _y;
            }
        }

        //public virtual void Draw(System.Drawing.Graphics g)
        //{

        //}
        
    }
}
