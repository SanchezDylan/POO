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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void practicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 vent = new Form2();
            vent.ShowDialog();
        }

        private void practica3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 ventan = new Form4();
            ventan.ShowDialog();
        }

        private void practica2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 venta = new Form3();
            venta.ShowDialog();
        }

        private void practica6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 forma = new Form5();
            forma.ShowDialog();
        }

        private void practica7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 forma = new Form6();
            forma.ShowDialog();
        }
    }
}
