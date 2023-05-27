using System;
using System.Windows.Forms;

namespace Account_Manager.Classes.Utility
{
    internal class Logger
    {
        private static ListBox logListBox;

        public static void Initialize(ListBox listBox)
        {
            logListBox = listBox;
        }

        internal static void LogEvent(string message)
        {
            string logEntry = $"{DateTime.Now} | {message}";
            logListBox.Items.Add(logEntry);
            logListBox.TopIndex = logListBox.Items.Count - 1;
        }
    }
}
