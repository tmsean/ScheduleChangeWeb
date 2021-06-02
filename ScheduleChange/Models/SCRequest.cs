using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace ScheduleChange.Models
{
    public class SCRequest
    {
        public int Id { get; set; }
        public string MessageId { get; set; }
        public string SCType { get; set; }
        public string Airline { get; set; }
        [Display(Name = "Số hiệu chuyến bay")]
        public string FlightNumber { get; set; }

        [Display(Name = "Ngày bay")]
        [BindProperty, DataType(DataType.Date)]
        public DateTime FlightDate { get; set; }

        [Display(Name = "Điểm đầu")]
        public string BoardPoint { get; set; }

        [Display(Name = "Điểm đến")]
        public string OffPoint { get; set; }

        [Display(Name = "Giờ khởi hành")]
        [BindProperty, DataType(DataType.Time)]
        public DateTime BoardTime { get; set; }

        [Display(Name = "Giờ kết thúc")]
        [BindProperty, DataType(DataType.Time)]
        public DateTime OffTime { get; set; }
        public int? Frequency { get; set; }
        [Range(-2, 2)]
        public int DayChangeIndicator { get; set; }
        public string EquipType { get; set; }
        public string EquipConfig { get; set; }
        public string SCReason { get; set; }
        public string Overbooking { get; set; }
        public string ProtectionPlan { get; set; }
        public string VIPNote { get; set; }
        public string OtherNote { get; set; }
    }
}
