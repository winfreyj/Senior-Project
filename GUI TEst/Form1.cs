using System;
using System.Windows.Forms;

namespace GUI_TEst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void YawSliderMoved(object sender, EventArgs e)
        {
            yawValue.Text = (yawSlider.Value/100.00).ToString();
        }

        private void PitchSliderMoved(object sender, EventArgs e)
        {
            pitchValue.Text = (pitchSlider.Value/100.00).ToString();
        }

        private void RollSliderMoved(object sender, EventArgs e)
        {
            rollValue.Text = (rollSlider.Value/100.00).ToString();
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
            TabPage[] tabs = new TabPage[] { motor1, motor2, motor3, motor4, motor5 };
            int current, total;
            current = motorTabs.TabPages.Count;
            total = (int)cameraCounter.Value;
            if(total > current)
            {
                for (int i = current; i < total; i++)
                    tabs[i].Show();
            }
            else
            {
                for (int i = current; i > total; i--)
                    tabs[i - 1].Hide();
            }
        }
    }
}
