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
    public partial class Form6 : Form
    {
        //Declaramos las variables de clase
        bool control = false; 
        String codigo = "";
        int espera = 0;
        String[,] productos =
            
        {
            //Primera columna codigo del producto, nombre del producto, precio del producto
            {"123","Jabon"          ,"10.00", @"C:\Users\Dylan\Desktop\POO\Sistema\Sistema\obj\123.jpg" },
            {"321","Botella de agua","12.00", @"C:\Users\Dylan\Desktop\POO\Sistema\Sistema\obj\321.jpg" },
            {"456","Toalla"         ,"20.00", @"C:\Users\Dylan\Desktop\POO\Sistema\Sistema\obj\456.jpg" },
            {"654","Gomitas"        ,"5.00" , @"C:\Users\Dylan\Desktop\POO\Sistema\Sistema\obj\654.jpg" },
            {"789","Pan"            ,"3.00" , @"C:\Users\Dylan\Desktop\POO\Sistema\Sistema\obj\789.jpg" },
            {"987","Detergente"     ,"15.00", @"C:\Users\Dylan\Desktop\POO\Sistema\Sistema\obj\987.jpg" },
            {"111","Refresco"       ,"8.00" , @"C:\Users\Dylan\Desktop\POO\Sistema\Sistema\obj\111.jpg" },
            {"222","Audifonos"      ,"25.00", @"C:\Users\Dylan\Desktop\POO\Sistema\Sistema\obj\222.png" },
            {"333","Camiseta"       ,"30.00", @"C:\Users\Dylan\Desktop\POO\Sistema\Sistema\obj\333.jpg" },
            {"444","Leche"          ,"21.00", @"C:\Users\Dylan\Desktop\POO\Sistema\Sistema\obj\444.png" },
        };
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label1.Location = new Point(this.Width/2 - label1.Width/2, 0);
            label2.Text = DateTime.Now.ToLongTimeString()+" "+DateTime.Now.ToLongDateString();
            label2.Location = new Point(this.Width / 2 - label2.Width / 2, label2.Height);
            label3.Location = new Point(this.Width - label3.Width, this.Height-label3.Height);
            label4.Location = new Point(this.Width / 2 - label4.Width / 2, this.Height / 2 - label4.Height);
            Location = new Point(this.Width / 2 - label4.Width / 2, this.Height / 2 - label4.Height);
            // MessageBox.Show(this.Width+ " "+ this.Height); //Revisamos la resolucion de la pantalla
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                // MessageBox.Show(codigo);//la variable codigo es igual a cadena vacia
                Buscar();
                codigo = "";

            }
            else
            {
                codigo += e.KeyChar;
            }
        }

        //Declaramos metodo para buscar
        private void Buscar()
        {
            control = false;
            for (int i = 0; i < 10; i++)
            {
                if (codigo==productos[i,0])
                {
                    // MessageBox.Show(productos[i,1]+""+productos[i,2]);
                    label4.Text = productos[i, 1] + "\nprecio: $ " + productos[i, 2];
                    label4.Location = new Point(this.Width/2 - label4.Width/2, this.Height/2-label4.Height/2);
                    pictureBox1.Image = Image.FromFile(productos[i, 3]);
                    control = true;
                    espera = 0;
                    timer1.Enabled = true;
                }
            }
            if (control==false)
            {
                label4.Text=("Hubo error en la busqueda de su producto");
                label4.Location = new Point(this.Width/2-label4.Width/2, this.Height/2-label4.Height/2);
                pictureBox1.Image = null;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            espera++;
            if (espera==3)
            {
                timer1.Enabled = false;
                label4.Text = "Escanear codigo de barras";
                label4.Location = new Point(this.Width / 2 - label4.Width / 2, this.Height / 2 - label4.Height);
                
                pictureBox1.Image = Image.FromFile(@"C:\Users\Dylan\Desktop\POO\Sistema\Sistema\Properties\Imagen-animada-Codigo-de-Barras-01.gif");

            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
        }
    }
}
