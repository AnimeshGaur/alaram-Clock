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
    public partial class TextSetup : Form
    {
        public EventHandler setupFinished;
        public TextSetup(String initialString)
        {
            InitializeComponent();
            richTextBox1.Text = initialString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String text = richTextBox1.Text;
            TextSetupArgs e1 = new TextSetupArgs();
            e1.Text = text;
            setupFinished(this, e1);
            Close();
        }
    }

    public class TextSetupArgs : EventArgs
    {
        private string text = "";
        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
            }
        }
    }
}
