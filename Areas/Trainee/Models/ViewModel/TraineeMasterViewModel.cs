using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GloableCommunication.DbModels;
using Microsoft.AspNetCore.Http;

namespace GloableCommunication.Areas.Trainee.Models.ViewModel
{
    public class TraineeMasterViewModel
    {
        public List<TraineeEntryDate> traineeEntryDates { get; set; } = new List<TraineeEntryDate>();
        public List<TraineeMaster> TraineeM { get; set; } = new List<TraineeMaster>();
        public List<TraineeMasterViewModel> TraineeVM { get; set; } = new List<TraineeMasterViewModel>();

        public List<TraineeHistory> TraineeH { get; set; } = new List<TraineeHistory>();
        public List<GloableCommunication.DbModels.TraineeDocument> TrneeDocuments { get; set; } = new List<GloableCommunication.DbModels.TraineeDocument>();
        public List<DbModels.Document> TDocuments { get; set; } = new List<DbModels.Document>();
        public List<TraineeMaster> traineeMasters { get; set; } = new List<TraineeMaster>();
        public List<DbModels.AcceptingCompany> Acceptings { get; set; } = new List<DbModels.AcceptingCompany>();
        public List<DbModels.Occupation> OccupationLists { get; set; } = new List<DbModels.Occupation>();
        public List<DbModels.SendingCompany> Sendings { get; set; } = new List<DbModels.SendingCompany>();
        public List<DbModels.Work> WorkList { get; set; } = new List<DbModels.Work>();
        public List<Country> countries { get; set; } = new List<Country>();
        public TraineeMaster TraineeMasterEdit { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string EntranceDateStr { get; set; }

        public List<Work> workListing { get; set; } = new List<Work>();
        public List<DbModels.Occupation> occupationList{ get; set; } = new List<DbModels.Occupation>();
        public GloableCommunication.DbModels.TraineeHistory  Thistry{ get; set; }
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

        public int CountryCode { get; set; }

        public string Zip { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string TelephoneNo { get; set; }

        public string Email { get; set; }

        public string SpouseFlg { get; set; }


        public string PensionNo { get; set; }
        public long? GraduationFlg { get; set; }

        public IFormFile UploadedDoc { get; set; }


        public IFormFile TraineeImage { get; set; }
        public string traineeimagestringformat { get; set; }
        public string Memo1 { get; set; }
        public string Memo2 { get; set; }
        public string Memo3 { get; set; }
        public DateTime EntranceDate { get; set; }

        public string EntranceStatus { get; set; }

        public string PositionStatus { get; set; }
        public int AcceptingCompanyId { get; set; }
        public int? OccupationId { get; set; }
        public DateTime? GroupFrom { get; set; }
        public DateTime GroupFromstr { get; set; }
        public DateTime? GroupTo { get; set; }
        public DateTime GroupTostr { get; set; }
        public DateTime? PracticalTrainingFrom { get; set; }
        public DateTime PracticalTrainingFromstr { get; set; }
        public DateTime? PracticalTrainingTo { get; set; }
        public DateTime PracticalTrainingTostr { get; set; }
        public DateTime? PracticalTrainingFrom2 { get; set; }
        public DateTime PracticalTrainingFrom2str { get; set; }
        public DateTime? PracticalTrainingTo2 { get; set; }
        public DateTime PracticalTrainingTo2str { get; set; }

        public DateTime? PracticalTrainingFrom3 { get; set; }
        public DateTime PracticalTrainingFrom3str { get; set; }
        public DateTime? PracticalTrainingTo3 { get; set; }
        public DateTime PracticalTrainingTo3str { get; set; }
        public DateTime? TechnicalFrom { get; set; }
        public DateTime TechnicalFromstr { get; set; }
        public DateTime? TechnicalTo { get; set; }
        public DateTime TechnicalTostr { get; set; }
        public DateTime? SpecificActivityFrom { get; set; }
        public DateTime SpecificActivityFromstr { get; set; }
        public DateTime? SpecificActivityto { get; set; }
        public DateTime SpecificActivitytostr { get; set; }
        public string Colum { get; set; }
        public int SendingCompanyId { get; set; }
        public bool? DeleteFlg { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public string Generation { get; set; }
        public int? WorkId { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime EntryDatestr { get; set; }
        public DateTime? ReturnPlanDate { get; set; }
        public DateTime ReturnPlanDatestr { get; set; }
        public DateTime? ReturnDate { get; set; }
        public DateTime ReturnDatestr { get; set; }

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
        public DateTime HiringDatestr { get; set; }
        public DateTime? SpecificNo1From { get; set; }
        public DateTime SpecificNo1Fromstr { get; set; }
        public DateTime? SpecificNo1To { get; set; }
        public DateTime SpecificNo1Tostr { get; set; }
        public DateTime? SpecificNo2From { get; set; }
        public DateTime SpecificNo2Fromstr { get; set; }
        public DateTime? SpecificNo2To { get; set; }
        public DateTime SpecificNo2Tostr { get; set; }
        public bool? RentFlg { get; set; }
        public bool? UtilitycostsFlg { get; set; }
        public string BloodTypeFlg { get; set; }
        public string Certification1No { get; set; }
        public DateTime? Certification1Date { get; set; }
        public DateTime Certification1Datestr { get; set; }
        public DateTime? Certification1From { get; set; }
        public DateTime Certification1Fromstr { get; set; }
        public DateTime? Certification1To { get; set; }
        public DateTime Certification1Tostr { get; set; }
        public string Certification2No { get; set; }
        public DateTime? Certification2Date { get; set; }
        public DateTime Certification2Datestr { get; set; }
        public DateTime? Certification2From { get; set; }

        public DateTime Certification2Fromstr { get; set; }

        public DateTime? Certification2To { get; set; }
        public DateTime Certification2Tostr { get; set; }
        public string Certification3No { get; set; }
        public DateTime? Certification3Date { get; set; }
        public DateTime Certification3Datestr { get; set; }
        public DateTime? Certification3From { get; set; }
        public DateTime Certification3Fromstr { get; set; }
        public DateTime? Certification3To { get; set; }
        public DateTime Certification3Tostr { get; set; }
        public DateTime? Training3From { get; set; }
        public DateTime Training3Fromstr { get; set; }
        public DateTime? Training3To { get; set; }
        public DateTime Training3Tostr { get; set; }
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
        public DateTime NewSystemstartDatestr { get; set; }
        public DateTime? Scheduledstartdateforboth { get; set; }
        public DateTime Scheduledstartdateforbothstr { get; set; }
        public DateTime? TotalStartDate { get; set; }
        public DateTime TotalStartDatestr { get; set; }
        public string Immigrationstatus { get; set; }
        public DateTime? Returndate3 { get; set; }
        public DateTime Returndate3str { get; set; }
        public string Position { get; set; }
        public DateTime? ReturnPlanDate1 { get; set; }
        public DateTime ReturnPlanDate1str { get; set; }
        public DateTime? ReturnPlanDate2 { get; set; }
        public DateTime ReturnPlanDate2str { get; set; }
        public string AcceptiingCompanyName { get; set; }
        public string SendingName { get; set; }
        public string OccupationName { get; set; }
        public string CountryName { get; set; }
        public string EntryStatusPlan{ get; set; }
        public string EntryStatusDone { get; set; }
        public string EntryStatusRetun { get; set; }
        public string EntryStatus { get; set; }
        public string EntryStatusDisappear { get; set; }
        public string EntryStatusUnionTransfer { get; set; }
        public string EntryStatusDeath { get; set; }
        public string PositionStatusIntern { get; set; }
        public string PositionStatusTraining_1{ get; set; }
        public string PositionStatusTraining_2 { get; set; }
        public string PositionStatusTraining_3 { get; set; }
        public string PositionStatusActivity_1 { get; set; }
        public string PositionStatusActivity_2 { get; set; }
        public string PositionStatusSkill_1 { get; set; }
        public string PositionStatusSkill_2 { get; set; }
        public string NewSystem { get; set; }
        public string OldSystem { get; set; }
        public bool SortbyTraineeNo { get; set; }
        public bool SortbyEntryDate { get; set; }

      
        public DateTime? Specificskillstart1 { get; set; }
        public DateTime Specificskillstart1str { get; set; }

        public DateTime? SpecificskillRhome1 { get; set; }
        public DateTime SpecificskillRhome1str { get; set; }

        public DateTime? Specificskillstart2 { get; set; }
        public DateTime Specificskillstart2str { get; set; }

        public DateTime? SpecificskillRhome2 { get; set; }
        public DateTime SpecificskillRhome2str { get; set; }

        public string Testname { get; set; }
     
        public string Classname1 { get; set; }

        public DateTime? Passdate { get; set; }
        public DateTime Passdatestr { get; set; }

        public string Result { get; set; }
       
        public string Classname2 { get; set; }

        public DateTime? Passdate2 { get; set; }
        public DateTime Passdate2str { get; set; }

        public string Result2 { get; set; }


        public int TraineeHistoryId { get; set; }
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

        public DateTime PassportLimitstr { get; set; }
        public string RegistrationNo { get; set; }
        public DateTime? RegistrationLimit { get; set; }
        public DateTime RegistrationLimitstr { get; set; }


        //public string PassportImg { get; set; }
        public IFormFile PassportImg { get; set; }

        public string PassportImgstringformat { get; set; }
        public IFormFile TraineevisaImg1 { get; set; }
        public string TraineevisaImg1stringformat { get; set; }
        public IFormFile TraineevisaImg2 { get; set; }
        public string TraineevisaImg2stringformat { get; set; }
        public IFormFile DesactvisaImg1 { get; set; }
        public string DesactvisaImg1stringformat { get; set; }
        public IFormFile DesactvisaImg2 { get; set; }
        public string DesactvisaImg2stringformat { get; set; }
        public IFormFile RegistrationImg1 { get; set; }
        public string RegistrationImg1stringformat { get; set; }
        public IFormFile RegistrationImg2 { get; set; }
        public string RegistrationImg2stringformat { get; set; }
        public DateTime? InsertDateTraineeHitory { get; set; }
        public DateTime? UpdateDateTraineeHistory { get; set; }
        public DateTime? PlanDate { get; set; }
        public DateTime PlanDatestr { get; set; }
        public bool? CheckPlan { get; set; }
        public long? DocumentId { get; set; }
        public string ResidentCardNo { get; set; }
        //public DateTime ResidentCardExpireDate { get; set; }
        //public DateTime FromDate { get; set; }      
        //public DateTime ToDate { get; set; }
        public int ReturnOption { get; set; }
        //public string EntranceDateStr { get; set; }

        public int RemaingDays { get; set; }

        public DateTime? ResidentCardExpireDate { get; set; }
        //public DateTime? ResidentCardExpireDate { get; set; }
     
        public DateTime ResidentCardExpireDatestr { get; set; }

        public IFormFile LandingPermit { get; set; }
        public string LandingPermitstringformat { get; set; }
        public IFormFile ResidentCard2 { get; set; }
        public string ResidentCard2stringformat { get; set; }
        public IFormFile Residentcardyear2 { get; set; }
        public string Residentcardyear2stringformat { get; set; }
        public IFormFile Residentcard3 { get; set; }
        public string Residentcard3stringformat { get; set; }
        public IFormFile Residentcardyear3 { get; set; }
        public string Residentcardyear3stringformat { get; set; }
        public IFormFile Residentcard4 { get; set; }
        public string Residentcard4stringformat { get; set; }
        public IFormFile Residentcardyear4 { get; set; }
        public string esidentcardyear4stringformat { get; set; }
        public IFormFile Residentcard5 { get; set; }
        public string Residentcard5stringformat { get; set; }
        public IFormFile Residentcardyesr5 { get; set; }
        public string Residentcardyesr5stringformat { get; set; }
        public IFormFile Other1 { get; set; }
        public string Other1stringformat { get; set; }
        public IFormFile Other2 { get; set; }
        public string Other2stringformat { get; set; }

        public string AcceptingCompanyCode { get; set; }
        public string ZipAccptingCom { get; set; }
        public string Address1AccptCom { get; set; }
        public string Address2AccptCom { get; set; }
        public string TelephoneNoAccptCom { get; set; }
        public string FaxAccptCom { get; set; }
        public string Business { get; set; }
        public string IpNotificationNo { get; set; }
        public string Fullname { get; set; }
        public string WorkName { get; set; }
        public string SendingComapny { get; set; }
        public string entrancestatus { get; set; }
        public string positionstatus { get; set; }
        public string newoldsystem { get; set; }
        public string sexflagstr { get; set; }

    }
    public class TraineeEntryDate
    {
        public long TraineeId { get; set; }
        public string EntranceDateStr { get; set; }
        public string entrancestatus { get; set; }
        public string positionstatus { get; set; }
        public string sexflagstr { get; set; }
    }
}
