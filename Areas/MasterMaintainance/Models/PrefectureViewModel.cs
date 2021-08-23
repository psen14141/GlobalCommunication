using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GloableCommunication.Areas.MasterMaintainance.Models.ViewModels
{
    public class PrefectureViewModel
    {
        public int PerfectureId { get; set; }
        public int PerfectureCode { get; set; }
        public string PerfectureName { get; set; }
       
        public DateTime InsertDatetTime { get; set; }
        
        public DateTime? UpdateDateTime { get; set; }
        public int AreaId { get; set; }
        public string AreaName { get; set; }
        public int AreaCode { get; set; }

        public string Currentdate { get; set; }

        public List<DbModels.Perfecture> Prefectures = new List<GloableCommunication.DbModels.Perfecture>();

        public List<DbModels.Area> areas = new List<GloableCommunication.DbModels.Area>();



    }
}
