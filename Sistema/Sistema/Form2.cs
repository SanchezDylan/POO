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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);
                label3.Text = "Resultado: \n" + "Suma= " + (num1 + num2) +
                    "\nResta= " + (num1 - num2) + "\nMultiplicacion=" + 
                    (num1 * num2) + "\nDivision= " + (num1 / num2);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
