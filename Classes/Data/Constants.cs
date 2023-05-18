using System.IO;
using System;

namespace Acccount_Manager.Classes.Data
{
    internal static class Constants
    {
        internal static readonly string basePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Auto Login V2");
        internal static readonly string accountData = Path.Combine(basePath, "ACCOUNTDATA.json");
        internal static readonly string r3nzData = Path.Combine(basePath, "R3nzData.txt");
    }
}
