using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.button1.Text = "Resultado";
            this.button2.Text = "Limpiar";
            this.label1.Text = "Numero 1";
            this.label2.Text = "Numero 2";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Numero number1 = new Numero(this.textBox1.Text);
            Numero number2 = new Numero(this.textBox2.Text);
            if(Calculadora.validateOperator(this.comboBox1.Text))
            {
                double xValueReturn = Calculadora.work(number1.number, number2.number, this.comboBox1.Text);
                this.textBox3.Text = xValueReturn.ToString();
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
        }
    }
}
