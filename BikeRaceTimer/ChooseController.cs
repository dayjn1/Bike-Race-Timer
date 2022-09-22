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
    public partial class ChooseController : Form
    {
        MountainController MTB;
        GravelController GVL;
        public ChooseController()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (this.MountainSelect.Checked)
            {
                MTB = new MountainController();
                MTB.Show();
            }
            else if(this.GravelSelect.Checked)
            {
                GVL = new GravelController();
                GVL.Show();
            }
        }
    }
}
