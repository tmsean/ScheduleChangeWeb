using System;

namespace ScheduleChange.Models.Config
{
    public class FlightConfigs
    {
        public int Id { get; set; }
        public string TableNbr { get; set; }
        public string Carrier { get; set; }
        public bool DomeIntl { get; set; }
        public int NumberOfCompartments { get; set; }
        public string EQPCode { get; set; }
        public int NumberOfClasses { get; set; }
        public int Cap1 { get; set; }
        public int Cap2 { get; set; }
        public int Cap3 { get; set; }
        public int Classes { get; set; }
        public string Remark { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
