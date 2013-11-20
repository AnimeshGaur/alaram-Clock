using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModuleTester
{
    public partial class RSSSetup : Form
    {

        RSSModule sender;

        public RSSSetup(RSSModule sender)
        {
            this.sender = sender;
            InitializeComponent();
            Title.Text = sender.Title;
            this.URL.Text = sender.URI;
            
        }


        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            sender.Title = Title.Text;
            sender.URI = URL.Text;
            base.OnFormClosed(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
