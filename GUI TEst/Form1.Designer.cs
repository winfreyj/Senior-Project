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
            this.cameraCounter = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cameraTabs = new System.Windows.Forms.TabControl();
            this.camera1 = new System.Windows.Forms.TabPage();
            this.automaticButton1 = new System.Windows.Forms.Button();
            this.manualButton1 = new System.Windows.Forms.Button();
            this.rollUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pitchUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.yawUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.rollSlider1 = new System.Windows.Forms.TrackBar();
            this.pitchSlider1 = new System.Windows.Forms.TrackBar();
            this.yawSlider1 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.camera2 = new System.Windows.Forms.TabPage();
            this.automaticButton2 = new System.Windows.Forms.Button();
            this.manualButton2 = new System.Windows.Forms.Button();
            this.rollUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.pitchUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.yawUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.rollSlider2 = new System.Windows.Forms.TrackBar();
            this.pitchSlider2 = new System.Windows.Forms.TrackBar();
            this.yawSlider2 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.log = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cameraCounter)).BeginInit();
            this.cameraTabs.SuspendLayout();
            this.camera1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rollUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yawUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollSlider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchSlider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yawSlider1)).BeginInit();
            this.camera2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rollUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yawUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollSlider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchSlider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yawSlider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cameraCounter
            // 
            this.cameraCounter.Location = new System.Drawing.Point(128, 286);
            this.cameraCounter.Maximum = new decimal(new int[] {
            2,
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
            2,
            0,
            0,
            0});
            this.cameraCounter.ValueChanged += new System.EventHandler(this.ChangeMotorTabs);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total Camera Number";
            // 
            // cameraTabs
            // 
            this.cameraTabs.Controls.Add(this.camera1);
            this.cameraTabs.Controls.Add(this.camera2);
            this.cameraTabs.Location = new System.Drawing.Point(11, 317);
            this.cameraTabs.Name = "cameraTabs";
            this.cameraTabs.SelectedIndex = 0;
            this.cameraTabs.Size = new System.Drawing.Size(605, 202);
            this.cameraTabs.TabIndex = 14;
            // 
            // camera1
            // 
            this.camera1.Controls.Add(this.automaticButton1);
            this.camera1.Controls.Add(this.manualButton1);
            this.camera1.Controls.Add(this.rollUpDown1);
            this.camera1.Controls.Add(this.pitchUpDown1);
            this.camera1.Controls.Add(this.yawUpDown1);
            this.camera1.Controls.Add(this.rollSlider1);
            this.camera1.Controls.Add(this.pitchSlider1);
            this.camera1.Controls.Add(this.yawSlider1);
            this.camera1.Controls.Add(this.label5);
            this.camera1.Controls.Add(this.label6);
            this.camera1.Controls.Add(this.label7);
            this.camera1.Location = new System.Drawing.Point(4, 22);
            this.camera1.Name = "camera1";
            this.camera1.Padding = new System.Windows.Forms.Padding(3);
            this.camera1.Size = new System.Drawing.Size(597, 176);
            this.camera1.TabIndex = 3;
            this.camera1.Text = "Camera 1";
            this.camera1.UseVisualStyleBackColor = true;
            // 
            // automaticButton1
            // 
            this.automaticButton1.Location = new System.Drawing.Point(53, 87);
            this.automaticButton1.Name = "automaticButton1";
            this.automaticButton1.Size = new System.Drawing.Size(75, 23);
            this.automaticButton1.TabIndex = 24;
            this.automaticButton1.Text = "Automatic";
            this.automaticButton1.UseVisualStyleBackColor = true;
            this.automaticButton1.Click += new System.EventHandler(this.AutomaticOption);
            // 
            // manualButton1
            // 
            this.manualButton1.Location = new System.Drawing.Point(53, 40);
            this.manualButton1.Name = "manualButton1";
            this.manualButton1.Size = new System.Drawing.Size(75, 23);
            this.manualButton1.TabIndex = 23;
            this.manualButton1.Text = "Manual";
            this.manualButton1.UseVisualStyleBackColor = true;
            this.manualButton1.Click += new System.EventHandler(this.ManualOptions);
            // 
            // rollUpDown1
            // 
            this.rollUpDown1.DecimalPlaces = 2;
            this.rollUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.rollUpDown1.Location = new System.Drawing.Point(514, 113);
            this.rollUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rollUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.rollUpDown1.Name = "rollUpDown1";
            this.rollUpDown1.Size = new System.Drawing.Size(55, 20);
            this.rollUpDown1.TabIndex = 22;
            this.rollUpDown1.ValueChanged += new System.EventHandler(this.RollValueChanged);
            // 
            // pitchUpDown1
            // 
            this.pitchUpDown1.DecimalPlaces = 2;
            this.pitchUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.pitchUpDown1.Location = new System.Drawing.Point(514, 65);
            this.pitchUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.pitchUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.pitchUpDown1.Name = "pitchUpDown1";
            this.pitchUpDown1.Size = new System.Drawing.Size(55, 20);
            this.pitchUpDown1.TabIndex = 21;
            this.pitchUpDown1.ValueChanged += new System.EventHandler(this.PitchValueChanged);
            // 
            // yawUpDown1
            // 
            this.yawUpDown1.DecimalPlaces = 2;
            this.yawUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.yawUpDown1.Location = new System.Drawing.Point(514, 18);
            this.yawUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.yawUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.yawUpDown1.Name = "yawUpDown1";
            this.yawUpDown1.Size = new System.Drawing.Size(55, 20);
            this.yawUpDown1.TabIndex = 20;
            this.yawUpDown1.ValueChanged += new System.EventHandler(this.YawValueChanged);
            // 
            // rollSlider1
            // 
            this.rollSlider1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rollSlider1.Location = new System.Drawing.Point(305, 112);
            this.rollSlider1.Maximum = 1000;
            this.rollSlider1.Minimum = -1000;
            this.rollSlider1.Name = "rollSlider1";
            this.rollSlider1.Size = new System.Drawing.Size(203, 45);
            this.rollSlider1.TabIndex = 19;
            this.rollSlider1.TickFrequency = 100;
            this.rollSlider1.ValueChanged += new System.EventHandler(this.RollSliderMoved);
            // 
            // pitchSlider1
            // 
            this.pitchSlider1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pitchSlider1.Location = new System.Drawing.Point(305, 64);
            this.pitchSlider1.Maximum = 1000;
            this.pitchSlider1.Minimum = -1000;
            this.pitchSlider1.Name = "pitchSlider1";
            this.pitchSlider1.Size = new System.Drawing.Size(203, 45);
            this.pitchSlider1.TabIndex = 18;
            this.pitchSlider1.TickFrequency = 100;
            this.pitchSlider1.ValueChanged += new System.EventHandler(this.PitchSliderMoved);
            // 
            // yawSlider1
            // 
            this.yawSlider1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.yawSlider1.Location = new System.Drawing.Point(305, 17);
            this.yawSlider1.Maximum = 500;
            this.yawSlider1.Minimum = -500;
            this.yawSlider1.Name = "yawSlider1";
            this.yawSlider1.Size = new System.Drawing.Size(203, 45);
            this.yawSlider1.TabIndex = 17;
            this.yawSlider1.TickFrequency = 100;
            this.yawSlider1.ValueChanged += new System.EventHandler(this.YawSliderMoved);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Roll";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Pitch";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Yaw";
            // 
            // camera2
            // 
            this.camera2.Controls.Add(this.automaticButton2);
            this.camera2.Controls.Add(this.manualButton2);
            this.camera2.Controls.Add(this.rollUpDown2);
            this.camera2.Controls.Add(this.pitchUpDown2);
            this.camera2.Controls.Add(this.yawUpDown2);
            this.camera2.Controls.Add(this.rollSlider2);
            this.camera2.Controls.Add(this.pitchSlider2);
            this.camera2.Controls.Add(this.yawSlider2);
            this.camera2.Controls.Add(this.label1);
            this.camera2.Controls.Add(this.label2);
            this.camera2.Controls.Add(this.label3);
            this.camera2.Location = new System.Drawing.Point(4, 22);
            this.camera2.Name = "camera2";
            this.camera2.Padding = new System.Windows.Forms.Padding(3);
            this.camera2.Size = new System.Drawing.Size(597, 176);
            this.camera2.TabIndex = 4;
            this.camera2.Text = "Camera 2";
            this.camera2.UseVisualStyleBackColor = true;
            // 
            // automaticButton2
            // 
            this.automaticButton2.Location = new System.Drawing.Point(53, 87);
            this.automaticButton2.Name = "automaticButton2";
            this.automaticButton2.Size = new System.Drawing.Size(75, 23);
            this.automaticButton2.TabIndex = 35;
            this.automaticButton2.Text = "Automatic";
            this.automaticButton2.UseVisualStyleBackColor = true;
            this.automaticButton2.Click += new System.EventHandler(this.AutomaticOption);
            // 
            // manualButton2
            // 
            this.manualButton2.Location = new System.Drawing.Point(53, 40);
            this.manualButton2.Name = "manualButton2";
            this.manualButton2.Size = new System.Drawing.Size(75, 23);
            this.manualButton2.TabIndex = 34;
            this.manualButton2.Text = "Manual";
            this.manualButton2.UseVisualStyleBackColor = true;
            this.manualButton2.Click += new System.EventHandler(this.ManualOptions);
            // 
            // rollUpDown2
            // 
            this.rollUpDown2.DecimalPlaces = 2;
            this.rollUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.rollUpDown2.Location = new System.Drawing.Point(514, 113);
            this.rollUpDown2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rollUpDown2.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.rollUpDown2.Name = "rollUpDown2";
            this.rollUpDown2.Size = new System.Drawing.Size(55, 20);
            this.rollUpDown2.TabIndex = 33;
            this.rollUpDown2.ValueChanged += new System.EventHandler(this.RollValueChanged);
            // 
            // pitchUpDown2
            // 
            this.pitchUpDown2.DecimalPlaces = 2;
            this.pitchUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.pitchUpDown2.Location = new System.Drawing.Point(514, 65);
            this.pitchUpDown2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.pitchUpDown2.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.pitchUpDown2.Name = "pitchUpDown2";
            this.pitchUpDown2.Size = new System.Drawing.Size(55, 20);
            this.pitchUpDown2.TabIndex = 32;
            this.pitchUpDown2.ValueChanged += new System.EventHandler(this.PitchValueChanged);
            // 
            // yawUpDown2
            // 
            this.yawUpDown2.DecimalPlaces = 2;
            this.yawUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.yawUpDown2.Location = new System.Drawing.Point(514, 18);
            this.yawUpDown2.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.yawUpDown2.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.yawUpDown2.Name = "yawUpDown2";
            this.yawUpDown2.Size = new System.Drawing.Size(55, 20);
            this.yawUpDown2.TabIndex = 31;
            this.yawUpDown2.ValueChanged += new System.EventHandler(this.YawValueChanged);
            // 
            // rollSlider2
            // 
            this.rollSlider2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.rollSlider2.Location = new System.Drawing.Point(305, 112);
            this.rollSlider2.Maximum = 1000;
            this.rollSlider2.Minimum = -1000;
            this.rollSlider2.Name = "rollSlider2";
            this.rollSlider2.Size = new System.Drawing.Size(203, 45);
            this.rollSlider2.TabIndex = 30;
            this.rollSlider2.TickFrequency = 100;
            this.rollSlider2.ValueChanged += new System.EventHandler(this.RollSliderMoved);
            // 
            // pitchSlider2
            // 
            this.pitchSlider2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pitchSlider2.Location = new System.Drawing.Point(305, 64);
            this.pitchSlider2.Maximum = 1000;
            this.pitchSlider2.Minimum = -1000;
            this.pitchSlider2.Name = "pitchSlider2";
            this.pitchSlider2.Size = new System.Drawing.Size(203, 45);
            this.pitchSlider2.TabIndex = 29;
            this.pitchSlider2.TickFrequency = 100;
            this.pitchSlider2.ValueChanged += new System.EventHandler(this.PitchSliderMoved);
            // 
            // yawSlider2
            // 
            this.yawSlider2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.yawSlider2.Location = new System.Drawing.Point(305, 17);
            this.yawSlider2.Maximum = 500;
            this.yawSlider2.Minimum = -500;
            this.yawSlider2.Name = "yawSlider2";
            this.yawSlider2.Size = new System.Drawing.Size(203, 45);
            this.yawSlider2.TabIndex = 28;
            this.yawSlider2.TickFrequency = 100;
            this.yawSlider2.ValueChanged += new System.EventHandler(this.YawSliderMoved);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Roll";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Pitch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Yaw";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 260);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(320, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(288, 260);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(641, 40);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.log.Size = new System.Drawing.Size(264, 479);
            this.log.TabIndex = 17;
            this.log.WordWrap = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(755, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Log";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 532);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.log);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cameraTabs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cameraCounter);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cameraCounter)).EndInit();
            this.cameraTabs.ResumeLayout(false);
            this.camera1.ResumeLayout(false);
            this.camera1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rollUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yawUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollSlider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchSlider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yawSlider1)).EndInit();
            this.camera2.ResumeLayout(false);
            this.camera2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rollUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yawUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollSlider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchSlider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yawSlider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown cameraCounter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl cameraTabs;
        private System.Windows.Forms.TabPage camera1;
        private System.Windows.Forms.NumericUpDown rollUpDown1;
        private System.Windows.Forms.NumericUpDown pitchUpDown1;
        private System.Windows.Forms.NumericUpDown yawUpDown1;
        private System.Windows.Forms.TrackBar rollSlider1;
        private System.Windows.Forms.TrackBar pitchSlider1;
        private System.Windows.Forms.TrackBar yawSlider1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button automaticButton1;
        private System.Windows.Forms.Button manualButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.TabPage camera2;
        private System.Windows.Forms.Button automaticButton2;
        private System.Windows.Forms.Button manualButton2;
        private System.Windows.Forms.NumericUpDown rollUpDown2;
        private System.Windows.Forms.NumericUpDown pitchUpDown2;
        private System.Windows.Forms.NumericUpDown yawUpDown2;
        private System.Windows.Forms.TrackBar rollSlider2;
        private System.Windows.Forms.TrackBar pitchSlider2;
        private System.Windows.Forms.TrackBar yawSlider2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
    }
}

