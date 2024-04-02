namespace Zadanie_24_2
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
            userControlTimer1 = new UserControlTimer();
            userControlTimer21 = new UserControlTimer2();
            clickButton1 = new ClickButton();
            SuspendLayout();
            // 
            // userControlTimer1
            // 
            userControlTimer1.Location = new Point(37, 21);
            userControlTimer1.Name = "userControlTimer1";
            userControlTimer1.Size = new Size(158, 82);
            userControlTimer1.TabIndex = 0;
            userControlTimer1.TimeEnabled = true;
            // 
            // userControlTimer21
            // 
            userControlTimer21.Location = new Point(37, 99);
            userControlTimer21.Name = "userControlTimer21";
            userControlTimer21.Size = new Size(121, 78);
            userControlTimer21.TabIndex = 1;
            // 
            // clickButton1
            // 
            clickButton1.Location = new Point(332, 123);
            clickButton1.Name = "clickButton1";
            clickButton1.Size = new Size(56, 34);
            clickButton1.TabIndex = 2;
            clickButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clickButton1);
            Controls.Add(userControlTimer21);
            Controls.Add(userControlTimer1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private UserControlTimer userControlTimer1;
        private UserControlTimer2 userControlTimer21;
        private ClickButton clickButton1;
    }
}
