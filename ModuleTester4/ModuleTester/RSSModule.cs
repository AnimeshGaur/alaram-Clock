using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Net;
using System.Drawing;
using System.Windows.Forms;

namespace ModuleTester
{
    

    public class RSSModule : IModule
    { 
        public string Title;
        public string URI;

        public override string ToString()
        {
            return "RSS Feed: "+Title;
        }
        


        public void Initialize(string name)
        {
            Title = "Title";
            URI = "URL";
        }

        public void AccessSettings()
        {
            RSSSetup setupForm = new RSSSetup(this);
            setupForm.Show();
        }

        public string getName()
        {
            return "RSS";
        }

        

        public string Message
        {
            get
            {
                string output = "Headlines for ";
                string xmlsrc = URI;
                // Make Remote Request
                HttpWebRequest wr = (HttpWebRequest)WebRequest.Create(xmlsrc);



                // Set the HTTP properties
                wr.Timeout = 10000;
                // 10 seconds

                // Read the Response
                WebResponse resp = wr.GetResponse();
                Stream stream = resp.GetResponseStream();

                // Load XML Document
                XmlTextReader reader = new XmlTextReader(stream);
                reader.XmlResolver = null;
                XmlDocument doc = new XmlDocument();
                doc.Load(reader);
                var x = doc.GetElementsByTagName("title");
                var descriptions = doc.GetElementsByTagName("description");
                try
                {
                    for (int i = 0; i < 10; i++)
                    {
                        //make sure you don't just read the overall title
                        try
                        {
                            while (x[i].InnerText == Title || Title.Contains(x[i].InnerText)) i++;
                        }
                        catch (IndexOutOfRangeException)
                        {
                            return "";
                        }
                        output += x[i].InnerText + "\n";
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    throw;
                }
                return output;
            }
                
        }

        public Image getIcon()
        {
            return Image.FromFile(@"Icons\CalendarIcon.png");
        }
    }
}

