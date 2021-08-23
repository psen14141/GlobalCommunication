using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GloableCommunication.DbModels;

namespace GloableCommunication.Models.ViewModel
{
    public class WarningViewModel
    {


       


        public List<TraineeMaster> traineeMasters { get; set; } = new List<TraineeMaster>();
        public List<DbModels.SendingCompany> sendingCompanies { get; set; } = new List<DbModels.SendingCompany>();

        public List<DbModels.TraineeHistory> traineeHistories { get; set; } = new List<DbModels.TraineeHistory>();

        public long TraineeId { get; set; }
        public string TraineeNo { get; set; }

        public string TraineeName { get; set; }

        public string SendingName { get; set; }
        public int SendingCompanyId { get; set; }

        public string Schlarship { get; set; }
        public string PassportLimit { get; set; }

        public int RemainingDays { get; set; }

        public string Status { get; set; }





        //----------------------View Model 2------------End-----------------------------



    }
}
