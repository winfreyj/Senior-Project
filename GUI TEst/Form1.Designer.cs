namespace GUI_TEst
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yawSlider = new System.Windows.Forms.TrackBar();
            this.pitchSlider = new System.Windows.Forms.TrackBar();
            this.rollSlider = new System.Windows.Forms.TrackBar();
            this.cameraCounter = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.yawValue = new System.Windows.Forms.NumericUpDown();
            this.pitchValue = new System.Windows.Forms.NumericUpDown();
            this.rollValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.yawSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yawValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollValue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yaw";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pitch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Roll";
            // 
            // yawSlider
            // 
            this.yawSlider.Location = new System.Drawing.Point(167, 23);
            this.yawSlider.Maximum = 1000;
            this.yawSlider.Minimum = -1000;
            this.yawSlider.Name = "yawSlider";
            this.yawSlider.Size = new System.Drawing.Size(203, 45);
            this.yawSlider.TabIndex = 6;
            this.yawSlider.TickFrequency = 100;
            this.yawSlider.ValueChanged += new System.EventHandler(this.YawSliderMoved);
            // 
            // pitchSlider
            // 
            this.pitchSlider.Location = new System.Drawing.Point(167, 70);
            this.pitchSlider.Maximum = 1000;
            this.pitchSlider.Minimum = -1000;
            this.pitchSlider.Name = "pitchSlider";
            this.pitchSlider.Size = new System.Drawing.Size(203, 45);
            this.pitchSlider.TabIndex = 7;
            this.pitchSlider.TickFrequency = 100;
            this.pitchSlider.ValueChanged += new System.EventHandler(this.PitchSliderMoved);
            // 
            // rollSlider
            // 
            this.rollSlider.Location = new System.Drawing.Point(167, 118);
            this.rollSlider.Maximum = 1000;
            this.rollSlider.Minimum = -1000;
            this.rollSlider.Name = "rollSlider";
            this.rollSlider.Size = new System.Drawing.Size(203, 45);
            this.rollSlider.TabIndex = 8;
            this.rollSlider.TickFrequency = 100;
            this.rollSlider.ValueChanged += new System.EventHandler(this.RollSliderMoved);
            // 
            // cameraCounter
            // 
            this.cameraCounter.Location = new System.Drawing.Point(32, 25);
            this.cameraCounter.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.cameraCounter.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.cameraCounter.Name = "cameraCounter";
            this.cameraCounter.Size = new System.Drawing.Size(42, 20);
            this.cameraCounter.TabIndex = 9;
            this.cameraCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cameraCounter.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Camera Number";
            // 
            // yawValue
            // 
            this.yawValue.DecimalPlaces = 2;
            this.yawValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.yawValue.Location = new System.Drawing.Point(376, 26);
            this.yawValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.yawValue.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.yawValue.Name = "yawValue";
            this.yawValue.Size = new System.Drawing.Size(44, 20);
            this.yawValue.TabIndex = 11;
            this.yawValue.ValueChanged += new System.EventHandler(this.YawValueChanged);
            // 
            // pitchValue
            // 
            this.pitchValue.DecimalPlaces = 2;
            this.pitchValue.Location = new System.Drawing.Point(376, 75);
            this.pitchValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.pitchValue.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.pitchValue.Name = "pitchValue";
            this.pitchValue.Size = new System.Drawing.Size(44, 20);
            this.pitchValue.TabIndex = 12;
            this.pitchValue.ValueChanged += new System.EventHandler(this.PitchValueChanged);
            // 
            // rollValue
            // 
            this.rollValue.DecimalPlaces = 2;
            this.rollValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.rollValue.Location = new System.Drawing.Point(376, 126);
            this.rollValue.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rollValue.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.rollValue.Name = "rollValue";
            this.rollValue.Size = new System.Drawing.Size(44, 20);
            this.rollValue.TabIndex = 13;
            this.rollValue.ValueChanged += new System.EventHandler(this.RollValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 171);
            this.Controls.Add(this.rollValue);
            this.Controls.Add(this.pitchValue);
            this.Controls.Add(this.yawValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cameraCounter);
            this.Controls.Add(this.rollSlider);
            this.Controls.Add(this.pitchSlider);
            this.Controls.Add(this.yawSlider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.yawSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraCounter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yawValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar yawSlider;
        private System.Windows.Forms.TrackBar pitchSlider;
        private System.Windows.Forms.TrackBar rollSlider;
        private System.Windows.Forms.NumericUpDown cameraCounter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown yawValue;
        private System.Windows.Forms.NumericUpDown pitchValue;
        private System.Windows.Forms.NumericUpDown rollValue;
    }
}

