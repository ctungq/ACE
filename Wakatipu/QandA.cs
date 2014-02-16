using System;
using System.Windows.Forms;

namespace Wakatipu
{
    public partial class QandA : Form
    {
        String a;
        DateTime startTime;
        int seconsToWait = 10;

        public QandA()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnTiming.Text = seconsToWait.ToString();
        }


        private void btnTiming_Click(object sender, EventArgs e)
        {
            a = txt.Text.ToString();
            txt2.Text = a;

            timer1.Start();
            startTime = DateTime.Now;
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            btnTiming.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double elapsedSeconds = (DateTime.Now - startTime).TotalSeconds;
            double remainingSeconds = seconsToWait - elapsedSeconds;

            if (remainingSeconds <= 0)
            {
                // run your function
                timer1.Stop();
            }

            btnTiming.Text =
                String.Format("{0}", Math.Round(remainingSeconds));
        }
    }
}
