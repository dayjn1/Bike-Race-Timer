namespace BikeRaceTimer
{
    partial class ChooseController
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
            this.MountainSelect = new System.Windows.Forms.RadioButton();
            this.GravelSelect = new System.Windows.Forms.RadioButton();
            this.StartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MountainSelect
            // 
            this.MountainSelect.AutoSize = true;
            this.MountainSelect.Location = new System.Drawing.Point(57, 40);
            this.MountainSelect.Name = "MountainSelect";
            this.MountainSelect.Size = new System.Drawing.Size(93, 24);
            this.MountainSelect.TabIndex = 0;
            this.MountainSelect.TabStop = true;
            this.MountainSelect.Text = "Mountain";
            this.MountainSelect.UseVisualStyleBackColor = true;
            // 
            // GravelSelect
            // 
            this.GravelSelect.AutoSize = true;
            this.GravelSelect.Location = new System.Drawing.Point(57, 87);
            this.GravelSelect.Name = "GravelSelect";
            this.GravelSelect.Size = new System.Drawing.Size(72, 24);
            this.GravelSelect.TabIndex = 1;
            this.GravelSelect.TabStop = true;
            this.GravelSelect.Text = "Gravel";
            this.GravelSelect.UseVisualStyleBackColor = true;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(107, 142);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(94, 29);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ChooseController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 194);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.GravelSelect);
            this.Controls.Add(this.MountainSelect);
            this.Name = "ChooseController";
            this.Text = "ChooseController";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton MountainSelect;
        private RadioButton GravelSelect;
        private Button StartButton;
    }
}