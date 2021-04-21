using System;
using System.Diagnostics;

namespace src{

    class ProcessHandler
    {
        public void ProcessHandle()
        {
           ProcessStartInfo startInfo = new ProcessStartInfo();    
            string executeCommand = "java MainMaker.java";

            Process proc = new Process();
            
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "CMD.exe";
            startInfo.Arguments = "/c java MainMaker.java";
            

            
            
            
            
           Process.Start(startInfo);
        }
        public void ProcessWritePadUI()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "CMD.exe";
            startInfo.Arguments = "/c java WritePad.java";
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            Process.Start(startInfo);
        }
    }
}