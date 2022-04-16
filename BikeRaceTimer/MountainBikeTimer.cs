namespace BikeRaceTimer
{
    public partial class MountainBikeTimer : Form
    {
        private int CDElapsedSeconds = 600;
        private int CUElapsedSeconds = 0;
        private bool CountDownDone = false;
        private int LapsToGo = 0;

        public MountainBikeTimer()
        {
            InitializeComponent();
            CountDown.Interval = 1000;
            CountUp.Interval = 1000;
            TimeSpan time = TimeSpan.FromSeconds(CDElapsedSeconds);
            label1.Text = time.ToString(@"mm\:ss");
        }

        private void CountDown_Tick(object sender, EventArgs e)
        {
            CDElapsedSeconds--;
            TimeSpan time = TimeSpan.FromSeconds(CDElapsedSeconds);
            label1.Text = time.ToString(@"mm\:ss");

            if(CDElapsedSeconds == 0)
            {
                CountDown.Enabled = false;
                CountUp.Enabled = true;
                CountDownDone = true;
            }
        }

        public void Start()
        {
            if (CountDown.Enabled == false && CountDownDone == false)
                CountDown.Enabled = true;
            else if (CountUp.Enabled == false && CountDownDone)
                CountUp.Enabled = true;
        }

        public void Stop()
        {
            if (CountDown.Enabled == true)
                CountDown.Enabled = false;
            else if (CountUp.Enabled == true)
                CountUp.Enabled = false;
        }

        public void CountUp_Tick(object sender, EventArgs e)
        {
            CUElapsedSeconds++;
            TimeSpan time = TimeSpan.FromSeconds(CUElapsedSeconds);
            label1.Text = time.ToString(@"hh\:mm\:ss");
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        public void ResetLap()
        {
            LapsToGo = 0;
            LapCounter.Text = LapsToGo.ToString();
        }

        public void EnableCD()
        {
            CountDown.Enabled = true;
        }

        public void DisableCD()
        {
            CountDown.Enabled = false;
        }

        public void EnableCU()
        {
            CountUp.Enabled = true;
        }

        public void DisableCU()
        {
            CountUp.Enabled = false;
        }

        public void UpdateVals(int CD, int CU, bool CDDone)
        {
            CDElapsedSeconds = CD;
            CUElapsedSeconds = CU;
            CountDownDone = CDDone;
        }
    }
}