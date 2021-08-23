using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GloableCommunication.Areas.Trainee.Models.RequestModel
{
    public class FilterOption
    {
        public List<DbModels.TraineeMaster> TraineeMasters { get; set; } = new List<DbModels.TraineeMaster>();
        public int countryid { get; set; } = 0;
        public int perfectureid { get; set; } = 0;
        public int sendingCompanyid { get; set; } = 0;
        public int acceptingcompanyid { get; set; } = 0;
        public int occupationid { get; set; } = 0;
        public string traineecode { get; set; } = string.Empty;
        public string traineename { get; set; } = string.Empty;
        public string entrystatusplan { get; set; } = string.Empty;
        public string entrystatusdone { get; set; } = string.Empty;
        public string entrystatusreturn { get; set; } = string.Empty;
        public string entrystatusjapan { get; set; } = string.Empty;
        public string entrystatusdisappear { get; set; } = string.Empty;
        public string entrystatusuniontransfer { get; set; } = string.Empty;
        public string entrystatusdeath { get; set; } = string.Empty;
        public string positionstatusintern { get; set; } = string.Empty;
        public string positionstatustraining_1 { get; set; } = string.Empty;
        public string positionstatustraining_2 { get; set; } = string.Empty;
        public string positionstatustraining_3 { get; set; } = string.Empty;
        public string positionstatusactivity_2 { get; set; } = string.Empty;
        public string positionstatusactivity_3 { get; set; } = string.Empty;
        public string positionstatusskill_1 { get; set; } = string.Empty;
        public string positionstatuskkill_2 { get; set; } = string.Empty;
        public string newsystem { get; set; } = string.Empty;
        public string oldsystem { get; set; } = string.Empty;
        public bool issorting { get; set; } = false;
        public DateTime? EntryDate { get; set; }
        public string TraineeName { get; set; }
        public string KatakanaName { get; set; }
        public string SexFlag { get; set; }
        public int AcceptingCompanyId { get; set; }
        public int OccupationId { get; set; } = 0;
        public DateTime fromdate { get; set; } 
        public DateTime todate { get; set; }
        public int returnoption { get; set; } = 0;
        public bool isdelete { get; set; } = false;
        public long? graduationflag { get; set; }

    }
}
