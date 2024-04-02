namespace Zadanie_24_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            spWin.Text = "Horizontal";
            spData.Text = Convert.ToString(System.DateTime.Today.ToLongDateString());
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ControlDarkDark;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1000, 1000);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.Width > this.Height)
            {
                spWin.Text = "Horizontal";
            }else { spWin.Text = "Cascade"; }
        }
    }
}
