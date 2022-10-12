using System.Diagnostics;

namespace BikeRaceTimer
{
    public partial class MountainBikeTimer : Form
    {
        private int CDElapsedSeconds = 600;
        private int LapsToGo = 0;

        StopWatchWithOffset SW;


        public MountainBikeTimer(int CDSec)
        {
            InitializeComponent();
            CountDown.Interval = 1000;
            CountUp.Interval = 1000;
            this.CDElapsedSeconds = CDSec;
            TimeSpan time = TimeSpan.FromSeconds(CDElapsedSeconds);
            label1.Text = time.ToString(@"hh\:mm\:ss");
        }

        private void CountDown_Tick(object sender, EventArgs e)
        {
            CDElapsedSeconds--;
            TimeSpan time = TimeSpan.FromSeconds(CDElapsedSeconds);
            label1.Text = time.ToString(@"hh\:mm\:ss");

            if (CDElapsedSeconds == 0)
            {
                CountDown.Enabled = false;

                this.SW = new StopWatchWithOffset(TimeSpan.FromSeconds(0));
                this.SW.Start();
                
                CountUp.Enabled = true;
            }
        }

        public void Start(string DownOrSW)
        {
            if (DownOrSW == "Count Down" && CountDown.Enabled == false && CountUp.Enabled == false && CDElapsedSeconds > 0)
                CountDown.Enabled = true;
            else if(DownOrSW == "Stopwatch" && CountDown.Enabled == false && CountUp.Enabled == false)
            {
                CountUp.Enabled = true;
                if (this.SW != null)
                    this.SW.Start();
            }
                
        }

        public void Stop()
        {
            if (CountDown.Enabled == true && CountUp.Enabled == false)
                CountDown.Enabled = false;
            else if (CountDown.Enabled == false && CountUp.Enabled == true)
            {
                CountUp.Enabled = false;
                if (this.SW != null)
                    this.SW.Stop();
            }
        }

        public void CountUp_Tick(object sender, EventArgs e)
        {
            if(this.SW == null)
            {
                this.SW = new StopWatchWithOffset(TimeSpan.FromSeconds(0));
                this.SW.Start();
            }

            label1.Text = SW.ElapsedTimeSpan.ToString(@"hh\:mm\:ss");
        }

        public void IncrementLap()
        {
            LapsToGo++;
            LapCounter.Text = LapsToGo.ToString();
        }

        public void DecrementLap()
        {
            LapsToGo--;
            LapCounter.Text = LapsToGo.ToString();
        }

        public void UpdateVals(string DownOrSW, int seconds)
        {
            if (DownOrSW == "Count Down")
                CDElapsedSeconds = seconds;
            else if (DownOrSW == "Stopwatch")
            {
                this.SW = new StopWatchWithOffset(TimeSpan.FromSeconds(seconds));
                if (CountUp.Enabled)
                    this.SW.Start();
            }
        }
    }
}