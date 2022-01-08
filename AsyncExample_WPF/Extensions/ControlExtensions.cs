using System;
using System.Windows.Controls;

namespace AsyncExample_WPF
{
    public static class ControlExtensions
    {
        public static void Clear(this TextBlock text)
        {
            text.Text = String.Empty;
        }
    }
}
