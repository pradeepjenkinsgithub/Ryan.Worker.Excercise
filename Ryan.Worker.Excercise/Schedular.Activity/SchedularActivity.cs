

using Ryan.Worker.Excercise.Schedular.Build;

namespace Ryan.Worker.Excercise.Schedular.Activity
{
    public class SchedularActivity
    {

        //Cannot Schedule If there is Exception
        private static Boolean CannotSchedule(DateTime activityStartTime, DateTime activityEndTIme, WorkerName _worker)
        {
            if (_worker.getChargingStartTime() == null || _worker.getChargingEndTime() == null)
            {
                return false;
            }
            else if (_worker.chargingStartDateTime <= activityStartTime && _worker.chargingEndDateTime >= activityEndTIme)
            {
                return true;
            }
            else { return false; }
        }

        //Schedule Activity For Buidling Component
        public static void ScheduleComponent(BuildComponentActivity buildComponentActivity, WorkerName _worker)
        {
            DateTime workerStartTime = buildComponentActivity.getStartDateTime();
            DateTime workerEndTime = buildComponentActivity.getEndDateTime();
            if (CannotSchedule(workerStartTime, workerEndTime, _worker))
            {
                throw new SchedulerException("Cannot schedule a component job");
            }
            else
            {
                buildComponentActivity.SetWorker(_worker);
                Console.WriteLine(_worker.component_Worker_Name + " finished an activity of building a component!! Now, will charge/rest for 2 hours. \n\t ");
            }
        }

        //Schedule Activity for buidling machine

        public static void scheduleMachine(BuildMachineActivity buildMachineActivity, List<WorkerName> _lstOfWorkers)
        {
            if (buildMachineActivity is null)
            {
                throw new ArgumentNullException(nameof(buildMachineActivity));
            }

            if (_lstOfWorkers is null)
            {
                throw new ArgumentNullException(nameof(_lstOfWorkers));
            }

            DateTime machineStartTime = buildMachineActivity.getStartDateTime();
            DateTime machineEndTime = buildMachineActivity.getEndDateTime();
            foreach (var workers in _lstOfWorkers)
            {
                if (CannotSchedule(machineStartTime, machineEndTime, workers))
                {
                    throw new SchedulerException("Cannot schedule a Machine component job");
                }
                else
                {
                    buildMachineActivity.SetWorker(_lstOfWorkers);
                    Console.WriteLine( workers.component_Worker_Name + " finished an activity of building a machine!! Now, will charge/rest for 4 hours.\n  ");
                }
            }
        }
    }
}
