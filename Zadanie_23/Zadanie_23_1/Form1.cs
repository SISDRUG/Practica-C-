namespace Zadanie_23_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = (string)listBox1.Items[0];
            string[] numbers = str.Split(' ');
            int i = 0;
            foreach (string number in numbers)
            {
                if (Convert.ToInt32(number)%2 == 00) { i++; }
            }
            label1.Text= "Количество четных "+ i.ToString();
        }
    }
}
