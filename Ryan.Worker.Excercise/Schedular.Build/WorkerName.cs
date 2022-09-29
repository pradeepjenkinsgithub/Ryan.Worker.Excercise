namespace Ryan.Worker.Excercise.Schedular.Build
{
    public class WorkerName
    {
        public string component_Worker_Name { get; set; }
        public DateTime chargingStartDateTime { get; set; }
        public DateTime chargingEndDateTime { get; set; }

        public WorkerName(string _component_Worker_Name)
        {
            component_Worker_Name = _component_Worker_Name;
            this.chargingStartDateTime = new DateTime(2022, 10, 10).AddHours(10); //DateTime.Now.AddHours(1);
            this.chargingEndDateTime = new DateTime(2022, 10, 10).AddHours(16); //DateTime.Now.AddHours(8);
        }

        public DateTime getChargingStartTime()
        {
            return chargingStartDateTime;//chargingStartDateTime.ToLocalTime();
        }

        public DateTime getChargingEndTime()
        {
            return chargingEndDateTime;//DateTime.Now.AddHours(9);//chargingEndDateTime.ToLocalTime().AddHours(9);
        }

        public DateTime setChargingStartTime(DateTime chargingStartDateTime)
        {
            this.chargingStartDateTime = chargingStartDateTime;
            return chargingStartDateTime;
        }

        public DateTime setChargingEndTime(DateTime chargingStartDateTime)
        {
            this.chargingStartDateTime = chargingStartDateTime;
            return chargingStartDateTime;
        }

        public static implicit operator List<object>(WorkerName v)
        {
            throw new NotImplementedException();
        }
    }
}
