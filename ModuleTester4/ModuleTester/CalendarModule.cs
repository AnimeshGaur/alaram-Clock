using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Google.GData.Calendar;
using System.Drawing;

namespace ModuleTester
{
    public class CalendarModule : IModule
    {
        EventFeed feed;
        Credentials credentials;

        public void Initialize(string s)
        {
            credentials = new Credentials();
            credentials.user = "";
            credentials.password = "";
        }

        public string Message
        {
            get
            {
                CalendarService service = new CalendarService("serv");
                service.setUserCredentials(credentials.user, credentials.password);

                // Create the query object:
                EventQuery query = new EventQuery();
                query.Uri = new Uri("https://www.google.com/calendar/feeds/" + credentials.user + "/private/full");

                query.StartDate = DateTime.Now -TimeSpan.FromDays(10);
                query.NumberToRetrieve = 1;


                string output = "Your next appointment is:\n";
                // Tell the service to query:
                try
                {
                    feed = service.Query(query);

                    foreach (EventEntry e in feed.Entries)
                        output += e.Title.Text + "\n";
                    return output;
                }
                catch
                { output += "Could not return"; }
                return output;
            }
        }

        public string getName() { return "Calendar"; }



        public void AccessSettings()
        {
            CalendarSetup setup = new CalendarSetup(credentials);
            setup.Show();
        }

        public class Credentials { public string user, password; }

        public Image getIcon()
        {
            return Image.FromFile(@"Icons\CalendarIcon.png");
        }
    }
}
