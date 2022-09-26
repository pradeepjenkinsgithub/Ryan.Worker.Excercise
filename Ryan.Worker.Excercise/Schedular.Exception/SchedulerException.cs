using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryan.Worker.Excercise.Schedular
{
    public class SchedulerException : Exception
    {
        public SchedulerException(string? message) : base(message)
        {
            Console.WriteLine("Exceptoion: " + message);
        }
    }
}
