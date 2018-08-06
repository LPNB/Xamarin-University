using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculator
{
    // TODO #10 : 
        // create shared resources file
        // create a sample resource
        // wire up sample resource to MainPage.xaml
    class SharedResources
    {
        // sample resource for Operation button background color
        public static Color OpButtonBkColor
        {
            get { return Color.FromRgb(0xff, 0xa5, 0); }
        }
    }
}
