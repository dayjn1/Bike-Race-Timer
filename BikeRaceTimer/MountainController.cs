using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeRaceTimer
{
    public partial class MountainController : Form
    {
        MountainBikeTimer MTB;
        bool EnableCU = false;
        bool EnableCD = true;
        
        public MountainController()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if(this.TimerType.Text != null && this.TimerType.Text != "")
                MTB.Start(this.TimerType.Text);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            MTB.Stop();
        }


        private void ChangeTimeButton_Click(object sender, EventArgs e)
        {
            int calculatedSeconds;
            
            ChangeTime TC = new ChangeTime();
            TC.ShowDialog();

            if (TC.Submit == true)
            {
                calculatedSeconds = TC.SendResults();
                MTB.UpdateVals(this.TimerType.Text, calculatedSeconds);
            }

        }      

        private void BeginButton_Click(object sender, EventArgs e)
        {
            MTB = new MountainBikeTimer((int)this.CountDownNUD.Value * 60);
            MTB.Show();
        }

        private void IncrementButton_Click(object sender, EventArgs e)
        {
            MTB.IncrementLap();
        }

        private void DecrementButton_Click(object sender, EventArgs e)
        {
            MTB.DecrementLap();
        }
    }
}
