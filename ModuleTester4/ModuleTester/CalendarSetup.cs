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
    public partial class CalendarSetup : Form
    {
        CalendarModule.Credentials cred;

        public CalendarSetup(CalendarModule.Credentials cred)
        {
            InitializeComponent();
            this.cred = cred;
            textBox1.Text = cred.user;
            textBox2.Text = cred.password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            cred.user = textBox1.Text;
            cred.password = textBox2.Text;
            base.OnFormClosed(e);
        }


        
    }
}
