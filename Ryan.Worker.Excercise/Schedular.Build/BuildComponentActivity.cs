using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ryan.Worker.Excercise.Schedular.Build
{
    public class BuildComponentActivity : IActivity
    {
        public WorkerName worker { get; set; }
        public DateTime _startTime { get; set; }
        public DateTime _endTime { get; set; }
        public DateTime _Total_Work_Hours { get; set; }

        public BuildComponentActivity(DateTime startDate, DateTime endDate)
        {
            _startTime = startDate;
            _endTime = endDate;
        }

        public void SetWorker(WorkerName _Worker)
        {
            if (worker == null)
                worker = _Worker;
            NotifyWorker();
        }

        private void NotifyWorker()
        {
            worker.setChargingStartTime(_endTime);
            worker.setChargingEndTime(_startTime.AddHours(2));
        }

        public void start(DateTime startDateTimeActivity)
        {
            _startTime = startDateTimeActivity;
        }

        public void stop(DateTime stopDateTimeActivity)
        {
            _endTime = stopDateTimeActivity;
        }

        public DateTime getStartDateTime()
        {
            return _startTime;
        }

        public DateTime getEndDateTime()
        {
            return _endTime;
        }

        public void Component_Worker_Info()
        {
            Console.WriteLine("Type of Activity : Component");
            Console.WriteLine("Component start time " + _startTime);
            Console.WriteLine("Component end time " + _endTime);
            Console.WriteLine("Component worker name " + worker.component_Worker_Name);
        }
    }
}
