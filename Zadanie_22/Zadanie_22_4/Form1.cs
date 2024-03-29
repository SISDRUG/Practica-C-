using static System.Net.Mime.MediaTypeNames;

namespace Zadanie_22_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {


            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1900; i < 2025; i++)
            {
                comboBox3.Items.Add(i);
            }

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "��������� ����� (*.txt)|*.txt|��� ����� (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                File.WriteAllText(filePath, textBox6.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {


            string gender = (radioButton1.Checked) ? "M" : "�";
            string stag = (radioButton3.Checked) ? radioButton3.Text : (radioButton4.Checked) ? radioButton4.Text : (radioButton5.Checked) ? radioButton5.Text : (radioButton6.Checked) ? radioButton6.Text : radioButton7.Text;
            string work = (radioButton11.Checked) ? radioButton11.Text : (radioButton12.Checked) ? radioButton12.Text : radioButton13.Text;
            textBox6.Text = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + Environment.NewLine +
                "��� " + gender + Environment.NewLine +
                "���� �������� " + comboBox1.Text + "." + comboBox2.Text + "." + comboBox3.Text + Environment.NewLine +
                "�������������� ���������: " + work.ToLower() + Environment.NewLine +
                "���������� ����� �� " + numericUpDown1.Value + " �� " + numericUpDown2.Value + Environment.NewLine +
                "���� ������ " + stag + Environment.NewLine +
                "����� ���������� " + comboBox4.Text + Environment.NewLine +
                "������ ��������:" + Environment.NewLine +
                (checkBox1.Checked ? checkBox1.Text : "") + Environment.NewLine +
                (checkBox2.Checked ? checkBox2.Text + ":" : "") + (checkBox3.Checked ? checkBox3.Text : "") + " " + (checkBox4.Checked ? checkBox4.Text : "") + " " + (checkBox5.Checked ? checkBox5.Text : "") + " " + (checkBox6.Checked ? checkBox6.Text : "") + Environment.NewLine +
                "���������� ����������:" + Environment.NewLine +
                "����� ����������� �����: " + textBox4.Text + Environment.NewLine +
                "��������� ������� " + comboBox5.Text + " " + textBox5.Text
                ;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            comboBox1.Text = "1";
            comboBox2.Text = "������";
            comboBox3.Text = "2000";

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            for (int i = 1900; i < 2024; i++)
            {
                comboBox3.Items.Add(i);
            } 
        }
    }
}

