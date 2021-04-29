using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HomeExpenseUI.Datbase
{
    public static class LoginInfo
    {
        public static string UserName=null;
        public static string Password=null;
        public static string VersionIndepedentAppDataPath => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), @"CommonFiles");
    }
}
