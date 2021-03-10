using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeedLimitControl
{
    public partial class Form1 : Form
    {
        private int baseSpeed = 70;
        public Form1()
        {
            InitializeComponent();
        }

       public void calculateDemerits(int speed)
        {
            if (speed < 70)
            {
               
            }
            else
            {
                int difference = speed - baseSpeed;
                int demerites = difference / 4;
               
            }
        }

        private void speedMeter_ValueChanged(object sender, EventArgs e)
        {
            var speedoMeter = (TrackBar)sender;          
            calculateDemerits(speedoMeter.Value);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var val = (TextBox)sender;
            int speed = 0;
            if (string.IsNullOrEmpty(val.Text))
            {
               
                return;
            }
            int.TryParse(val.Text, out speed);
            calculateDemerits(speed);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MessageBoxIcon.Question.ToString(),"Navdeep Here");
        }
    }
}
