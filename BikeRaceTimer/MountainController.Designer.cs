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
            this.label6 = new System.Windows.Forms.Label();
            this.ChangeTimeButton = new System.Windows.Forms.Button();
            this.TimerType = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BeginButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CountDownNUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountDownNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(241, 62);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(94, 29);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(241, 111);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(94, 29);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // IncrementButton
            // 
            this.IncrementButton.Location = new System.Drawing.Point(398, 46);
            this.IncrementButton.Name = "IncrementButton";
            this.IncrementButton.Size = new System.Drawing.Size(94, 29);
            this.IncrementButton.TabIndex = 2;
            this.IncrementButton.Text = "Increment";
            this.IncrementButton.UseVisualStyleBackColor = true;
            this.IncrementButton.Click += new System.EventHandler(this.IncrementButton_Click);
            // 
            // DecrementButton
            // 
            this.DecrementButton.Location = new System.Drawing.Point(398, 92);
            this.DecrementButton.Name = "DecrementButton";
            this.DecrementButton.Size = new System.Drawing.Size(94, 29);
            this.DecrementButton.TabIndex = 3;
            this.DecrementButton.Text = "Decrement";
            this.DecrementButton.UseVisualStyleBackColor = true;
            this.DecrementButton.Click += new System.EventHandler(this.DecrementButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Laps";
            // 
            // ChangeTimeButton
            // 
            this.ChangeTimeButton.Location = new System.Drawing.Point(386, 58);
            this.ChangeTimeButton.Name = "ChangeTimeButton";
            this.ChangeTimeButton.Size = new System.Drawing.Size(131, 29);
            this.ChangeTimeButton.TabIndex = 19;
            this.ChangeTimeButton.Text = "Change Time";
            this.ChangeTimeButton.UseVisualStyleBackColor = true;
            this.ChangeTimeButton.Click += new System.EventHandler(this.ChangeTimeButton_Click);
            // 
            // TimerType
            // 
            this.TimerType.FormattingEnabled = true;
            this.TimerType.Items.AddRange(new object[] {
            "Count Down",
            "Stopwatch"});
            this.TimerType.Location = new System.Drawing.Point(27, 90);
            this.TimerType.Name = "TimerType";
            this.TimerType.Size = new System.Drawing.Size(151, 28);
            this.TimerType.TabIndex = 20;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(21, 26);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.BeginButton);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.CountDownNUD);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.IncrementButton);
            this.splitContainer1.Panel1.Controls.Add(this.DecrementButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.ChangeTimeButton);
            this.splitContainer1.Panel2.Controls.Add(this.TimerType);
            this.splitContainer1.Panel2.Controls.Add(this.StartButton);
            this.splitContainer1.Panel2.Controls.Add(this.StopButton);
            this.splitContainer1.Size = new System.Drawing.Size(549, 332);
            this.splitContainer1.SplitterDistance = 164;
            this.splitContainer1.TabIndex = 21;
            // 
            // BeginButton
            // 
            this.BeginButton.Location = new System.Drawing.Point(35, 101);
            this.BeginButton.Name = "BeginButton";
            this.BeginButton.Size = new System.Drawing.Size(166, 42);
            this.BeginButton.TabIndex = 18;
            this.BeginButton.Text = "Begin";
            this.BeginButton.UseVisualStyleBackColor = true;
            this.BeginButton.Click += new System.EventHandler(this.BeginButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Minutes";
            // 
            // CountDownNUD
            // 
            this.CountDownNUD.Location = new System.Drawing.Point(127, 54);
            this.CountDownNUD.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.CountDownNUD.Name = "CountDownNUD";
            this.CountDownNUD.Size = new System.Drawing.Size(97, 27);
            this.CountDownNUD.TabIndex = 16;
            this.CountDownNUD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Count Down";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Timer Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(364, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Select timer type before changing time or start/pause";
            // 
            // MountainController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 370);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MountainController";
            this.Text = "Controller";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CountDownNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button StartButton;
        private Button StopButton;
        private Button IncrementButton;
        private Button DecrementButton;
        private Label label6;
        private Button ChangeTimeButton;
        private ComboBox TimerType;
        private SplitContainer splitContainer1;
        private Label label2;
        private NumericUpDown CountDownNUD;
        private Label label1;
        private Label label4;
        private Label label3;
        private Button BeginButton;
    }
}