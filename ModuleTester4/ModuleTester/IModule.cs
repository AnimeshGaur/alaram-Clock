using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ModuleTester
{
    public interface IModule
    {
        void Initialize(String name);
        void AccessSettings();
        string Message { get; }
        string getName();
        Image getIcon();
    }
}
