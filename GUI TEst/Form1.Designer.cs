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
            this.motorTabs = new System.Windows.Forms.TabControl();
            this.motor1 = new System.Windows.Forms.TabPage();
            this.automaticButton = new System.Windows.Forms.Button();
            this.manualButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            ((System.ComponentModel.ISupportInitialize)(this.yawSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraCounter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yawValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollValue)).BeginInit();
            this.motorTabs.SuspendLayout();
            this.motor1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yaw";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pitch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Roll";
            // 
            // yawSlider
            // 
            this.yawSlider.Location = new System.Drawing.Point(344, 42);
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
            this.pitchSlider.Location = new System.Drawing.Point(344, 89);
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
            this.rollSlider.Location = new System.Drawing.Point(344, 137);
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
            this.cameraCounter.Location = new System.Drawing.Point(553, 10);
            this.cameraCounter.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.cameraCounter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cameraCounter.Name = "cameraCounter";
            this.cameraCounter.Size = new System.Drawing.Size(42, 20);
            this.cameraCounter.TabIndex = 9;
            this.cameraCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cameraCounter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cameraCounter.ValueChanged += new System.EventHandler(this.ChangeMotorTabs);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total Camera Number";
            // 
            // yawValue
            // 
            this.yawValue.DecimalPlaces = 2;
            this.yawValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.yawValue.Location = new System.Drawing.Point(553, 45);
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
            this.pitchValue.Location = new System.Drawing.Point(553, 94);
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
            this.rollValue.Location = new System.Drawing.Point(553, 145);
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
            // motorTabs
            // 
            this.motorTabs.Controls.Add(this.motor1);
            this.motorTabs.Location = new System.Drawing.Point(11, 186);
            this.motorTabs.Name = "motorTabs";
            this.motorTabs.SelectedIndex = 0;
            this.motorTabs.Size = new System.Drawing.Size(605, 298);
            this.motorTabs.TabIndex = 14;
            // 
            // motor1
            // 
            this.motor1.Controls.Add(this.automaticButton);
            this.motor1.Controls.Add(this.manualButton);
            this.motor1.Controls.Add(this.numericUpDown1);
            this.motor1.Controls.Add(this.numericUpDown2);
            this.motor1.Controls.Add(this.numericUpDown3);
            this.motor1.Controls.Add(this.trackBar1);
            this.motor1.Controls.Add(this.trackBar2);
            this.motor1.Controls.Add(this.trackBar3);
            this.motor1.Controls.Add(this.label5);
            this.motor1.Controls.Add(this.label6);
            this.motor1.Controls.Add(this.label7);
            this.motor1.Location = new System.Drawing.Point(4, 22);
            this.motor1.Name = "motor1";
            this.motor1.Padding = new System.Windows.Forms.Padding(3);
            this.motor1.Size = new System.Drawing.Size(597, 272);
            this.motor1.TabIndex = 3;
            this.motor1.Text = "Motor 1";
            this.motor1.UseVisualStyleBackColor = true;
            // 
            // automaticButton
            // 
            this.automaticButton.Location = new System.Drawing.Point(77, 166);
            this.automaticButton.Name = "automaticButton";
            this.automaticButton.Size = new System.Drawing.Size(75, 23);
            this.automaticButton.TabIndex = 24;
            this.automaticButton.Text = "Automatic";
            this.automaticButton.UseVisualStyleBackColor = true;
            this.automaticButton.Click += new System.EventHandler(this.AutomaticOption);
            // 
            // manualButton
            // 
            this.manualButton.Location = new System.Drawing.Point(77, 119);
            this.manualButton.Name = "manualButton";
            this.manualButton.Size = new System.Drawing.Size(75, 23);
            this.manualButton.TabIndex = 23;
            this.manualButton.Text = "Manual";
            this.manualButton.UseVisualStyleBackColor = true;
            this.manualButton.Click += new System.EventHandler(this.ManualOptions);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown1.Location = new System.Drawing.Point(538, 201);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown1.TabIndex = 22;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Location = new System.Drawing.Point(538, 150);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown2.TabIndex = 21;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.DecimalPlaces = 2;
            this.numericUpDown3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown3.Location = new System.Drawing.Point(538, 101);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown3.TabIndex = 20;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.trackBar1.Location = new System.Drawing.Point(329, 193);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Minimum = -1000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(203, 45);
            this.trackBar1.TabIndex = 19;
            this.trackBar1.TickFrequency = 100;
            // 
            // trackBar2
            // 
            this.trackBar2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.trackBar2.Location = new System.Drawing.Point(329, 145);
            this.trackBar2.Maximum = 1000;
            this.trackBar2.Minimum = -1000;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(203, 45);
            this.trackBar2.TabIndex = 18;
            this.trackBar2.TickFrequency = 100;
            // 
            // trackBar3
            // 
            this.trackBar3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.trackBar3.Location = new System.Drawing.Point(329, 98);
            this.trackBar3.Maximum = 1000;
            this.trackBar3.Minimum = -1000;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(203, 45);
            this.trackBar3.TabIndex = 17;
            this.trackBar3.TickFrequency = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Roll";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Pitch";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Yaw";
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(34, 12);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(267, 168);
            this.elementHost1.TabIndex = 15;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 496);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.motorTabs);
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
            this.motorTabs.ResumeLayout(false);
            this.motor1.ResumeLayout(false);
            this.motor1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
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
        private System.Windows.Forms.TabControl motorTabs;
        private System.Windows.Forms.TabPage motor1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button automaticButton;
        private System.Windows.Forms.Button manualButton;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
    }
}

