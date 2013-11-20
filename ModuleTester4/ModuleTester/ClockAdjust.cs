using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuleTester
{
    public partial class ClockAdjust : Form
    {
        public event EventHandler adjustFinished;
        public ClockAdjust(int minute, int hour)
        {
            InitializeComponent();
            if (numericUpDown1.Value > 12) checkBox1.Checked = true;
            numericUpDown1.Value = hour % 12;
            if (numericUpDown1.Value == 0) numericUpDown1.Value = 12;
            numericUpDown2.Value = minute;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClockArgs e1 = new ClockArgs();
            e1.Hour = (int) numericUpDown1.Value;
            if (e1.Hour == 12) e1.Hour = 0;
            if (checkBox1.Checked) e1.Hour += 12;
            e1.Minute = (int) numericUpDown2.Value;
            adjustFinished(this, e1);
            Close();
        }
    }
    public class ClockArgs : EventArgs
    {
        private int minute;
        private int hour;
        public int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                minute = value;
            }
        }
        public int Hour
        {
            get
            {
                return hour;
            }
            set
            {
                hour = value;
            }
        }
    }
}
