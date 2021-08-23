using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GloableCommunication.DbModels;

namespace GloableCommunication.Areas.Wrks.Models.ViewModels
{
    public class WorksViewModel
    {

        public int WorkId { get; set; }
 
        public string WorkName { get; set; }
        public int OccupationId { get; set; }
       
        public DateTime InsertDateTime { get; set; }
 
        public DateTime? UpdateDateTime { get; set; }

        public string VerifcationName { get; set; }
        public bool IsDeleteWork { get; set; }
        public int OccupationCode { get; set; }
  
        public string OccupationName { get; set; }

        public List<Occupation> occupations { get; set; } = new List<Occupation>();
    }
}
