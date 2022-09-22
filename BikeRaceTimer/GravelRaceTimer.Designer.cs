namespace BikeRaceTimer
{
    partial class GravelRaceTimer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DamHarrTimerLabel = new System.Windows.Forms.Label();
            this.OakTimerLabel = new System.Windows.Forms.Label();
            this.SWForDamHarr = new System.Windows.Forms.Timer(this.components);
            this.CDForDamHarr = new System.Windows.Forms.Timer(this.components);
            this.DamHarrLabel = new System.Windows.Forms.Label();
            this.OakLabel = new System.Windows.Forms.Label();
            this.SWForOak = new System.Windows.Forms.Timer(this.components);
            this.CDForOak = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // DamHarrTimerLabel
            // 
            this.DamHarrTimerLabel.AutoSize = true;
            this.DamHarrTimerLabel.Font = new System.Drawing.Font("Impact", 199.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DamHarrTimerLabel.Location = new System.Drawing.Point(547, 35);
            this.DamHarrTimerLabel.Name = "DamHarrTimerLabel";
            this.DamHarrTimerLabel.Size = new System.Drawing.Size(996, 406);
            this.DamHarrTimerLabel.TabIndex = 0;
            this.DamHarrTimerLabel.Text = "label1";
            // 
            // OakTimerLabel
            // 
            this.OakTimerLabel.AutoSize = true;
            this.OakTimerLabel.Font = new System.Drawing.Font("Impact", 199.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OakTimerLabel.Location = new System.Drawing.Point(547, 515);
            this.OakTimerLabel.Name = "OakTimerLabel";
            this.OakTimerLabel.Size = new System.Drawing.Size(1036, 406);
            this.OakTimerLabel.TabIndex = 1;
            this.OakTimerLabel.Text = "label2";
            // 
            // SWForDamHarr
            // 
            this.SWForDamHarr.Tick += new System.EventHandler(this.SWForDamHarr_Tick);
            // 
            // CDForDamHarr
            // 
            this.CDForDamHarr.Interval = 1000;
            this.CDForDamHarr.Tick += new System.EventHandler(this.CDForDamHarr_Tick);
            // 
            // DamHarrLabel
            // 
            this.DamHarrLabel.AutoSize = true;
            this.DamHarrLabel.Font = new System.Drawing.Font("Impact", 100.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DamHarrLabel.Location = new System.Drawing.Point(63, 33);
            this.DamHarrLabel.Name = "DamHarrLabel";
            this.DamHarrLabel.Size = new System.Drawing.Size(463, 408);
            this.DamHarrLabel.TabIndex = 2;
            this.DamHarrLabel.Text = "Dam/\r\nHarr:";
            // 
            // OakLabel
            // 
            this.OakLabel.AutoSize = true;
            this.OakLabel.Font = new System.Drawing.Font("Impact", 100.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OakLabel.Location = new System.Drawing.Point(63, 633);
            this.OakLabel.Name = "OakLabel";
            this.OakLabel.Size = new System.Drawing.Size(380, 204);
            this.OakLabel.TabIndex = 3;
            this.OakLabel.Text = "Oak:";
            // 
            // SWForOak
            // 
            this.SWForOak.Tick += new System.EventHandler(this.SWForOak_Tick);
            // 
            // CDForOak
            // 
            this.CDForOak.Tick += new System.EventHandler(this.CDForOak_Tick);
            // 
            // GravelRaceTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.OakLabel);
            this.Controls.Add(this.DamHarrLabel);
            this.Controls.Add(this.OakTimerLabel);
            this.Controls.Add(this.DamHarrTimerLabel);
            this.Name = "GravelRaceTimer";
            this.Text = "The Best DAM Gravel Ride";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label DamHarrTimerLabel;
        private Label OakTimerLabel;
        private System.Windows.Forms.Timer SWForDamHarr;
        private System.Windows.Forms.Timer CDForDamHarr;
        private Label DamHarrLabel;
        private Label OakLabel;
        private System.Windows.Forms.Timer SWForOak;
        private System.Windows.Forms.Timer CDForOak;
    }
}