using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleChange.Data
{
    public class Config
    {
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
        public DateTime Todate { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public int UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
