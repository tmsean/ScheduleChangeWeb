using System;

namespace ScheduleChange.Data
{
    public class SCCRequest
    {
        public int Id { get; set; }
        public string MessageId { get; set; }
        public string SCType { get; set; }
        public string Airline { get; set; }
        public string FlightNumber { get; set; }
        public DateTime FlightDate { get; set; }
        public string BoardPoint { get; set; }
        public string OffPoint { get; set; }
        public DateTime BoardTime { get; set; }
        public DateTime OffTime { get; set; }
        public int Frequency { get; set; }
        public int DayChangeIndicator { get; set; }
        public string EquipType { get; set; }
        public string EquipConfig { get; set; }
        public string SCReason { get; set; }
        public string Overbooking { get; set; }
        public string ProtectionPlan { get; set; }
        public string VIPNote { get; set; }
        public string OtherNote { get; set; }
        //public bool IsSendSabre { get; set; }
        //public bool IsRemarkPNR { get; set; }

    }
}
