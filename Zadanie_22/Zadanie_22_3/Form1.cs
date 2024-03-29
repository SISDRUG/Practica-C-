namespace Zadanie_22_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double xo = double.Parse(textBox1.Text);
            double xk = double.Parse(textBox2.Text);
            double dx = double.Parse(textBox3.Text);
            double a = double.Parse(textBox4.Text);
            double x = xo;
            while (x < xk)
            {
                textBox5.Text += $"x = {x:F2} y = {Math.Pow(x, 4) + Math.Cos(2 + Math.Pow(x, 3) - a):F2}" + Environment.NewLine;
                x += dx;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "4,8";
            textBox2.Text = "5,6";
            textBox3.Text = "0,2";
            textBox4.Text = "1,3";
        }
    }
}
