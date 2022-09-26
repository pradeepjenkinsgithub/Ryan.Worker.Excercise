using Microsoft.VisualStudio.TestPlatform.TestHost;
using Ryan.Worker.Excercise.Schedular.Build;

namespace Ryan.Worker.NUnit.Test
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Worker_Is_In_Charger_State()
        {
            try
            {
                DateTime activityStartTime = DateTime.Now.AddYears(2022).AddMonths(9).AddDays(22).AddHours(13).AddMinutes(0).AddSeconds(0);
                DateTime activityEndTime = DateTime.Now.AddYears(2022).AddMonths(9).AddDays(22).AddHours(1).AddMinutes(0).AddSeconds(0);
                BuildComponentActivity activity = new BuildComponentActivity(activityStartTime, activityEndTime);
                var workerName = WorkerName("A");
               
                BuildComponentActivity secondActivity = new BuildComponentActivity(activityStartTime.plusHours(1), activityEndTime.plusHours(1));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }


}