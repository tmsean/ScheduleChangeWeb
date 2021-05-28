using System;

namespace ScheduleChange.Data.Config
{
    public class SSCIStation
    {
        public int Id { get; set; }
        public string CityCode { get; set; }
        public string Addresses { get; set; }
        public DateTime EffectiveDateFrom { get; set; }
        public DateTime EffectiveDateTo { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
