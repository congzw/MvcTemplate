using System;
using System.Diagnostics;

namespace Demos.Common.Themes
{
    public class ThemeLogger
    {
        public static Action<object> LogFunc = (message) =>
        {
            Debug.WriteLine(message);
        }; 

        public static void Log(object message)
        {
            if (!Enabled)
            {
                return;
            }
            LogFunc("[ThemeLogger] => " + message);
        }

        public static bool Enabled { get; set; }
        static ThemeLogger()
        {
            Enabled = true;
        }
    }
}
