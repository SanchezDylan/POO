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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombre = textBox1.Text;
            label2.Text="Bienvenido: "+nombre;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String cadena1 = textBox2.Text;
            String cadena2 = textBox3.Text;
            label5.Text= "Cadena1+cadena2: " + cadena1 + "  " + cadena2;
            label6.Text= "Cadena2+cadena1: " + cadena2 + "  " + cadena1;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Dylan Job";
            textBox2.Text = "Dylan";
            textBox3.Text = "Sanchez";
            comboBox1.Text = comboBox1.Items[new Random().Next(0,4)].ToString();
            comboBox2.Text = comboBox2.Items[new Random().Next(0,5)].ToString();
            radioButton1.Checked = true;
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox4.Checked = true;
            numericUpDown1.Value = 2003;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            numericUpDown1.Value = 1900;
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.AppendText("Bienvenido "+textBox1.Text);
            richTextBox1.AppendText("\nCadena 1: " + textBox2.Text);
            richTextBox1.AppendText("\nCadena 2: " + textBox3.Text);
            richTextBox1.AppendText("\nCadena 1 + Cadena 2: " + textBox2.Text + textBox3.Text);
            richTextBox1.AppendText("\nCadena 2 + Cadena 1: " + textBox3.Text + textBox2.Text);
            richTextBox1.AppendText("\nFecha seleccionada: "+dateTimePicker1.Value.ToString());
            richTextBox1.AppendText("\nTu año de nacimiento es: " + numericUpDown1.Value);
            richTextBox1.AppendText("\nTu comida favorita es: " + comboBox1.Text);
            richTextBox1.AppendText("\nTu genero de videojuego favorito es: " + comboBox2.Text);
            if (radioButton1.Checked)
            {
                richTextBox1.AppendText("\nTe gusta programar: si");
            }
            if (radioButton2.Checked)
            {
                richTextBox1.AppendText("\nTe gusta programar: no");
            }
            if (radioButton3.Checked)
            {
                richTextBox1.AppendText("\nTe gusta programar: A veces");
            }
            richTextBox1.AppendText("\nTus materias favoritas son: ");
            if (checkBox1.Checked)
            {
                richTextBox1.AppendText("\n matematicas");
            }
            if (checkBox2.Checked)
            {
                richTextBox1.AppendText( "\nMetodologia");
            }
            if (checkBox3.Checked)
            {
                richTextBox1.AppendText(" \nFSC");
            }
            if (checkBox4.Checked)
            {
                richTextBox1.AppendText(" \nPOO");
            }
            if (checkBox5.Checked)
            {
                richTextBox1.AppendText("\nTodas");
            }
      
        }
    }
}
