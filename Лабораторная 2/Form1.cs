using System;
using System.Windows.Forms;
namespace Лабораторная_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Начальное значение X
            textBox1.Text = "0,03981";
            // Начальное значение Y
            textBox2.Text = "-1625";
            // Начальное значение Z
            textBox3.Text = "0,512";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            textBox4.Text += Environment.NewLine + "x = " + x.ToString();
            double y = double.Parse(textBox2.Text);
            textBox4.Text += Environment.NewLine + "y = " + y.ToString();
            double z = double.Parse(textBox3.Text);
            textBox4.Text += Environment.NewLine + "z = " + z.ToString();
            double a = Math.Pow(2, -x) * Math.Pow(x + Math.Pow(Math.Abs(y), 1.0 / 4.0), 1.0 / 2.0) * Math.Pow(Math.Exp(x - 1.0 / Math.Sin(z)), 1.0 / 3.0);
            textBox4.Text += Environment.NewLine + "Результат a = " + a.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}