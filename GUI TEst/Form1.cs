using System;
using System.Windows.Forms;

namespace GUI_TEst
{
    public partial class Form1 : Form
    {
        TabPage[] tabs;
        public Form1()
        {
            InitializeComponent();
            tabs = new TabPage[] { motor1 }; /*, motor2, motor3, motor4, motor5 };
            motorTabs.TabPages.Remove(motor10);
            motorTabs.TabPages.Remove(motor9);
            motorTabs.TabPages.Remove(motor8);
            motorTabs.TabPages.Remove(motor7);
            motorTabs.TabPages.Remove(motor6);
            motorTabs.TabPages.Remove(motor5);
            motorTabs.TabPages.Remove(motor4);
            motorTabs.TabPages.Remove(motor3);
            motorTabs.TabPages.Remove(motor2);*/

        }

        private void YawSliderMoved(object sender, EventArgs e)
        {
            yawValue.Value = (decimal)(yawSlider.Value / 100.00);
        }

        private void PitchSliderMoved(object sender, EventArgs e)
        {
            pitchValue.Value = (decimal)(pitchSlider.Value / 100.00);
        }

        private void RollSliderMoved(object sender, EventArgs e)
        {
            rollValue.Value = (decimal)(rollSlider.Value / 100.00);
        }

        private void YawValueChanged(object sender, EventArgs e)
        {
            yawSlider.Value = (int)(yawValue.Value * 100);
        }

        private void PitchValueChanged(object sender, EventArgs e)
        {
            pitchSlider.Value = (int)(pitchValue.Value * 100);
        }

        private void RollValueChanged(object sender, EventArgs e)
        {
            rollSlider.Value = (int)(rollValue.Value * 100);
        }

        private void ChangeMotorTabs(object sender, EventArgs e)
        {
            int current, total;
            current = motorTabs.TabPages.Count;
            total = (int)cameraCounter.Value;
            if (total > current)
            {
                for (int i = current; i < total; i++)
                    motorTabs.TabPages.Add(tabs[i]);
            }
            else
            {
                for (int i = current; i > total; i--)
                    motorTabs.TabPages.Remove(tabs[i - 1]);
            }
        }

        private void ManualOptions(object sender, EventArgs e)
        {
            trackBar1.Enabled = true;
            trackBar2.Enabled = true;
            trackBar3.Enabled = true;

            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
        }

        private void AutomaticOption(object sender, EventArgs e)
        {
            trackBar1.Enabled = false;
            trackBar2.Enabled = false;
            trackBar3.Enabled = false;

            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            numericUpDown3.Enabled = false;

            for (int i = trackBar1.Value; i <= 800; i += 1)
            {
                trackBar1.Value = i;
                numericUpDown1.Value = (decimal)(trackBar1.Value / 100.00);
                numericUpDown1.Update();
                for (int j = 0; j < 1000000; j++) ;
            }

            for (int i = trackBar2.Value; i >= -500; i -= 1)
            {
                trackBar2.Value = i;
                numericUpDown2.Value = (decimal)(trackBar2.Value / 100.00);
                numericUpDown2.Update();
                for (int j = 0; j < 1000000; j++) ;
            }

            for (int i = trackBar3.Value; i <= 150; i += 1)
            {
                trackBar3.Value = i;
                numericUpDown3.Value = (decimal)(trackBar3.Value / 100.00);
                numericUpDown3.Update();
                for (int j = 0; j < 1000000; j++) ;
            }
        }

        private void FillElementHost()
        {
            
        }
    }
}
