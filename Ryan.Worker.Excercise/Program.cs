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

        WorkerName _worker = new WorkerName("Pradeep");
        BuildComponentActivity buildComponentActivity = new BuildComponentActivity(DateTime.Now, DateTime.Now.AddHours(5));
        SchedularActivity.ScheduleComponent(buildComponentActivity,_worker);
        List<WorkerName> workers = new List<WorkerName>();
        AddWorker(workers);
        BuildMachineActivity buildMachineActivity = new BuildMachineActivity(workers,DateTime.Now, DateTime.Now.AddHours(10));          
    }

    private static void AddWorker(List<WorkerName> lstWorkers)
    {
        lstWorkers.Add(new WorkerName("Dia"));
        lstWorkers.Add(new WorkerName("Daiwik"));
        lstWorkers.Add(new WorkerName("Chetana"));
        lstWorkers.Add(new WorkerName("Pradeep. G"));
        
    }
}