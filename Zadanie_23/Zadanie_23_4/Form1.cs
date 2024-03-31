using Microsoft.VisualBasic;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Zadanie_23_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point p = new Point(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            if (textBox1.Text =="К")
            {
                Button button = new Button();
                button.Location = p;
                button.Text = "knopka";
                button.Visible = true;
                button.AutoSize = true;
                button.MouseEnter += Button_MouseEnter; 
                this.Controls.Add(button);
            }
            else if (textBox1.Text =="П")
            {
                TextBox tb = new TextBox();
                tb.Location = p;
                tb.Text =  "Input";
                tb.AutoSize = true;
                tb.Visible = true;
                tb.MouseEnter += TextBox_MouseEnter;
                this.Controls.Add(tb);
            }
            else if (textBox1.Text == "М")
            {
               System.Windows.Forms.Label myLabel = new System.Windows.Forms.Label();
                myLabel.Location = p;
                myLabel.AutoSize = true; 
                myLabel.Text = "Моя метка";
                myLabel.MouseEnter += Label_MouseEnter;
                this.Controls.Add(myLabel);
            }
            else
            {
                MessageBox.Show("Нет действия") ;
            }
                 
                
               
            
            

        }
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).Visible = false;
        }

        private void TextBox_MouseEnter(object sender, EventArgs e)
        {
            ((TextBox)sender).Visible = false;
        }
        private void Label_MouseEnter(object sender, EventArgs e)
        {
            ((System.Windows.Forms.Label)sender).Visible = false;
        }

    }
}
