using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }



        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen lapiz = new Pen(Color.Blue);
            e.Graphics.DrawLine(lapiz, 0,0, pictureBox1.Width, pictureBox1.Height);
            Pen lapiz2 = new Pen(Color.Red);
            e.Graphics.DrawLine(lapiz, 0,pictureBox1.Height,pictureBox1.Width,0);
            Pen lapiz3 = new Pen(Color.DarkCyan);
            e.Graphics.DrawLine(lapiz, 0, pictureBox1.Height / 2, pictureBox1.Width, pictureBox1.Width);


        }


    }
}
