using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Threading;

namespace ModuleTester
{
    public partial class Form1 : Form
    {
        private bool alarmAlreadyPlayed = false;
        private DateTime now = DateTime.Now;
        private DateTime alarmTime;
        private List<Type> types;
        private SpeechSynthesizer reader;
        private int currentReadingIndex;
        string tickerText = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Type interfaceType = typeof(IModule);
            types = AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes()).Where(p => interfaceType.IsAssignableFrom(p)).ToList();
            types.Remove(typeof(IModule));
            for (int i = 0; i < types.Count; i++)
            {
                IModule tempModule = (IModule)Activator.CreateInstance(types[i]);
                listBox1.Items.Insert(i, tempModule.getName());
            }
            listBox1.SelectedIndex = 0;
            alarmTime = new DateTime(now.Year, now.Month, now.Day, 7, 0, 0);
            label1.Text = alarmTime.TimeOfDay.ToString();
            alarmTimer.Enabled = true;
        }

        private void btn_AddModule_Click(object sender, EventArgs e)
        {
            IModule module = (IModule)Activator.CreateInstance(types[listBox1.SelectedIndex]);
            module.Initialize(module.GetType().ToString());
            module.AccessSettings();
            listBox2.Items.Add(module);
            picBox_ImgTest.Image = module.getIcon();
            numericUpDown2.Maximum++;
        }

        private void btn_EditModule_Click(object sender, EventArgs e)
        {
            try
            {
                ((IModule)listBox2.Items[listBox2.SelectedIndex]).AccessSettings();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please specify a module to edit!");
            }
        }

        private void btn_PlayModulesInSequence_Click(object sender, EventArgs e)
        {
            readModules();
        }

        private void btn_MoveUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox2.SelectedIndex > 0)
                {
                    Object temp = listBox2.Items[listBox2.SelectedIndex - 1];
                    listBox2.Items[listBox2.SelectedIndex - 1] = listBox2.Items[listBox2.SelectedIndex];
                    listBox2.Items[listBox2.SelectedIndex] = temp;
                    listBox2.SelectedIndex--;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please specify a module to move!");
            }
        }

        private void btn_MoveDown_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox2.SelectedIndex < listBox2.Items.Count - 1)
                {
                    Object temp = listBox2.Items[listBox2.SelectedIndex];
                    listBox2.Items[listBox2.SelectedIndex] = listBox2.Items[listBox2.SelectedIndex + 1];
                    listBox2.Items[listBox2.SelectedIndex + 1] = temp;
                    listBox2.SelectedIndex++;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please specify a module to move!");
            }
        }

        private void btn_ChangeTime_Click(object sender, EventArgs e)
        {
            ClockAdjust adjustForm = new ClockAdjust(alarmTime.Minute, alarmTime.Hour);
            adjustForm.adjustFinished += new EventHandler(clockadjust_finished);
            adjustForm.Show();
        }

        private void clockadjust_finished(object sender, EventArgs e)
        {
            alarmTime = new DateTime(now.Year, now.Month, now.Day, ((ClockArgs)e).Hour, ((ClockArgs)e).Minute, 0);
            label1.Text = alarmTime.TimeOfDay.ToString();
        }

        private void alarmTimer_Tick(object sender, EventArgs e)
        {
            now = DateTime.Now;
            if (alarmTime.Hour == now.Hour && alarmTime.Minute == now.Minute)
            {
                if (!alarmAlreadyPlayed)
                {
                    alarmAlreadyPlayed = true; 
                    readModules();
                }
            }
            else
            {
                alarmAlreadyPlayed = false;
            }
        }

        private void addDelayBtn_Click(object sender, EventArgs e)
        {
            listBox3.Items.Add(new Delay(1000, -1));
            label3.Visible = true;
            label4.Visible = true;
            listBox3.SelectedIndex = listBox3.Items.Count - 1;
            numericUpDown1.Visible = true;
            numericUpDown2.Visible = true;
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = ((Delay)listBox3.Items[listBox3.SelectedIndex]).Amount;
            numericUpDown2.Value = ((Delay)listBox3.Items[listBox3.SelectedIndex]).Index;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                listBox2.Items.Remove(listBox2.Items[listBox2.SelectedIndex]);
                numericUpDown2.Maximum--;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please specify a module to remove!");
            }
        }

        private void btnRemoveDelay_Click(object sender, EventArgs e)
        {
            try
            {
                listBox3.Items.Remove(listBox3.Items[listBox3.SelectedIndex]);
                if (listBox3.Items.Count == 0)
                {
                    label3.Visible = false;
                    label4.Visible = false;
                    numericUpDown1.Visible = false;
                    numericUpDown2.Visible = false;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                if (listBox3.Items.Count == 0)
                {
                    label3.Visible = false;
                    label4.Visible = false;
                    numericUpDown1.Visible = false;
                    numericUpDown2.Visible = false;
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ((Delay)listBox3.Items[listBox3.SelectedIndex]).Amount = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            ((Delay)listBox3.Items[listBox3.SelectedIndex]).Index = (int)numericUpDown2.Value;
        }

        private void readModules()
        {
            reader = new SpeechSynthesizer();
            currentReadingIndex = 0;
            tickerText = "                                                                                                                                      ";
            if (listBox2.Items.Count > currentReadingIndex)
                readModule(currentReadingIndex);
            tickerTimer.Start();
        }

        private void readModule(int index)
        {
            currentReadingIndex = index;
            for (int i = 0; i < listBox3.Items.Count; i++)
            {
                Delay delay = (Delay)listBox3.Items[i];
                if (delay.Index == index - 1)
                    Thread.Sleep(delay.Amount);
            }
            String message = ((IModule)listBox2.Items[index]).Message;
            reader.SpeakAsync(message);
            tickerText += "* " + message + " ";
            reader.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(reader_SpeakCompleted);
        }

        private void reader_SpeakCompleted (object sender, SpeakCompletedEventArgs e)
        {
            currentReadingIndex++;
            if (listBox2.Items.Count > currentReadingIndex)
                readModule(currentReadingIndex);
        }

        private void tickerTimer_Tick(object sender, EventArgs e)
        {
            lbl_ticker.Text = tickerText;
            if (tickerText.Length >= 1)
            {
                tickerText = tickerText.Substring(1);
            }
            else 
            {
                tickerText = "";
                tickerTimer.Stop();
            }
        }
    }
}
