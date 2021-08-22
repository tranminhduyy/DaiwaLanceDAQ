using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.ComponentModel;

namespace Kill_Excel
{
    class Program
    {
        static void Main(string[] args)
        {

            foreach (Process clsProcess in Process.GetProcesses())
                if (clsProcess.ProcessName.Equals("EXCEL"))  //Process Excel?
                    clsProcess.Kill();
        }
    }
}