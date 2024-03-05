using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L4_JPMA_1063124
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int n = 0;
            int a = 0;
            int b = 1;
            int c = 0;
            int i = 2;
            string resultado = "";

            
            if (!int.TryParse(textBox1.Text, out n) || n <= 0)
            {
                MessageBox.Show("Por favor, ingrese un número entero mayor que 0.");
                return;
            }

            resultado += a + " ";
            resultado += b + " ";

            while (i < n)
            {
                c = a + b;
                a = b;
                b = c;
                resultado += c + " ";
                i++;
            }
            
            label3.Text = resultado;
            label3.Visible = true;
        }
    }
}
