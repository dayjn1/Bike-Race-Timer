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
    public partial class GravelController : Form
    {
        GravelRaceTimer Gravel;
        public GravelController()
        {
            InitializeComponent();
        }

        private void BeginButton_Click(object sender, EventArgs e)
        {
            Gravel = new GravelRaceTimer((int)this.TimeBetweenNUD.Value * 60, (int)this.CountDownNUD.Value * 60);
            Gravel.Show();
        }

        private void PauseStartButton_Click(object sender, EventArgs e)
        {
            if (this.RaceType.SelectedItem.ToString() == "Dam/Harr" && this.TimerType.SelectedItem.ToString() == "Count Down")
                Gravel.StartPauseDamHarrDown();
            else if (this.RaceType.SelectedItem.ToString() == "Dam/Harr" && this.TimerType.SelectedItem.ToString() == "Count Up")
                Gravel.StartPauseDamHarrUp();
            else if (this.RaceType.SelectedItem.ToString() == "Oak" && this.TimerType.SelectedItem.ToString() == "Count Down")
                Gravel.StartPauseOakDown();
            else if (this.RaceType.SelectedItem.ToString() == "Oak" && this.TimerType.SelectedItem.ToString() == "Count Up")
                Gravel.StartPauseOakUp();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int calulateSeconds = (int)this.HoursNUD.Value * 3600 + (int)this.MinutesNUD.Value * 60 + (int)this.SecondsNUD.Value;
            if (this.RaceType.SelectedItem.ToString() == "Dam/Harr" && this.TimerType.SelectedItem.ToString() == "Count Down")
                Gravel.UpdateDamHarrDown(calulateSeconds);
            else if (this.RaceType.SelectedItem.ToString() == "Dam/Harr" && this.TimerType.SelectedItem.ToString() == "Count Up")
                Gravel.StartSWForDamHarr(calulateSeconds);
            else if (this.RaceType.SelectedItem.ToString() == "Oak" && this.TimerType.SelectedItem.ToString() == "Count Down")
                Gravel.UpdateOakDown(calulateSeconds);
            else if (this.RaceType.SelectedItem.ToString() == "Oak" && this.TimerType.SelectedItem.ToString() == "Count Up")
                Gravel.StartSWForOak(calulateSeconds);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Gravel.Close();

            this.TimeBetweenNUD.Value = 15;
            this.CountDownNUD.Value = 10;

            this.HoursNUD.Value = 0;
            this.SecondsNUD.Value = 0;
            this.MinutesNUD.Value = 0;
        }
    }
}
