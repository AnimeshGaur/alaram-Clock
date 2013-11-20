using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Net;
using System.IO;

namespace ModuleTester
{
    public partial class WeatherSetup : Form
    {
        public event EventHandler SetupFinished;
        public WeatherSetup(int zip)
        {
            InitializeComponent();
            numericUpDown1.Value = zip;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int woeid = -1;
            int zip = (int)numericUpDown1.Value;
            WebClient stanley = new WebClient();
            String geoXML = stanley.DownloadString("http://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20geo.places%20where%20text%3D%22Place%20" + zip + "%22&format=xml");
            using (XmlReader reader = XmlReader.Create(new StringReader(geoXML)))
            {
                String country = "";
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            if (reader.Name.Equals("country"))
                                country = reader.GetAttribute("code");
                            else if (reader.Name.Equals("postal") && reader.GetAttribute("type").Equals("Zip Code"))
                                if (country.Equals("US"))
                                    woeid = int.Parse(reader.GetAttribute("woeid"));
                            break;
                    }
                    if (woeid != -1)
                        break;
                }
            }
            if (woeid == -1)
                MessageBox.Show("Unable to find the zip code you specified. Maybe you typed it in incorrectly? Or you're a fagit");
            else
            {
                WeatherSetupArgs e1 = new WeatherSetupArgs();
                e1.Woeid = woeid;
                e1.Zip = zip;
                this.SetupFinished(this, e1);
                Close();
            }
        }
    }

    public class WeatherSetupArgs : EventArgs
    {
        private int woeid;
        private int zip;
        public int Woeid
        {
            get
            {
                return woeid;
            }
            set
            {
                woeid = value;
            }
        }
        public int Zip
        {
            get
            {
                return zip;
            }
            set
            {
                zip = value;
            }
        }
    }
}
