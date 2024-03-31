namespace Zadanie_23_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Нарисовать кузов машины
            Pen carPen = new Pen(Color.Blue, 2);
            g.DrawRectangle(carPen, 50, 100, 200, 80);

            // Нарисовать колеса
            Brush wheelBrush = new SolidBrush(Color.Black);
            g.FillEllipse(wheelBrush, 70, 160, 40, 40);
            g.FillEllipse(wheelBrush, 190, 160, 40, 40);

            // Нарисовать логотип BMW
            Font logoFont = new Font("Arial", 12, FontStyle.Bold);
            Brush logoBrush = new SolidBrush(Color.White);
            g.DrawString("BMW", logoFont, logoBrush, 120, 110);
        }
    }
}
