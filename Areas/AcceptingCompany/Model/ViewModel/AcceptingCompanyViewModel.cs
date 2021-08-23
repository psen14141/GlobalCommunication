using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using GloableCommunication.DbModels;

namespace GloableCommunication.Areas.AcceptingCompany.Model.ViewModel
{
    [Table("AcceptingCompany")]
    public class AcceptingCompanyViewModel
    {
        public DbModels.AcceptingCompany AcceptingCompany { get; set; }
        public TraineeMaster TraineeMaster { get; set; }
        public int AcceptingCompanyId { get; set; }
        public string AcceptingCompanyCode { get; set; }
        public string AcceptiingCompanyName { get; set; }
        public string HiraganaName { get; set; }
        public int entranceCount { get; set; }
        public string EnglishName { get; set; }
        public int AreaId { get; set; }
        public int PerfectureId { get; set; }
        public string Zip { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string TelephoneNo { get; set; }
        public string Fax { get; set; }
        public string CheifExecutiveOfficer { get; set; }
        public string Member { get; set; }
        public double? CapitalStock { get; set; }
        public string Business { get; set; }
        public DateTime? CalculateDateFrom { get; set; }
        public DateTime? CalculateDateTo { get; set; }
        public string Charge { get; set; }
        public string ChargePosition { get; set; }
        public string ChargeTelephone { get; set; }
        public string Instructor1 { get; set; }
        public string InstructorPosition1 { get; set; }
        public string InstructorTel1 { get; set; }
        public string Instructor2 { get; set; }
        public string InstructorPosition2 { get; set; }
        public string InstructorTel2 { get; set; }
        public string Instructor3 { get; set; }
        public string InstructorPosition3 { get; set; }
        public string InstructorTel3 { get; set; }
        public string Mentor { get; set; }
        public string MentorPosition { get; set; }
        public string MentorTel { get; set; }
        public string Limit { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string TrainingZip { get; set; }
        public string TrainingAdress1 { get; set; }
        public string TrainingAdress2 { get; set; }
        public string TrainingTel { get; set; }
        public string TrainingFax { get; set; }
        public string Memo1 { get; set; }
        public string Memo2 { get; set; }
        public string Memo3 { get; set; }
        public int? TrainingPrefectureCd { get; set; }
        public string Sales { get; set; }
        public string SalesPosition { get; set; }
        public string Documents { get; set; }
        public string DocumentsPosition { get; set; }
        public string DocumentsTel { get; set; }
        public bool? ＬtdCd { get; set; }
        public string IpNotificationNo { get; set; }
        public DateTime? IpNotificationDate { get; set; }
        public string CompanyMember { get; set; }
        public string EmploymentInsuranceNum { get; set; }
        public string LabourInsuranceNum { get; set; }
        public bool IsDeleteAcceptCom { get; set; }

        public string TraineeNo { get; set; }
        public string TraineeName { get; set; }
        public string KatakanaName { get; set; }
        public string KanjiName { get; set; }
        public string EntranceStatus { get; set; }
        public int CountryId { get; set; }
        public int OccupationId { get; set; }
        public int SendingCompanyId { get; set; }
        public DateTime EntranceDate { get; set; }
        public DateTime BirthDate { get; set; }

        public virtual Area Area { get; set; }
        public virtual Perfecture Perfecture { get; set; }
        public virtual Perfecture TrainingPrefectureCdNavigation { get; set; }
        public virtual ICollection<AssetManagement> AssetManagements { get; set; }
        public virtual ICollection<SubmissionDbLog> SubmissionDbLogs { get; set; }
        public virtual ICollection<Submission> Submissions { get; set; }
        public virtual ICollection<TraineeMaster> TraineeMasters { get; set; }

        public int PerfectureCode { get; set; }
        public string PerfectureName { get; set; }
        //public bool IsDeletePerfecture { get; set; }
        public List<Perfecture>  Perfectures{ get; set; } = new List<Perfecture>();
        public string AreaName { get; set; }
        public List<Area> Areas { get; set; } = new List<Area>();
        public List<Perfecture> accepPerfectures { get; set; } = new List<Perfecture>();
        public List<Area> accepArea { get; set; } = new List<Area>();
        public List<TraineeMaster> accepTrainee { get; set; } = new List<TraineeMaster>();
        public List<DbModels.AcceptingCompany> accepCompanies { get; set; } = new List<DbModels.AcceptingCompany>();
    }
}
