using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gymWebApplication.utilites
{
    public class Logger
    {
        public void Log(string message)
        {
            System.Diagnostics.Debug.Print(message);
        }
    }
}