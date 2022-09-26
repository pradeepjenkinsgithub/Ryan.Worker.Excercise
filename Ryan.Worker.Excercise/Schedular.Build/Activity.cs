using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryan.Worker.Excercise.Schedular.Build
{
    public interface IActivity
    {
        public abstract void start(DateTime startDateTimeActivity);
        public abstract void stop(DateTime stopDateTimeActivity);
        public abstract void Component_Worker_Info();
    }
}
