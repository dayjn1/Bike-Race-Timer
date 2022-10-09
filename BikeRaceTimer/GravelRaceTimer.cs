using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeRaceTimer
{
    public partial class GravelRaceTimer : Form
    {
        StopWatchWithOffset DamHarrTimer;
        StopWatchWithOffset OakTimer;
        private int CDDamHarrElapsedSeconds;
        private int CDOakElapsedSeconds;


        public GravelRaceTimer(int timeBetween, int countDown)
        {
            InitializeComponent();

            CDForDamHarr.Interval = 1000;
            CDForOak.Interval = 1000;

            CDDamHarrElapsedSeconds = countDown;
            TimeSpan time = TimeSpan.FromSeconds(CDDamHarrElapsedSeconds);
            DamHarrTimerLabel.Text = time.ToString(@"hh\:mm\:ss");

            CDOakElapsedSeconds = CDDamHarrElapsedSeconds + timeBetween;
            time = TimeSpan.FromSeconds(CDOakElapsedSeconds);
            OakTimerLabel.Text = time.ToString(@"hh\:mm\:ss");

            CDForDamHarr.Enabled = true;
            CDForOak.Enabled = true;
        }

        private void SWForDamHarr_Tick(object sender, EventArgs e)
        {
            if(DamHarrTimer != null)
                DamHarrTimerLabel.Text = DamHarrTimer.ElapsedTimeSpan.ToString(@"hh\:mm\:ss");
        }

        private void SWForOak_Tick(object sender, EventArgs e)
        {
            OakTimerLabel.Text = OakTimer.ElapsedTimeSpan.ToString(@"hh\:mm\:ss");
        }

        private void CDForDamHarr_Tick(object sender, EventArgs e)
        {
            CDDamHarrElapsedSeconds--;
            TimeSpan time = TimeSpan.FromSeconds(CDDamHarrElapsedSeconds);
            DamHarrTimerLabel.Text = time.ToString(@"hh\:mm\:ss");

            if (CDDamHarrElapsedSeconds == 0)
            {
                CDForDamHarr.Enabled = false;
                StartSWForDamHarr(0);
                SWForDamHarr.Enabled = true;

                //CountDownDone = true;
            }
        }

        private void CDForOak_Tick(object sender, EventArgs e)
        {
            CDOakElapsedSeconds--;
            TimeSpan time = TimeSpan.FromSeconds(CDOakElapsedSeconds);
            OakTimerLabel.Text = time.ToString(@"hh\:mm\:ss");

            if (CDOakElapsedSeconds == 0)
            {
                CDForOak.Enabled = false;
                StartSWForOak(0);
                SWForOak.Enabled = true;
                //CountDownDone = true;
            }
        }

        public void StartSWForDamHarr(int offsetSeconds)
        {
            DamHarrTimer = new StopWatchWithOffset(TimeSpan.FromSeconds(offsetSeconds));
            DamHarrTimer.Start();
        }

        public void StartSWForOak(int offsetSeconds)
        {
            OakTimer = new StopWatchWithOffset(TimeSpan.FromSeconds(offsetSeconds));
            OakTimer.Start();
        }

        public void StartPauseDamHarrDown()
        {
            if (CDForDamHarr.Enabled)
                CDForDamHarr.Enabled = false;
            else
                CDForDamHarr.Enabled = true;
        }

        public void StartPauseDamHarrUp()
        {
            if (SWForDamHarr.Enabled)
                SWForDamHarr.Enabled = false;
            else
                SWForDamHarr.Enabled = true;
        }

        public void StartPauseOakDown()
        {
            if (CDForOak.Enabled)
                CDForOak.Enabled = false;
            else
                CDForOak.Enabled = true;
        }

        // add actual start capability - breaks if try to manually start the count up
        // scratch that - will work if you update first - how to make this better?
        public void StartPauseOakUp()
        {
            if (SWForOak.Enabled)
                SWForOak.Enabled = false;
            else
                SWForOak.Enabled = true;
        }

        public void UpdateDamHarrDown(int seconds)
        {
            CDDamHarrElapsedSeconds = seconds;
        }

        public void UpdateOakDown(int seconds)
        {
            CDOakElapsedSeconds = seconds;
        }

    }
}
