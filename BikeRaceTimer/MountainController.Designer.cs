namespace BikeRaceTimer
{
    partial class MountainController
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
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.IncrementButton = new System.Windows.Forms.Button();
            this.DecrementButton = new System.Windows.Forms.Button();
            this.CDMinutes = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CDSeconds = new System.Windows.Forms.NumericUpDown();
            this.CUHours = new System.Windows.Forms.NumericUpDown();
            this.CUMinutes = new System.Windows.Forms.NumericUpDown();
            this.CUSeconds = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.CDSelect = new System.Windows.Forms.RadioButton();
            this.CUSelect = new System.Windows.Forms.RadioButton();
            this.ResetButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CDMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CDSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CUHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CUMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CUSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(102, 47);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(94, 29);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(260, 47);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(94, 29);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // IncrementButton
            // 
            this.IncrementButton.Location = new System.Drawing.Point(446, 106);
            this.IncrementButton.Name = "IncrementButton";
            this.IncrementButton.Size = new System.Drawing.Size(94, 29);
            this.IncrementButton.TabIndex = 2;
            this.IncrementButton.Text = "Increment";
            this.IncrementButton.UseVisualStyleBackColor = true;
            this.IncrementButton.Click += new System.EventHandler(this.IncrementButton_Click);
            // 
            // DecrementButton
            // 
            this.DecrementButton.Location = new System.Drawing.Point(446, 147);
            this.DecrementButton.Name = "DecrementButton";
            this.DecrementButton.Size = new System.Drawing.Size(94, 29);
            this.DecrementButton.TabIndex = 3;
            this.DecrementButton.Text = "Decrement";
            this.DecrementButton.UseVisualStyleBackColor = true;
            this.DecrementButton.Click += new System.EventHandler(this.DecrementButton_Click);
            // 
            // CDMinutes
            // 
            this.CDMinutes.Location = new System.Drawing.Point(129, 251);
            this.CDMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.CDMinutes.Name = "CDMinutes";
            this.CDMinutes.Size = new System.Drawing.Size(67, 27);
            this.CDMinutes.TabIndex = 4;
            this.CDMinutes.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CDMinutes.ValueChanged += new System.EventHandler(this.CDMinutes_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Set Count Down";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Set Count Up";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Minutes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Seconds";
            // 
            // CDSeconds
            // 
            this.CDSeconds.Location = new System.Drawing.Point(129, 298);
            this.CDSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.CDSeconds.Name = "CDSeconds";
            this.CDSeconds.Size = new System.Drawing.Size(67, 27);
            this.CDSeconds.TabIndex = 10;
            this.CDSeconds.ValueChanged += new System.EventHandler(this.CDSeconds_ValueChanged);
            // 
            // CUHours
            // 
            this.CUHours.Location = new System.Drawing.Point(271, 213);
            this.CUHours.Name = "CUHours";
            this.CUHours.Size = new System.Drawing.Size(67, 27);
            this.CUHours.TabIndex = 11;
            this.CUHours.ValueChanged += new System.EventHandler(this.CUHours_ValueChanged);
            // 
            // CUMinutes
            // 
            this.CUMinutes.Location = new System.Drawing.Point(271, 258);
            this.CUMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.CUMinutes.Name = "CUMinutes";
            this.CUMinutes.Size = new System.Drawing.Size(67, 27);
            this.CUMinutes.TabIndex = 12;
            this.CUMinutes.ValueChanged += new System.EventHandler(this.CUMinutes_ValueChanged);
            // 
            // CUSeconds
            // 
            this.CUSeconds.Location = new System.Drawing.Point(271, 300);
            this.CUSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.CUSeconds.Name = "CUSeconds";
            this.CUSeconds.Size = new System.Drawing.Size(67, 27);
            this.CUSeconds.TabIndex = 13;
            this.CUSeconds.ValueChanged += new System.EventHandler(this.CUSeconds_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Laps";
            // 
            // CDSelect
            // 
            this.CDSelect.AutoSize = true;
            this.CDSelect.Checked = true;
            this.CDSelect.Location = new System.Drawing.Point(38, 111);
            this.CDSelect.Name = "CDSelect";
            this.CDSelect.Size = new System.Drawing.Size(168, 24);
            this.CDSelect.TabIndex = 15;
            this.CDSelect.TabStop = true;
            this.CDSelect.Text = "Count Down on Start";
            this.CDSelect.UseVisualStyleBackColor = true;
            this.CDSelect.CheckedChanged += new System.EventHandler(this.CDSelect_CheckedChanged);
            // 
            // CUSelect
            // 
            this.CUSelect.AutoSize = true;
            this.CUSelect.Location = new System.Drawing.Point(239, 111);
            this.CUSelect.Name = "CUSelect";
            this.CUSelect.Size = new System.Drawing.Size(148, 24);
            this.CUSelect.TabIndex = 16;
            this.CUSelect.TabStop = true;
            this.CUSelect.Text = "Count Up on Start";
            this.CUSelect.UseVisualStyleBackColor = true;
            this.CUSelect.CheckedChanged += new System.EventHandler(this.CUSelect_CheckedChanged);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(446, 300);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(94, 29);
            this.ResetButton.TabIndex = 17;
            this.ResetButton.Text = "Reset All";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(446, 249);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(94, 29);
            this.UpdateButton.TabIndex = 18;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // Controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 370);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CUSelect);
            this.Controls.Add(this.CDSelect);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CUSeconds);
            this.Controls.Add(this.CUMinutes);
            this.Controls.Add(this.CUHours);
            this.Controls.Add(this.CDSeconds);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CDMinutes);
            this.Controls.Add(this.DecrementButton);
            this.Controls.Add(this.IncrementButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Name = "Controller";
            this.Text = "Controller";
            ((System.ComponentModel.ISupportInitialize)(this.CDMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CDSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CUHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CUMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CUSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button StartButton;
        private Button StopButton;
        private Button IncrementButton;
        private Button DecrementButton;
        private NumericUpDown CDMinutes;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown CDSeconds;
        private NumericUpDown CUHours;
        private NumericUpDown CUMinutes;
        private NumericUpDown CUSeconds;
        private Label label6;
        private RadioButton CDSelect;
        private RadioButton CUSelect;
        private Button ResetButton;
        private Button UpdateButton;
    }
}