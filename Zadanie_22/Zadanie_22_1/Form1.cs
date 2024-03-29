namespace Zadanie_22_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "-15,246";
            textBox2.Text = "0,0464";
            textBox3.Text = "2000,1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            double z = double.Parse(textBox3.Text);
            double a = Math.Log10(Math.Pow(y,Math.Sqrt(Math.Abs(x))*-1)*(x-y/2) + Math.Pow(Math.Sin(Math.Atan(z)),2));
            textBox5.Text = "a = " + Convert.ToString(a);

        }
    }
}
