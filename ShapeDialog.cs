using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sha
{
    public partial class ShapeDialog : Form
    {
        MyShape _shape = null;
        public ShapeDialog()
        {
            InitializeComponent();
        }

        public MyShape Shape
        {
            get
            {
                return _shape;
            }
        }
        private void ShapeDialog_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBoxX.Text);
            int y = int.Parse(textBoxY.Text);

            if (radioButtun_Rectangle.Checked)
            {
                _shape = new MyShape("Rectangle", x, y);
            }
            else if (radioButton_Square.Checked)
            {
                _shape = new MyShape("Square", x, y);
            }
            else if (radioButton_Circle.Checked)
            {
                _shape = new MyShape("Circle", x, y);
            }
            else
            {
                _shape = new MyShape("Triangle", x, y);
            }
            DialogResult = DialogResult.OK;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        { 

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel_Shapes_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
