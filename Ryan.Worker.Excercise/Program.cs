using Ryan.Worker.Excercise.Schedular.Activity;
using Ryan.Worker.Excercise.Schedular.Build;
using System;
using System.Data;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

internal class Program
{

    private static void Main(string[] args)
    {
        try
        {
            DateTime ActivityStartDate = new DateTime(2022, 10, 10).AddHours(9);
            DateTime ActivityEndDate = new DateTime(2022, 10, 10).AddHours(17);
            WorkerName _worker = new WorkerName("Pradeep");
            BuildComponentActivity buildComponentActivity = new BuildComponentActivity(ActivityStartDate, ActivityEndDate);
            SchedularActivity.ScheduleComponent(buildComponentActivity, _worker);
            List<WorkerName> workers = new List<WorkerName>();
            AddWorker(workers);
            BuildMachineActivity buildMachineActivity = new BuildMachineActivity(workers, ActivityStartDate, ActivityEndDate);
            SchedularActivity.scheduleMachine(buildMachineActivity, workers);
            Console.ReadLine();
        }
        catch (Exception)
        {
            throw;
        }
    }

    private static void AddWorker(List<WorkerName> lstWorkers)
    {
        lstWorkers.Add(new WorkerName("Dia"));
        lstWorkers.Add(new WorkerName("Daiwik"));
        lstWorkers.Add(new WorkerName("Chetana"));
        lstWorkers.Add(new WorkerName("Pradeep. G"));
    }
}