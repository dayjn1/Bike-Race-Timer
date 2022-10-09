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
    public partial class ChangeTime : Form
    {
        public bool Submit = false;
        public ChangeTime()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Submit = true;

            this.Close();
        }

        public int SendResults()
        {
            return (int)this.HoursNUD.Value * 3600 + (int)this.MinutesNUD.Value * 60 + (int)this.SecondsNUD.Value;

        }
    }
}
