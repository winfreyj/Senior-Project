using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Text;

namespace GUI_TEst
{
    public partial class Form1 : Form
    {
        TabPage[] tabs;
        public Form1()
        {
            InitializeComponent();
            tabs = new TabPage[] { camera1, camera2 };
            log.AppendText("Log\n");
            for(int i=0; i<=1000; i++)
            {
                StringBuilder temp = new StringBuilder();
                temp.Append(i);
                temp.Append("\n");
                UpdateLog(temp.ToString());
            }
            UpdateLog("12345678901234567890123456789012345678901234567890\n");
        }

        private void YawSliderMoved(object sender, EventArgs e)
        {
            if (sender.Equals(yawUpDown1))
            {
                yawUpDown1.Value = (decimal)(yawSlider1.Value / (double)yawSlider1.TickFrequency);
            }
            else
            {
                yawUpDown2.Value = (decimal)(yawSlider2.Value / (double)yawSlider2.TickFrequency);
            }
        }

        private void PitchSliderMoved(object sender, EventArgs e)
        {
            pitchUpDown1.Value = (decimal)(pitchSlider1.Value / (double)pitchSlider1.TickFrequency);
        }

        private void RollSliderMoved(object sender, EventArgs e)
        {
            rollUpDown1.Value = (decimal)(rollSlider1.Value / (double)rollSlider1.TickFrequency);
        }

        private void YawValueChanged(object sender, EventArgs e)
        {
            yawSlider1.Value = (int)(yawUpDown1.Value * 100);
        }

        private void PitchValueChanged(object sender, EventArgs e)
        {
            pitchSlider1.Value = (int)(pitchUpDown1.Value * 100);
        }

        private void RollValueChanged(object sender, EventArgs e)
        {
            rollSlider1.Value = (int)(rollUpDown1.Value * 100);
        }

        private void ChangeMotorTabs(object sender, EventArgs e)
        {
            int current, total;
            current = cameraTabs.TabPages.Count;
            total = (int)cameraCounter.Value;
            if (total > current)
            {
                for (int i = current; i < total; i++)
                    cameraTabs.TabPages.Add(tabs[i]);
            }
            else
            {
                for (int i = current; i > total; i--)
                    cameraTabs.TabPages.Remove(tabs[i - 1]);
            }
        }

        private void ManualOptions(object sender, EventArgs e)
        {
            if (sender.Equals(manualButton1))
            {
                rollSlider1.Enabled = true;
                pitchSlider1.Enabled = true;
                yawSlider1.Enabled = true;

                rollUpDown1.Enabled = true;
                pitchUpDown1.Enabled = true;
                yawUpDown1.Enabled = true;
            }
            else
            {
                rollSlider2.Enabled = true;
                pitchSlider2.Enabled = true;
                yawSlider2.Enabled = true;

                rollUpDown2.Enabled = true;
                pitchUpDown2.Enabled = true;
                yawUpDown2.Enabled = true;
            }
        }

        private void AutomaticOption(object sender, EventArgs e)
        {
            rollSlider1.Enabled = false;
            pitchSlider1.Enabled = false;
            yawSlider1.Enabled = false;

            rollUpDown1.Enabled = false;
            pitchUpDown1.Enabled = false;
            yawUpDown1.Enabled = false;
        }

        public void UpdateLog(string message)
        {
            log.AppendText(message);
        }
    }
}
