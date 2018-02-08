using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace TopShelfCWS
{
    public class NameMeAnything : ServiceControl
    {
        private System.Timers.Timer _timer = new System.Timers.Timer();

        public bool Start(HostControl hostControl)
        {
            Console.WriteLine("The Service was Started!");

            // Do something custom here.
            _timer.Interval = 1000;
            _timer.Elapsed += _timer_Elapsed;
            _timer.Start();

            return true;
        }

        private void _timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("Thank you for spending this second of your life reading my article.");
        }

        public bool Stop(HostControl hostControl)
        {
            Console.WriteLine("The Service was Stopped!");
            _timer.Stop();
            return true;
        }
    }
}
