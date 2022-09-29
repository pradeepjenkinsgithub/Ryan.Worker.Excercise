using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ryan.Worker.Excercise.Schedular.Build
{
    public class BuildMachineActivity : IActivity
    {
        public WorkerName WorkerName { get; set; }
        public List<WorkerName> workers;
        
        public DateTime _startTime { get; set; }
        public DateTime _endTime { get; set; }

        //  public DateTime _Total_Work_Hours { get; set; }

        public BuildMachineActivity(List<WorkerName> workers, DateTime startDate, DateTime endDate)
        {
            _startTime = startDate;
            _endTime = endDate;
        }

        public void SetWorker(List<WorkerName> _Workers)
        {
            if (workers == null)
                workers = _Workers;
               //WorkerName = workerMans;
            notifyWorkers();
        }

        private void notifyWorkers()
        {
            workers.ForEach(worker =>
            {
                worker.setChargingStartTime(_endTime);
                worker.setChargingEndTime(_endTime.AddHours(4));
            });
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
            Console.WriteLine("Type of Activity : Machine");
            Console.WriteLine("Machine start time " + _startTime);
            Console.WriteLine("Machine end time " + _endTime);
            workers.ForEach(i => Console.WriteLine("Machine worker name : {0}\t", i));
        }
    }
}
