using System;

namespace ScheduleChange.Models.Config
{
    public class MealModel
    {
        public int Id { get; set; }
        public string Segment { get; set; }
        public DateTime FromTime { get; set; }
        public DateTime ToTime { get; set; }
        public string Compartment { get; set; }
        public string MealCode { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
