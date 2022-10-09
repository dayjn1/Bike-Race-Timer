namespace BikeRaceTimer
{
    partial class ChangeTime
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
            this.label1 = new System.Windows.Forms.Label();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.MinutesLabel = new System.Windows.Forms.Label();
            this.SecondsLabel = new System.Windows.Forms.Label();
            this.HoursNUD = new System.Windows.Forms.NumericUpDown();
            this.MinutesNUD = new System.Windows.Forms.NumericUpDown();
            this.SecondsNUD = new System.Windows.Forms.NumericUpDown();
            this.SubmitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HoursNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a new time";
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Location = new System.Drawing.Point(64, 124);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(48, 20);
            this.HoursLabel.TabIndex = 1;
            this.HoursLabel.Text = "Hours";
            // 
            // MinutesLabel
            // 
            this.MinutesLabel.AutoSize = true;
            this.MinutesLabel.Location = new System.Drawing.Point(51, 188);
            this.MinutesLabel.Name = "MinutesLabel";
            this.MinutesLabel.Size = new System.Drawing.Size(61, 20);
            this.MinutesLabel.TabIndex = 2;
            this.MinutesLabel.Text = "Minutes";
            // 
            // SecondsLabel
            // 
            this.SecondsLabel.AutoSize = true;
            this.SecondsLabel.Location = new System.Drawing.Point(48, 249);
            this.SecondsLabel.Name = "SecondsLabel";
            this.SecondsLabel.Size = new System.Drawing.Size(64, 20);
            this.SecondsLabel.TabIndex = 3;
            this.SecondsLabel.Text = "Seconds";
            // 
            // HoursNUD
            // 
            this.HoursNUD.Location = new System.Drawing.Point(155, 122);
            this.HoursNUD.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.HoursNUD.Name = "HoursNUD";
            this.HoursNUD.Size = new System.Drawing.Size(150, 27);
            this.HoursNUD.TabIndex = 4;
            // 
            // MinutesNUD
            // 
            this.MinutesNUD.Location = new System.Drawing.Point(155, 186);
            this.MinutesNUD.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.MinutesNUD.Name = "MinutesNUD";
            this.MinutesNUD.Size = new System.Drawing.Size(150, 27);
            this.MinutesNUD.TabIndex = 5;
            // 
            // SecondsNUD
            // 
            this.SecondsNUD.Location = new System.Drawing.Point(155, 247);
            this.SecondsNUD.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.SecondsNUD.Name = "SecondsNUD";
            this.SecondsNUD.Size = new System.Drawing.Size(150, 27);
            this.SecondsNUD.TabIndex = 6;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(125, 322);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(94, 29);
            this.SubmitButton.TabIndex = 7;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ChangeTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 391);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.SecondsNUD);
            this.Controls.Add(this.MinutesNUD);
            this.Controls.Add(this.HoursNUD);
            this.Controls.Add(this.SecondsLabel);
            this.Controls.Add(this.MinutesLabel);
            this.Controls.Add(this.HoursLabel);
            this.Controls.Add(this.label1);
            this.Name = "ChangeTime";
            this.Text = "ChangeTime";
            ((System.ComponentModel.ISupportInitialize)(this.HoursNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinutesNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondsNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label HoursLabel;
        private Label MinutesLabel;
        private Label SecondsLabel;
        private NumericUpDown HoursNUD;
        private NumericUpDown MinutesNUD;
        private NumericUpDown SecondsNUD;
        private Button SubmitButton;
    }
}