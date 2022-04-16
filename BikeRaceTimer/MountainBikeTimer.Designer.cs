namespace BikeRaceTimer
{
    partial class MountainBikeTimer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MountainBikeTimer));
            this.CountDown = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.CountUp = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.LapCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CountDown
            // 
            this.CountDown.Tick += new System.EventHandler(this.CountDown_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(66, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 243);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CountUp
            // 
            this.CountUp.Tick += new System.EventHandler(this.CountUp_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1234, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 244);
            this.label2.TabIndex = 3;
            this.label2.Text = "Laps \r\nTo Go: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LapCounter
            // 
            this.LapCounter.AutoSize = true;
            this.LapCounter.BackColor = System.Drawing.Color.Transparent;
            this.LapCounter.Font = new System.Drawing.Font("Impact", 200F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LapCounter.Location = new System.Drawing.Point(1216, 516);
            this.LapCounter.Name = "LapCounter";
            this.LapCounter.Size = new System.Drawing.Size(350, 407);
            this.LapCounter.TabIndex = 4;
            this.LapCounter.Text = "0";
            this.LapCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MountainBikeTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.LapCounter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "MountainBikeTimer";
            this.ShowIcon = false;
            this.Text = "Peryton XC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer CountDown;
        private Label label1;
        private System.Windows.Forms.Timer CountUp;
        private Label label2;
        private Label LapCounter;
    }
}