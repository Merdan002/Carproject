using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Carproject
{
    public partial class Form1 : Form
    {
        bool isGazopen = false;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void panel12_MouseEnter(object sender, EventArgs e)
        {
            isGazopen = true;
        }

        private void panel11_MouseEnter(object sender, EventArgs e)
        {
            isGazopen = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isGazopen)
            {
                Car.Location = new Point(Car.Location.X + 1 , Car.Location.Y - 1);

            }
            
        }
    }
}
