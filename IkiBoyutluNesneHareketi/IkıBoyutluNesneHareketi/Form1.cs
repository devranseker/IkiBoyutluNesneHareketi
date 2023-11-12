using System;
using System.Windows.Forms;

namespace IkıBoyutluNesneHareketi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerYukari.Start();

        }

        private void timerYukari_Tick(object sender, EventArgs e)
        {
            Arabamiz.Top -= 3;
            if (Arabamiz.Top <= 41)
            {
                timerYukari.Stop();
                timerSag.Start();
            }
        }

        private void timerSag_Tick(object sender, EventArgs e)
        {
            Arabamiz.Left += 5;
            if (Arabamiz.Left >= 733)
            {
                timerSag.Stop();
                timerAsagı.Start();

            }

        }

        private void timerAsagı_Tick(object sender, EventArgs e)
        {
            Arabamiz.Top += 5;    // 5'er 5'er asagıya gonder
            if(Arabamiz.Top >= 356)
            {
                timerAsagı.Stop();
                timerSol.Start();
                
            }
        }

        private void timerSol_Tick(object sender, EventArgs e)
        {
            Arabamiz.Left -= 5;
            if(Arabamiz.Left <= 95)
            {
                timerSol.Stop();
                timerYukari.Start();

            }
        }
    }
}
