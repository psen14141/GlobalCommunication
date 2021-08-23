using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using GloableCommunication.DbModels;
using Microsoft.AspNetCore.Http;

namespace GloableCommunication.Areas.Trainee.Models.ViewModel
{
    [Table("TraineeMaster")]
    public class TraineeMasterDetailView
    {
        public TraineeMaster TraineeMaster { get; set; }
        public TraineeHistory TraineeHistory { get; set; }
        public long TraineeId { get; set; }
        public string TraineeNo { get; set; }
        public string TraineeName { get; set; }
        public string KatakanaName { get; set; }
        public string KanjiName { get; set; }
        public string SexFlag { get; set; }
        public DateTime BirthDate { get; set; }
        public string JapaneseDate { get; set; }
        public string BirthPlace { get; set; }
        public int Age { get; set; }
        public int CountryId { get; set; }
        public string Zip { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string TelephoneNo { get; set; }
        public string Email { get; set; }
        public int? SpouseFlg { get; set; }
        public string PensionNo { get; set; }
        public long? GraduationFlg { get; set; }
        public string TraineeImage { get; set; }
        //public IFormFile TraineeImage { get; set; }
        public string Memo1 { get; set; }
        public string Memo2 { get; set; }
        public string Memo3 { get; set; }
        public DateTime EntranceDate { get; set; }
        public string EntranceStatus { get; set; }
        public string PositionStatus { get; set; }
        public int AcceptingCompanyId { get; set; }
        public int OccupationId { get; set; }
        public DateTime? GroupFrom { get; set; }
        public DateTime? GroupTo { get; set; }
        public DateTime? PracticalTrainingFrom { get; set; }
        public DateTime? PracticalTrainingTo { get; set; }
        public DateTime? PracticalTrainingFrom2 { get; set; }
        public DateTime? PracticalTrainingTo2 { get; set; }
        public DateTime? PracticalTrainingFrom3 { get; set; }
        public DateTime? PracticalTrainingTo3 { get; set; }
        public DateTime? TechnicalFrom { get; set; }
        public DateTime? TechnicalTo { get; set; }
        public DateTime? SpecificActivityFrom { get; set; }
        public DateTime? SpecificActivityto { get; set; }
        public string Colum { get; set; }
        public int SendingCompanyId { get; set; }
        public bool? DeleteFlg { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Generation { get; set; }
        public int? WorkId { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? ReturnPlanDate1 { get; set; }
        public DateTime? ReturnPlanDate2 { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string ReturnComments { get; set; }
        public string MReturnComments { get; set; }
        public string SprintComments { get; set; }
        public string TransfersComments { get; set; }
        public string DeathComments { get; set; }
        public string EmergencyTel { get; set; }
        public DateTime? InterviewDate { get; set; }
        public double? Rent { get; set; }
        public double? Utilitycosts { get; set; }
        public DateTime? HiringDate { get; set; }
        public DateTime? SpecificNo1From { get; set; }
        public DateTime? SpecificNo1To { get; set; }
        public DateTime? SpecificNo2From { get; set; }
        public DateTime? SpecificNo2To { get; set; }
        public bool? RentFlg { get; set; }
        public bool? UtilitycostsFlg { get; set; }
        public string BloodTypeFlg { get; set; }
        public string Certification1No { get; set; }
        public DateTime? Certification1Date { get; set; }
        public DateTime? Certification1From { get; set; }
        public string Certification1To { get; set; }
        public string Certification2No { get; set; }
        public DateTime? Certification2Date { get; set; }
        public DateTime? Certification2From { get; set; }
        public DateTime? Certification2To { get; set; }
        public string Certification3No { get; set; }
        public DateTime? Certification3Date { get; set; }
        public DateTime? Certification3From { get; set; }
        public DateTime? Certification3To { get; set; }
        public DateTime? Training3From { get; set; }
        public DateTime? Training3To { get; set; }
        public string NewOldSystem { get; set; }
        public DateTime? NewSystemDate { get; set; }
        public DateTime? IpNotification0Date { get; set; }
        public DateTime? IpNotification1Date { get; set; }
        public long? Grade { get; set; }
        public long? SuccessFailure0 { get; set; }
        public long? SuccessFailure1 { get; set; }
        public DateTime? Training3PlanDate { get; set; }
        public DateTime? TpReturnDateFrom { get; set; }
        public DateTime? TpReturnDateTo { get; set; }
        public DateTime? Training3Date { get; set; }
        public string DelayedEntry { get; set; }
        public bool IsDelete { get; set; }
        public string Schlarship { get; set; }
        public string BirthdayByEra { get; set; }
        public DateTime? NewSystemstartDate { get; set; }
        public DateTime? Scheduledstartdateforboth { get; set; }
        public DateTime? TotalStartDate { get; set; }
        public string Immigrationstatus { get; set; }
        public DateTime? Returndate3 { get; set; }
        public string Position { get; set; }
        public DateTime? Specificskillstart1 { get; set; }
        public DateTime? SpecificskillRhome1 { get; set; }
        public DateTime? Specificskillstart2 { get; set; }
        public DateTime? SpecificskillRhome2 { get; set; }
        public string Testname { get; set; }
        public string Classname1 { get; set; }
        public DateTime? Passdate { get; set; }
        public string Result { get; set; }
        public string Classname2 { get; set; }
        public DateTime? Passdate2 { get; set; }
        public string Result2 { get; set; }
        public virtual DbModels.AcceptingCompany AcceptingCompany { get; set; }
        public virtual Country Country { get; set; }
        public virtual SendingCompany SendingCompany { get; set; }
        public virtual Work Work { get; set; }
        public virtual ICollection<TraineeDocument> TraineeDocuments { get; set; }
        public virtual ICollection<TraineeHistory> TraineeHistories { get; set; }

        public int TraineeHistoryId { get; set; }
        //public string PassportNo { get; set; }
        //public DateTime? PassportLimit { get; set; }
        //public string ResidentCardNo { get; set; }
        //public DateTime? ResidentCardExpireDate { get; set; }
        public string PassportImg { get; set; }
        public string LandingPermit { get; set; }
        public string TraineevisaImg1 { get; set; }
        public string RegistrationImg2 { get; set; }
        public string DesactvisaImg1 { get; set; }
        public string DesactvisaImg2 { get; set; }
        public string Residentcardyear2 { get; set; }
        public string ResidentCard2 { get; set; }
        public string Residentcardyear3 { get; set; }
        public string Residentcard3 { get; set; }
        public string Residentcardyear4 { get; set; }
        public string Residentcard4 { get; set; }
        public string Residentcardyesr5 { get; set; }
        public string Residentcard5 { get; set; }
        public string Other1 { get; set; }
        public string Other2 { get; set; }

        public List<Country> countries { get; set; } = new List<Country>();
        public List<DbModels.AcceptingCompany> acceptingCompanies { get; set; } = new List<DbModels.AcceptingCompany>();
        public List<Occupation> occupations { get; set; } = new List<Occupation>();
        public List<SendingCompany> sendingCompany { get; set; } = new List<SendingCompany>();
        public List<Work> works { get; set; } = new List<Work>();
        public List<TraineeHistory> traineeHistories { get; set; } = new List<TraineeHistory>();

        public List<TraineeMaster> traineeMasters { get; set; } = new List<TraineeMaster>();
         


    }
}
