using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1091421_hw7
{
    public partial class Form3 : Form
    {

        float r, g, b, a, r1, g1, b1, a1, r2, g2, b2, a2;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            r = float.Parse(label5.Text);
            g = float.Parse(label6.Text);
            b = float.Parse(label7.Text);
            a = float.Parse(label8.Text);
            Close();
        }



        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            r1 = trackBar1.Value / 10;//個位數
            g1 = trackBar2.Value / 10;
            b1 = trackBar3.Value / 10;
            a1 = trackBar4.Value / 10;
            r2 = trackBar1.Value % 10;//小數點後
            g2 = trackBar2.Value % 10;
            b2 = trackBar3.Value % 10;
            a2 = trackBar4.Value % 10;
            label5.Text = r1.ToString() + "." + r2.ToString();
            label6.Text = g1.ToString() + "." + g2.ToString();
            label7.Text = b1.ToString() + "." + b2.ToString();
            label8.Text = a1.ToString() + "." + a2.ToString();
        }
        public float getR()
        {
            return r;
        }
        public float getG()
        {
            return g;
        }
        public float getB()
        {
            return b;
        }
        public float getA()
        {
            return a;
        }
    }
}
