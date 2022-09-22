namespace BikeRaceTimer
{
    partial class GravelController
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
            this.BeginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TimeBetweenNUD = new System.Windows.Forms.NumericUpDown();
            this.CountDownNUD = new System.Windows.Forms.NumericUpDown();
            this.HoursNUD = new System.Windows.Forms.NumericUpDown();
            this.MinutesNUD = new System.Windows.Forms.NumericUpDown();
            this.SecondsNUD = new System.Windows.Forms.NumericUpDown();
            this.PauseStartButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.RaceType = new System.Windows.Forms.ComboBox();
            this.TimerType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TimeBetweenNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountDownNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BeginButton
            // 
            this.BeginButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BeginButton.Location = new System.Drawing.Point(285, 39);
            this.BeginButton.Name = "BeginButton";
            this.BeginButton.Size = new System.Drawing.Size(137, 65);
            this.BeginButton.TabIndex = 0;
            this.BeginButton.Text = "Begin";
            this.BeginButton.UseVisualStyleBackColor = true;
            this.BeginButton.Click += new System.EventHandler(this.BeginButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Minutes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time Between";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Count Down";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Minutes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Seconds";
            // 
            // TimeBetweenNUD
            // 
            this.TimeBetweenNUD.Location = new System.Drawing.Point(136, 39);
            this.TimeBetweenNUD.Name = "TimeBetweenNUD";
            this.TimeBetweenNUD.Size = new System.Drawing.Size(86, 27);
            this.TimeBetweenNUD.TabIndex = 7;
            this.TimeBetweenNUD.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // CountDownNUD
            // 
            this.CountDownNUD.Location = new System.Drawing.Point(136, 85);
            this.CountDownNUD.Name = "CountDownNUD";
            this.CountDownNUD.Size = new System.Drawing.Size(86, 27);
            this.CountDownNUD.TabIndex = 8;
            this.CountDownNUD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // HoursNUD
            // 
            this.HoursNUD.Location = new System.Drawing.Point(136, 118);
            this.HoursNUD.Name = "HoursNUD";
            this.HoursNUD.Size = new System.Drawing.Size(86, 27);
            this.HoursNUD.TabIndex = 9;
            // 
            // MinutesNUD
            // 
            this.MinutesNUD.Location = new System.Drawing.Point(136, 177);
            this.MinutesNUD.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.MinutesNUD.Name = "MinutesNUD";
            this.MinutesNUD.Size = new System.Drawing.Size(86, 27);
            this.MinutesNUD.TabIndex = 10;
            // 
            // SecondsNUD
            // 
            this.SecondsNUD.Location = new System.Drawing.Point(136, 229);
            this.SecondsNUD.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.SecondsNUD.Name = "SecondsNUD";
            this.SecondsNUD.Size = new System.Drawing.Size(86, 27);
            this.SecondsNUD.TabIndex = 11;
            // 
            // PauseStartButton
            // 
            this.PauseStartButton.Location = new System.Drawing.Point(276, 120);
            this.PauseStartButton.Name = "PauseStartButton";
            this.PauseStartButton.Size = new System.Drawing.Size(94, 29);
            this.PauseStartButton.TabIndex = 14;
            this.PauseStartButton.Text = "Pause/Start";
            this.PauseStartButton.UseVisualStyleBackColor = true;
            this.PauseStartButton.Click += new System.EventHandler(this.PauseStartButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(276, 173);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(94, 29);
            this.UpdateButton.TabIndex = 15;
            this.UpdateButton.Text = "Update TV";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(276, 225);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(94, 29);
            this.ResetButton.TabIndex = 16;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(37, 27);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.TimeBetweenNUD);
            this.splitContainer1.Panel1.Controls.Add(this.CountDownNUD);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.BeginButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.TimerType);
            this.splitContainer1.Panel2.Controls.Add(this.RaceType);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.SecondsNUD);
            this.splitContainer1.Panel2.Controls.Add(this.ResetButton);
            this.splitContainer1.Panel2.Controls.Add(this.MinutesNUD);
            this.splitContainer1.Panel2.Controls.Add(this.UpdateButton);
            this.splitContainer1.Panel2.Controls.Add(this.PauseStartButton);
            this.splitContainer1.Panel2.Controls.Add(this.HoursNUD);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Size = new System.Drawing.Size(448, 443);
            this.splitContainer1.SplitterDistance = 146;
            this.splitContainer1.TabIndex = 17;
            // 
            // RaceType
            // 
            this.RaceType.FormattingEnabled = true;
            this.RaceType.Items.AddRange(new object[] {
            "Dam/Harr",
            "Oak"});
            this.RaceType.Location = new System.Drawing.Point(55, 53);
            this.RaceType.Name = "RaceType";
            this.RaceType.Size = new System.Drawing.Size(151, 28);
            this.RaceType.TabIndex = 19;
            // 
            // TimerType
            // 
            this.TimerType.FormattingEnabled = true;
            this.TimerType.Items.AddRange(new object[] {
            "Count Down",
            "Count Up"});
            this.TimerType.Location = new System.Drawing.Point(256, 53);
            this.TimerType.Name = "TimerType";
            this.TimerType.Size = new System.Drawing.Size(151, 28);
            this.TimerType.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Race Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(276, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Timer Type";
            // 
            // GravelController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 505);
            this.Controls.Add(this.splitContainer1);
            this.Name = "GravelController";
            this.Text = "GravelController";
            ((System.ComponentModel.ISupportInitialize)(this.TimeBetweenNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountDownNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoursNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsNUD)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button BeginButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown TimeBetweenNUD;
        private NumericUpDown CountDownNUD;
        private NumericUpDown HoursNUD;
        private NumericUpDown MinutesNUD;
        private NumericUpDown SecondsNUD;
        private Button PauseStartButton;
        private Button UpdateButton;
        private Button ResetButton;
        private SplitContainer splitContainer1;
        private Label label8;
        private Label label7;
        private ComboBox TimerType;
        private ComboBox RaceType;
    }
}