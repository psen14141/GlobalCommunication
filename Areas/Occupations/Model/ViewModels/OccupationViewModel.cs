using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GloableCommunication.Areas.Occupations.Model.ViewModels
{
    public class OccupationViewModel
    {
        public int OccupationId { get; set; }
        public int OccupationCode { get; set; }
        public string OccupationName { get; set; }
        public DateTime InsertDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }
        public long TraineeYearFlag { get; set; }
        public DateTime updatedatetime { get; set; }
        public bool IsDeleteOccupation { get; set; }
        public string NowDate { get; set; } = DateTime.Now.ToString("yyyy/MM/dd");
        public List<DbModels.Occupation> occupations { get; set; } = new List<DbModels.Occupation>();
        public string createdate { get; set; }
        public string updatedate { get; set; }
    }
}
