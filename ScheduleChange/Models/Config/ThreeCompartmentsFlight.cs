using System;

namespace ScheduleChange.Models.Config
{
    public class ThreeCompartmentsFlight
    {
        public int Id { get; set; }
        public string FlightNumber { get; set; }
        public DateTime DepDateFrom { get; set; }
        public DateTime DepDateTo { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
