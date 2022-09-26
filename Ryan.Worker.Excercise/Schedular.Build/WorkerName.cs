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
        }

        public DateTime getChargingStartTime()
        {
            return chargingStartDateTime;
        }

        public DateTime getChargingEndTime()
        {
            return chargingEndDateTime;
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
