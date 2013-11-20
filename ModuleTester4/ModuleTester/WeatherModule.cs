using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Net;
using System.Drawing;

namespace ModuleTester
{
    class WeatherModule : IModule
    {
        int zip = 0;
        WebClient client;
        int woeid = -1;
        String name;
        String message = "This module has not been setup yet!";
        WeatherSetup setupForm;

        public void Initialize(String name)
        {
            this.name = name;
            client = new WebClient();
        }

        public void AccessSettings()
        {
            setupForm = new WeatherSetup(zip);
            setupForm.SetupFinished += new EventHandler(weathersetup_finished);
            setupForm.Show();
        }

        public string Message
        {
            get
            {
                if (woeid == -1) return "This module has not been set up yet.";
                String tempUnits = "";
                int temp = 0;
                String condition = "";
                String location = "";
                String weatherXML = client.DownloadString("http://weather.yahooapis.com/forecastrss?w=" + woeid);
                using (XmlReader reader = XmlReader.Create(new StringReader(weatherXML)))
                {
                    while (reader.Read())
                    {
                        switch (reader.NodeType)
                        {
                            case XmlNodeType.Element:
                                if (reader.Name.Equals("yweather:location"))
                                {
                                    location += reader.GetAttribute("city") + ", " + GetState(reader.GetAttribute("region"));
                                }
                                else if (reader.Name.Equals("yweather:units"))
                                {
                                    tempUnits += reader.GetAttribute("temperature");
                                }
                                else if (reader.Name.Equals("yweather:condition"))
                                {
                                    condition += reader.GetAttribute("text");
                                    temp = int.Parse(reader.GetAttribute("temp"));
                                }
                                break;
                        }
                    }
                }
                message = "";
                message += "In " + location + " it is currently " + condition + " and the temperature is " + temp + " " + tempUnits + ". ";
                if (temp <= 50) message += "Such cold. Better bundle up, because it's going to be cold.";
                else if (temp < 70 && temp > 50) message += "It's pretty cold, but not unbearable.";
                else if (temp >= 70 && temp < 80) message += "It's nice enough for shorts, maybe.";
                else if (temp >= 80 && temp < 100) message += "It's a scorcher, wear shorts and a t-shirt.";
                else if (temp >= 100) message += "Wow such hot. Good work nature. So fire.";

                return message;
            }
        }

        public void weathersetup_finished(object sender, EventArgs e)
        {
            woeid = ((WeatherSetupArgs)e).Woeid;
            zip = ((WeatherSetupArgs)e).Zip;
        }

        public override string ToString()
        {
            return name;
        }

        public string getName()
        {
            return "Weather";
        }

        public Image getIcon()
        {
            return Image.FromFile(@"Icons\WeatherIcon.png");
        }

        public string GetState(String postalCode)
        {
            switch (postalCode)
            {
                case "AL":
                    return "ALABAMA";

                case "AK":
                    return "ALASKA";

                case "AS":
                    return "AMERICAN SAMOA";

                case "AZ":
                    return "ARIZONA";

                case "AR":
                    return "ARKANSAS";

                case "CA":
                    return "CALIFORNIA";

                case "CO":
                    return "COLORADO";

                case "CT":
                    return "CONNECTICUT";

                case "DE":
                    return "DELAWARE";

                case "DC":
                    return "DISTRICT OF COLUMBIA";

                case "FM":
                    return "FEDERATED STATES OF MICRONESIA";

                case "FL":
                    return "FLORIDA";

                case "GA":
                    return "GEORGIA";

                case "GU":
                    return "GUAM";

                case "HI":
                    return "HAWAII";

                case "ID":
                    return "IDAHO";

                case "IL":
                    return "ILLINOIS";

                case "IN":
                    return "INDIANA";

                case "IA":
                    return "IOWA";

                case "KS":
                    return "KANSAS";

                case "KY":
                    return "KENTUCKY";

                case "LA":
                    return "LOUISIANA";

                case "ME":
                    return "MAINE";

                case "MH":
                    return "MARSHALL ISLANDS";

                case "MD":
                    return "MARYLAND";

                case "MA":
                    return "MASSACHUSETTS";

                case "MI":
                    return "MICHIGAN";

                case "MN":
                    return "MINNESOTA";

                case "MS":
                    return "MISSISSIPPI";

                case "MO":
                    return "MISSOURI";

                case "MT":
                    return "MONTANA";

                case "NE":
                    return "NEBRASKA";

                case "NV":
                    return "NEVADA";

                case "NH":
                    return "NEW HAMPSHIRE";

                case "NJ":
                    return "NEW JERSEY";

                case "NM":
                    return "NEW MEXICO";

                case "NY":
                    return "NEW YORK";

                case "NC":
                    return "NORTH CAROLINA";

                case "ND":
                    return "NORTH DAKOTA";

                case "MP":
                    return "NORTHERN MARIANA ISLANDS";

                case "OH":
                    return "OHIO";

                case "OK":
                    return "OKLAHOMA";

                case "OR":
                    return "OREGON";

                case "PW":
                    return "PALAU";

                case "PA":
                    return "PENNSYLVANIA";

                case "PR":
                    return "PUERTO RICO";

                case "RI":
                    return "RHODE ISLAND";

                case "SC":
                    return "SOUTH CAROLINA";

                case "SD":
                    return "SOUTH DAKOTA";

                case "TN":
                    return "TENNESSEE";

                case "TX":
                    return "TEXAS";

                case "UT":
                    return "UTAH";

                case "VT":
                    return "VERMONT";

                case "VI":
                    return "VIRGIN ISLANDS";

                case "VA":
                    return "VIRGINIA";

                case "WA":
                    return "WASHINGTON";

                case "WV":
                    return "WEST VIRGINIA";

                case "WI":
                    return "WISCONSIN";

                case "WY":
                    return "WYOMING";
            }

            throw new Exception("Not Available");
        }
    }
}
