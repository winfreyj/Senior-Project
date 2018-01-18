using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_TEst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yawSliderMoved(object sender, EventArgs e)
        {
            yawValue.Text = (yawSlider.Value/10.00).ToString();
        }

        private void pitchSliderMoved(object sender, EventArgs e)
        {
            pitchValue.Text = (pitchSlider.Value/10.00).ToString();
        }

        private void rollSliderMoved(object sender, EventArgs e)
        {
            rollValue.Text = (rollSlider.Value/10.00).ToString();
        }

        private void yawValueChanged(object sender, KeyPressEventArgs e)
        {
            
        }

        private void pitchValueChanged(object sender, KeyPressEventArgs e)
        {

        }

        private void rollValueChanged(object sender, KeyPressEventArgs e)
        {

        }
    }
}
