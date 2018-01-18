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
            this.yawValue = new System.Windows.Forms.TextBox();
            this.pitchValue = new System.Windows.Forms.TextBox();
            this.rollValue = new System.Windows.Forms.TextBox();
            this.yawSlider = new System.Windows.Forms.TrackBar();
            this.pitchSlider = new System.Windows.Forms.TrackBar();
            this.rollSlider = new System.Windows.Forms.TrackBar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.yawSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            // yawValue
            // 
            this.yawValue.AcceptsReturn = true;
            this.yawValue.Location = new System.Drawing.Point(376, 26);
            this.yawValue.Name = "yawValue";
            this.yawValue.Size = new System.Drawing.Size(31, 20);
            this.yawValue.TabIndex = 3;
            this.yawValue.Text = "0.00";
            this.yawValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yawValueChanged);
            // 
            // pitchValue
            // 
            this.pitchValue.AcceptsReturn = true;
            this.pitchValue.Location = new System.Drawing.Point(376, 70);
            this.pitchValue.Name = "pitchValue";
            this.pitchValue.Size = new System.Drawing.Size(31, 20);
            this.pitchValue.TabIndex = 4;
            this.pitchValue.Text = "0.00";
            this.pitchValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pitchValueChanged);
            // 
            // rollValue
            // 
            this.rollValue.AcceptsReturn = true;
            this.rollValue.Location = new System.Drawing.Point(376, 118);
            this.rollValue.Name = "rollValue";
            this.rollValue.Size = new System.Drawing.Size(31, 20);
            this.rollValue.TabIndex = 5;
            this.rollValue.Text = "0.00";
            this.rollValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rollValueChanged);
            // 
            // yawSlider
            // 
            this.yawSlider.Location = new System.Drawing.Point(167, 23);
            this.yawSlider.Maximum = 100;
            this.yawSlider.Minimum = -100;
            this.yawSlider.Name = "yawSlider";
            this.yawSlider.Size = new System.Drawing.Size(203, 45);
            this.yawSlider.TabIndex = 6;
            this.yawSlider.TickFrequency = 10;
            this.yawSlider.ValueChanged += new System.EventHandler(this.yawSliderMoved);
            // 
            // pitchSlider
            // 
            this.pitchSlider.Location = new System.Drawing.Point(167, 70);
            this.pitchSlider.Maximum = 100;
            this.pitchSlider.Minimum = -100;
            this.pitchSlider.Name = "pitchSlider";
            this.pitchSlider.Size = new System.Drawing.Size(203, 45);
            this.pitchSlider.TabIndex = 7;
            this.pitchSlider.TickFrequency = 10;
            this.pitchSlider.ValueChanged += new System.EventHandler(this.pitchSliderMoved);
            // 
            // rollSlider
            // 
            this.rollSlider.Location = new System.Drawing.Point(167, 118);
            this.rollSlider.Maximum = 100;
            this.rollSlider.Minimum = -100;
            this.rollSlider.Name = "rollSlider";
            this.rollSlider.Size = new System.Drawing.Size(203, 45);
            this.rollSlider.TabIndex = 8;
            this.rollSlider.TickFrequency = 10;
            this.rollSlider.ValueChanged += new System.EventHandler(this.rollSliderMoved);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(20, 23);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 171);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.rollSlider);
            this.Controls.Add(this.pitchSlider);
            this.Controls.Add(this.yawSlider);
            this.Controls.Add(this.rollValue);
            this.Controls.Add(this.pitchValue);
            this.Controls.Add(this.yawValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.yawSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox yawValue;
        private System.Windows.Forms.TextBox pitchValue;
        private System.Windows.Forms.TextBox rollValue;
        private System.Windows.Forms.TrackBar yawSlider;
        private System.Windows.Forms.TrackBar pitchSlider;
        private System.Windows.Forms.TrackBar rollSlider;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

