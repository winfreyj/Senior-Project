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
            int current, total;
            current = motorTabs.TabPages.Count;
            total = (int)cameraCounter.Value;
            if(total > current)
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

        private void manualOptions(object sender, EventArgs e)
        {

        }

        private void automaticOption(object sender, EventArgs e)
        {
            
        }
    }
}
