using System;
using System.Diagnostics;

namespace src
{
    class ShiroReceiver
    {
        public void ErrorSignalReceiver(string whattoinvoke, int errorstring)
        {
            if(whattoinvoke == "Kuroi not invoked")
            {
                var errorinfo = new ErrorInfo();
                errorinfo.ErrorInfoContainer(errorstring);
                  
            }else if(whattoinvoke == "Invoke Kuroi") // This is used for invoking Kuroi when a serious error has occured
            {
                       // Kuroi is currently in developement and will be added in a later version
            }
        }
        

        
        
    }
}