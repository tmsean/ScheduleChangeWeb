using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleChange.Data
{
    public class PCC
    {
        public int Id { get; set; }
        public string CityCode { get; set; }
        public string PCCCode { get; set; }
        public string PCCName { get; set; }
        public int QueueNumber { get; set; }
        public string TimeZone { get; set; }
        public string CityName { get; set; }
        public string PCCFullName { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
