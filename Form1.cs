using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_AnthonyGuzman
{
    public partial class Form1 : Form
    {
        private List<string> operaciones = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2, r;
            n1 = Convert.ToInt32(textBox1.Text);
            n2 = Convert.ToInt32(textBox2.Text);
            r = n1 + n2;
            label3.Text = "Suma = " + r;
            operaciones.Add($"{n1} + {n2} = {r}");
            ActualizarListBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1, n2, r;
            n1 = Convert.ToInt32(textBox1.Text);
            n2 = Convert.ToInt32(textBox2.Text);
            if (n2 != 0)
            {
                r = n1 / n2;
                label3.Text = "Division = " + r;
                operaciones.Add($"{n1} / {n2} = {r}");
                ActualizarListBox();
            }
            else
            {
                MessageBox.Show("No se puede dividir por cero.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n1, n2, r;
            n1 = Convert.ToInt32(textBox1.Text);
            n2 = Convert.ToInt32(textBox2.Text);
            r = n1 - n2;
            label3.Text = "Resta = " + r;
            operaciones.Add($"{n1} - {n2} = {r}");
            ActualizarListBox();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n1, n2, r;
            n1 = Convert.ToInt32(textBox1.Text);
            n2 = Convert.ToInt32(textBox2.Text);
            r = n1 * n2;
            label3.Text = "Multiplicacion = " + r;
            operaciones.Add($"{n1} * {n2} = {r}");
            ActualizarListBox();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label3.Text = "";
            textBox1.Focus();
        }

        private void ActualizarListBox()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = operaciones;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}