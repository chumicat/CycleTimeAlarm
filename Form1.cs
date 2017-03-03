using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CycleTimeAlarm
{
    public partial class TIMER : Form
    {
        private SoundPlayer alarm = new SoundPlayer(DEFINE.ALARMSOUND);

        public TIMER()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //SystemSounds.Exclamation.Play();
            alarm.Play();
        }

        private void act_b_Click(object sender, EventArgs e)
        {
            this.Text = this.cycleTime_n.Value.ToString();
            if (this.cycleTime_n.Value != 0)
            {
                timer1.Interval = (int)cycleTime_n.Value * 1000;
                timer1.Enabled = !timer1.Enabled;
                act_b.Text = act_b.Text == "Start" ? "Stop" : "Start";
            }
        }

        private void history_b_Click(object sender, EventArgs e)
        {
            cycleTime_n.Value = 60;
            act_b_Click(sender, e);
        }
    }

    class DEFINE
    {
        public static String ALARMSOUND = "../../Sound/shigure.wav";
    }
}
