using Microsoft.VisualStudio.TestPlatform.TestHost;
using Ryan.Worker.Excercise.Schedular.Build;
using NUnit.Framework;
using Ryan.Worker.Excercise.Schedular.Test;
using Ryan.Worker.Excercise.Schedular.Activity;
namespace Ryan.Worker.NUnit.Test
{
    // Test workers
    public class Tests
    {
        private readonly List<WorkerName>? lstWorkers;

        [SetUp]
        public void Setup()
        {
            should_not_throw_error_when_worker_is_in_charging_state();
            should_not_throw_error_when_worker_is_in_not_charging_state();
        }

        [Test]
        public void should_not_throw_error_when_worker_is_in_charging_state()
        {
            DateTime ActivityStartDate = new DateTime(2022, 10, 10).AddHours(9);
            DateTime ActivityEndDate = new DateTime(2022, 10, 10).AddHours(17);

            BuildComponentActivity activity = new BuildComponentActivity(ActivityStartDate, ActivityEndDate); //Convert.ToDateTime(activityStartTime), Convert.ToDateTime(ActivityEndDate));
            WorkerName worker = new WorkerName("A");
            SchedularActivity.ScheduleComponent(activity, worker);

            Assert.AreEqual("A", worker.component_Worker_Name);
            Assert.That(worker.chargingStartDateTime.ToString("dd-MM-yyyy HH"), Is.EqualTo(ActivityStartDate.AddHours(9).ToString("dd-MM-yyyy HH")));
            Assert.That(worker.chargingEndDateTime.ToString("dd-MM-yyyy HH"), Is.EqualTo(ActivityEndDate.AddHours(17).ToString("dd-MM-yyyy HH")));

            BuildComponentActivity secondActivity = new BuildComponentActivity(ActivityStartDate.AddHours(5), ActivityEndDate.AddHours(9));
            SchedularActivity.ScheduleComponent(secondActivity, worker);

            Assert.That(worker.component_Worker_Name, Is.EqualTo("A"));
            Assert.That(worker.chargingStartDateTime.ToString("dd-MM-yyyy HH"), Is.EqualTo(ActivityStartDate.AddHours(5).ToString("dd-MM-yyyy HH")));
            Assert.That(worker.chargingEndDateTime.ToString("dd-MM-yyyy HH"), Is.EqualTo(ActivityEndDate.AddHours(5).ToString("dd-MM-yyyy HH")));
            // Assert.Throws<ArgumentException>(() => SchedularActivity.ScheduleComponent(secondActivity, worker));
        }

        [Test]
        public void should_not_throw_error_when_worker_is_in_not_charging_state()
        {
            DateTime ActivityStartDate = new DateTime(2022, 10, 10).AddHours(9);
            DateTime ActivityEndDate = new DateTime(2022, 10, 10).AddHours(17);
            BuildComponentActivity activity = new BuildComponentActivity(ActivityStartDate, ActivityEndDate);
            WorkerName worker = new WorkerName("A");
            Assert.Throws<ArgumentException>(() => SchedularActivity.ScheduleComponent(activity, worker));


            //lstWorkers.Add(new WorkerName("Dia"));
            //lstWorkers.Add(new WorkerName("Daiwik"));
            //lstWorkers.Add(new WorkerName("Chetana"));
            //lstWorkers.Add(new WorkerName("Pradeep. G"));
            //CollectionAssert.AllItemsAreUnique(lstWorkers);
        }
    }

}