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
    public partial class Controller : Form
    {
        MountainBikeTimer MTB = new MountainBikeTimer();
        bool EnableCU = false;
        bool EnableCD = true;
        int CUSec = 0, CUMin = 0, CUHrs = 0;
        int CDSec = 0, CDMin = 10;

        public Controller()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            MTB.Show();
            MTB.Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            MTB.Stop();
        }

        private void CDSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (CDSelect.Checked)
            {
                EnableCD = true;
                EnableCU = false;
            }
            else
            {
                EnableCD = false;
                EnableCU = true;
            }
        }

        private void CUSelect_CheckedChanged(object sender, EventArgs e)
        {
            if (CUSelect.Checked)
            {
                EnableCU = true;
                EnableCD = false;
            }
            else
            {
                EnableCU = false;
                EnableCD = true;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            EnableCU = false;
            EnableCD = false;
            CUSec = 0;
            CUSeconds.Value = CUSec;

            CUMin = 0;
            CUMinutes.Value = CUMin;

            CUHrs = 0;
            CUHours.Value = CUHrs;

            CDSec = 0;
            CDSeconds.Value = CDSec;

            CDMin = 10;
            CDMinutes.Value = CDMin;

            MTB.ResetLap();
        }

        private void CDMinutes_ValueChanged(object sender, EventArgs e)
        {
            CDMin = (int)CDMinutes.Value;
        }

        private void CDSeconds_ValueChanged(object sender, EventArgs e)
        {
            CDSec = (int)CDSeconds.Value;
        }

        private void CUHours_ValueChanged(object sender, EventArgs e)
        {
            CUHrs = (int)CUHours.Value;
        }

        private void CUMinutes_ValueChanged(object sender, EventArgs e)
        {
            CUMin = (int)CUMinutes.Value;
        }

        private void CUSeconds_ValueChanged(object sender, EventArgs e)
        {
            CUSec = (int)CUSeconds.Value;
        }

        private void IncrementButton_Click(object sender, EventArgs e)
        {
            MTB.IncrementLap();
        }

        private void DecrementButton_Click(object sender, EventArgs e)
        {
            MTB.DecrementLap();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int CDTotTime = CDMin * 60 + CDSec;
            int CUTotTime = CUHrs * 3600 + CUMin * 60 + CUSec;


            MTB.UpdateVals(CDTotTime, CUTotTime, EnableCD);
        }
    }
}
