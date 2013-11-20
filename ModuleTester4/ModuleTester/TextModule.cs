using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace ModuleTester
{
    class TextModule : IModule
    {
        String name;
        String text = "";
        TextSetup setupForm;

        public void Initialize(String name)
        {
            this.name = name;
        }

        public void AccessSettings()
        {
            setupForm = new TextSetup(text);
            setupForm.setupFinished += new EventHandler(textsetup_finished);
            setupForm.Show();
        }

        public string Message
        {
            get
            {
                return text;
            }
        }

        public void textsetup_finished(Object sender, EventArgs e)
        {
            text = ((TextSetupArgs)e).Text;
        }

        public override string ToString()
        {
            return name;
        }

        public string getName()
        {
            return "Text";
        }

        public Image getIcon()
        {
            return Image.FromFile(@"Icons\TextIcon.png");
        }
    }
}
