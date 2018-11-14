using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_Experiments
{
    public partial class Timer_Experiment : Form
    {
        public Timer_Experiment()
        {
            InitializeComponent();
        }

        Timer timer = new Timer();

        void timer_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Tick += new EventHandler(timer_Tick); // Everytime timer ticks, timer_Tick will be called
            timer.Interval = (1000) * (1);              // Timer will tick evert second
            timer.Enabled = true;                       // Enable the timer
            timer.Start();                              // Start the timer

            this.Controls.Add(label1);

            label1.BackColor = System.Drawing.Color.Turquoise;
            label1.Font = new Font("Forte", 18);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)

        {
            // Var to hold TrackBar value
            double tbValue;

            // Set trackbar min && max, can also do this from the TrackBar Properties outside of code
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 10;
            
            // Get current Trackbar value
            tbValue = trackBar1.Value;

            if (tbValue == 1)
            {
                label1.BackColor = System.Drawing.Color.Turquoise;
                label1.Font = new Font("Forte", 18);
            }
            else if (tbValue == 2)
            {
                label1.BackColor = System.Drawing.Color.Orange;
                label1.Font = new Font("Elephant", 14);
            }
            else if (tbValue == 3)
            {
                label1.BackColor = System.Drawing.Color.LemonChiffon;
                label1.Font = new Font("Jokerman", 16);
            }
            else if (tbValue == 4)
            {
                label1.BackColor = System.Drawing.Color.Red;
                label1.Font = new Font("Impact", 16);
            }
            else if (tbValue == 5)
            {
                label1.BackColor = System.Drawing.Color.DeepPink;
                label1.Font = new Font("Ravie", 12);
            }
            else if (tbValue == 6)
            {
                label1.BackColor = System.Drawing.Color.LightSalmon;
                label1.Font = new Font("Stencil", 16);
            }
            else if (tbValue == 7)
            {
                label1.BackColor = System.Drawing.Color.LightSkyBlue;
                label1.Font = new Font("Goudy Stout", 12);
            }
            else if (tbValue == 8)
            {
                label1.BackColor = System.Drawing.Color.LightGreen;
                label1.Font = new Font("Gigi", 20);
            }
            else if (tbValue == 9)
            {
                label1.BackColor = System.Drawing.Color.GreenYellow;
                label1.Font = new Font("Curlz MT", 20);
            }
            else if (tbValue == 10)
            {
                label1.BackColor = System.Drawing.Color.Yellow;
                label1.Font = new Font("Playbill", 20);
            }

            label2.Text = tbValue.ToString();
        }

    }
}
