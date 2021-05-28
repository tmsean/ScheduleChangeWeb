using System;

namespace ScheduleChange.Data.Config
{
    public class DomesticCities
    {
        public int Id { get; set; }
        public string CityCode { get; set; }
        public string CityName { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
