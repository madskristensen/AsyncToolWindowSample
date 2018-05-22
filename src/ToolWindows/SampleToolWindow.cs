using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Imaging;
using Microsoft.VisualStudio.Shell;

namespace AsyncToolWindowSample.ToolWindows
{
    [Guid(WindowGuidString)]
    public class SampleToolWindow : ToolWindowPane
    {
        public const string WindowGuidString = "e4e2ba26-a455-4c53-adb3-8225fb696f8b";
        public const string Title = "Sample Tool Window";

        public SampleToolWindow(SampleToolWindowState state)
            : base()
        {
            Caption = Title;
            BitmapImageMoniker = KnownMonikers.ImageIcon;

            var elm = new SampleToolWindowControl(state);
            Content = elm;
        }
    }
}
