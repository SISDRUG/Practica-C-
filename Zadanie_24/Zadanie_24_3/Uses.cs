using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_24_3
{
    public partial class Uses : UserControl
    {  
        int currentColorIndex = 0;
        private Color[] colors = { Color.Red, Color.Aqua, Color.Bisque, Color.Coral, SystemColors.Control };
        public Uses()
        {   
            
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.BackColor = colors[currentColorIndex];
            currentColorIndex = (currentColorIndex + 1) % colors.Length;
        }
    } 
}
