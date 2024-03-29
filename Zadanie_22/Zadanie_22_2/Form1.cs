using System.Xml;

namespace Zadanie_22_2
{
    public partial class Form1 : Form
    {
        double fx = 0;
        int x = 0, y = 0, z = 0;

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);
            z = Convert.ToInt32(textBox3.Text);


            for (int i = y; i < z; i++)
            {
                if (i % 2 != 0 & x > 0)
                {
                    textBox5.Text += $"e = {i * Math.Sqrt(fx)}" + Environment.NewLine;
                }
                else if (i % 2 == 0 & x < 0)
                {
                    textBox5.Text += $"e = {i / 2 * Math.Sqrt(Math.Abs(fx))}" + Environment.NewLine;
                }
                else
                {
                    textBox5.Text += $"e = {Math.Sqrt(Math.Abs(i * fx))}" + Environment.NewLine;
                }
            }
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            fx = Math.Sin(x);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            fx = Math.Exp(x);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            fx = Math.Cos(x);
        }
    }
}
