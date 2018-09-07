using System;
using System.Threading;
using Timer = System.Timers.Timer;

namespace ThreadException
{
    public class Class1
    {
        public Class1()
        {
            Thread.GetDomain().UnhandledException += (sender, args) =>
            {
                Exception ex = (Exception) args.ExceptionObject;
                throw ex;
            };
        }
        public void Timeout()
        {
            const int timeoutMsec = 100;
            var timeouttimer = new Timer(timeoutMsec);
            timeouttimer.Elapsed += (sender, args) =>
            {
                timeouttimer.Stop();
                throw new TimeoutException();
            };
        }
        }
}
