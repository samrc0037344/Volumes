using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volumes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //set variables
            double radius;

            //read radius value
            try
            {
                radius = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Error on input.");
                radius = 0.0;
            }

            //calaculate volume
            double Volume = 4.0 / 3.0 * Math.PI * radius * radius * radius;

            //display volume
            label1.Text = "Volume = " + Volume + "m^3.";
        }
    }
}
