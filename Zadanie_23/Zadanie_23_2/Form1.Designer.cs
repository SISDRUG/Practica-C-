namespace Zadanie_23_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 417);
            label1.Name = "label1";
            label1.Size = new Size(53, 25);
            label1.TabIndex = 0;
            label1.Text = "Xmin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 416);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 1;
            label2.Text = "Xmax";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(302, 417);
            label3.Name = "label3";
            label3.Size = new Size(46, 25);
            label3.TabIndex = 2;
            label3.Text = "step";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(75, 417);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(72, 31);
            textBox1.TabIndex = 3;
            textBox1.Text = "2";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(215, 413);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(72, 31);
            textBox2.TabIndex = 4;
            textBox2.Text = "5";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(354, 413);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(72, 31);
            textBox3.TabIndex = 5;
            textBox3.Text = "1";
            // 
            // button1
            // 
            button1.Location = new Point(589, 407);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "result";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // plotView1
            // 
            plotView1.Location = new Point(75, 109);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(491, 202);
            plotView1.TabIndex = 7;
            plotView1.Text = "plotView1";
            plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(plotView1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private OxyPlot.WindowsForms.PlotView plotView1;
    }
}
