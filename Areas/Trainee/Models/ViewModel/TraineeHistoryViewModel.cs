using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GloableCommunication.DbModels;

namespace GloableCommunication.Areas.Trainee.Models.ViewModel
{
    public class TraineeHistoryViewModel
    {
 
        public int TraineeHistoryId { get; set; }
        public long TraineeId { get; set; }

        public DateTime? HstFrom1 { get; set; }

        public DateTime? HstTo1 { get; set; }

        public string Career1 { get; set; }

        public DateTime? HstFrom2 { get; set; }

        public DateTime? HstTo2 { get; set; }

        public string Career2 { get; set; }

        public DateTime? HstFrom3 { get; set; }

        public DateTime? HstTo3 { get; set; }
 
        public string Career3 { get; set; }

        public DateTime? HstFrom4 { get; set; }

        public DateTime? HstTo4 { get; set; }

        public string Career4 { get; set; }

        public DateTime? HstFrom5 { get; set; }

        public DateTime? HstTo5 { get; set; }

        public string Career5 { get; set; }

        public DateTime? HstFrom6 { get; set; }

        public DateTime? HstTo6 { get; set; }

        public string Career6 { get; set; }

        public DateTime? HstFrom7 { get; set; }

        public DateTime? HstTo7 { get; set; }

        public string Career7 { get; set; }

        public DateTime? HstFrom8 { get; set; }

        public DateTime? HstTo8 { get; set; }

        public string Career8 { get; set; }

        public DateTime? HstFrom9 { get; set; }

        public DateTime? HstTo9 { get; set; }

        public string Career9 { get; set; }

        public string HomecmpName { get; set; }

        public string HomecmpZip { get; set; }

        public string HomecmpAdress1 { get; set; }

        public string HomecmpAdress2 { get; set; }

        public string HomecmpTel { get; set; }

        public string HomecmpBusiness { get; set; }

        public int? HomecmpYear { get; set; }

        public int? HomecmpMonth { get; set; }

        public bool? VisitFlg { get; set; }

        public string PassportNo { get; set; }

        public DateTime? PassportLimit { get; set; }

        public string RegistrationNo { get; set; }

        public DateTime? RegistrationLimit { get; set; }

        public string PassportImg { get; set; }

        public string TraineevisaImg1 { get; set; }

        public string TraineevisaImg2 { get; set; }

        public string DesactvisaImg1 { get; set; }

        public string DesactvisaImg2 { get; set; }

        public string RegistrationImg1 { get; set; }

        public string RegistrationImg2 { get; set; }

        public DateTime? InsertDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? PlanDate { get; set; }

        public bool? CheckPlan { get; set; }

        public long? DocumentId { get; set; }
        public bool IsDeleteTraineeHistory { get; set; }

        public string ResidentCardNo { get; set; }

        public DateTime? ResidentCardExpireDate { get; set; }

        public string LandingPermit { get; set; }

        public string ResidentCard2 { get; set; }

        public string Residentcardyear2 { get; set; }

        public string Residentcard3 { get; set; }

        public string Residentcardyear3 { get; set; }

        public string Residentcard4 { get; set; }

        public string Residentcardyear4 { get; set; }
 
        public string Residentcard5 { get; set; }

        public string Residentcardyesr5 { get; set; }

        public string Other1 { get; set; }

        public string Other2 { get; set; }

        public List<TraineeHistory> Traineehistory { get; set; } = new List<TraineeHistory>();

    }
}
