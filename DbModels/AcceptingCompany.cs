using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GloableCommunication.DbModels
{
    [Table("AcceptingCompany")]
    public partial class AcceptingCompany
    {
        public AcceptingCompany()
        {
            AssetManagements = new HashSet<AssetManagement>();
            SubmissionDbLogs = new HashSet<SubmissionDbLog>();
            Submissions = new HashSet<Submission>();
            TraineeMasters = new HashSet<TraineeMaster>();
        }

        [Key]
        public int AcceptingCompanyId { get; set; }
        [Required]
        [StringLength(50)]
        public string AcceptingCompanyCode { get; set; }
        [Required]
        [StringLength(50)]
        public string AcceptiingCompanyName { get; set; }
        [Required]
        [Column("hiragana_name")]
        [StringLength(100)]
        public string HiraganaName { get; set; }
        [Required]
        [Column("english_name")]
        [StringLength(100)]
        public string EnglishName { get; set; }
        public int AreaId { get; set; }
        public int PerfectureId { get; set; }
        [Required]
        [Column("zip")]
        [StringLength(10)]
        public string Zip { get; set; }
        [Required]
        [Column("address1")]
        [StringLength(100)]
        public string Address1 { get; set; }
        [Column("address2")]
        [StringLength(100)]
        public string Address2 { get; set; }
        [Required]
        [Column("telephoneNo")]
        [StringLength(50)]
        public string TelephoneNo { get; set; }
        [Column("fax")]
        [StringLength(18)]
        public string Fax { get; set; }
        [StringLength(50)]
        public string CheifExecutiveOfficer { get; set; }
        [Column("member")]
        [StringLength(10)]
        public string Member { get; set; }
        [Column("capital_stock")]
        public double? CapitalStock { get; set; }
        [Column("business")]
        [StringLength(100)]
        public string Business { get; set; }
        [Column("calculateDate_from", TypeName = "date")]
        public DateTime? CalculateDateFrom { get; set; }
        [Column("calculateDate_to", TypeName = "date")]
        public DateTime? CalculateDateTo { get; set; }
        [Column("charge")]
        [StringLength(100)]
        public string Charge { get; set; }
        [Column("charge_position")]
        [StringLength(100)]
        public string ChargePosition { get; set; }
        [Column("charge_telephone")]
        [StringLength(100)]
        public string ChargeTelephone { get; set; }
        [Column("instructor1")]
        [StringLength(50)]
        public string Instructor1 { get; set; }
        [Column("instructor_position1")]
        [StringLength(50)]
        public string InstructorPosition1 { get; set; }
        [Column("instructor_tel1")]
        [StringLength(18)]
        public string InstructorTel1 { get; set; }
        [Column("instructor2")]
        [StringLength(50)]
        public string Instructor2 { get; set; }
        [Column("instructor_position2")]
        [StringLength(50)]
        public string InstructorPosition2 { get; set; }
        [Column("instructor_tel2")]
        [StringLength(18)]
        public string InstructorTel2 { get; set; }
        [Column("instructor3")]
        [StringLength(50)]
        public string Instructor3 { get; set; }
        [Column("instructor_position3")]
        [StringLength(50)]
        public string InstructorPosition3 { get; set; }
        [Column("instructor_tel3")]
        [StringLength(18)]
        public string InstructorTel3 { get; set; }
        [Column("mentor")]
        [StringLength(50)]
        public string Mentor { get; set; }
        [Column("mentor_position")]
        [StringLength(50)]
        public string MentorPosition { get; set; }
        [Column("mentor_tel")]
        [StringLength(18)]
        public string MentorTel { get; set; }
        [Column("limit")]
        [StringLength(10)]
        public string Limit { get; set; }
        [Column("insert_date", TypeName = "date")]
        public DateTime InsertDate { get; set; }
        [Column("update_date", TypeName = "date")]
        public DateTime? UpdateDate { get; set; }
        [Column("training_zip")]
        [StringLength(10)]
        public string TrainingZip { get; set; }
        [Column("training_adress1")]
        [StringLength(100)]
        public string TrainingAdress1 { get; set; }
        [Column("training_adress2")]
        [StringLength(100)]
        public string TrainingAdress2 { get; set; }
        [Column("training_tel")]
        [StringLength(100)]
        public string TrainingTel { get; set; }
        [Column("training_fax")]
        [StringLength(100)]
        public string TrainingFax { get; set; }
        [Column("memo1", TypeName = "ntext")]
        public string Memo1 { get; set; }
        [Column("memo2", TypeName = "ntext")]
        public string Memo2 { get; set; }
        [Column("memo3", TypeName = "ntext")]
        public string Memo3 { get; set; }
        [Column("training_prefecture_cd")]
        public int? TrainingPrefectureCd { get; set; }
        [Column("sales")]
        [StringLength(50)]
        public string Sales { get; set; }
        [Column("sales_position")]
        [StringLength(50)]
        public string SalesPosition { get; set; }
        [Column("documents")]
        [StringLength(250)]
        public string Documents { get; set; }
        [Column("documents_position")]
        [StringLength(50)]
        public string DocumentsPosition { get; set; }
        [Column("documents_tel")]
        [StringLength(10)]
        public string DocumentsTel { get; set; }
        [Column("ｌtd_cd")]
        public bool? ＬtdCd { get; set; }
        [Column("ip_notification_no")]
        [StringLength(50)]
        public string IpNotificationNo { get; set; }
        [Column("ip_notification_date", TypeName = "date")]
        public DateTime? IpNotificationDate { get; set; }
        [Column(TypeName = "ntext")]
        public string CompanyMember { get; set; }
        [Column(TypeName = "ntext")]
        public string EmploymentInsuranceNum { get; set; }
        [Column(TypeName = "ntext")]
        public string LabourInsuranceNum { get; set; }
        public bool IsDeleteAcceptCom { get; set; }

        [ForeignKey(nameof(AreaId))]
        [InverseProperty("AcceptingCompanies")]
        public virtual Area Area { get; set; }
        [ForeignKey(nameof(PerfectureId))]
        [InverseProperty("AcceptingCompanyPerfectures")]
        public virtual Perfecture Perfecture { get; set; }
        [ForeignKey(nameof(TrainingPrefectureCd))]
        [InverseProperty("AcceptingCompanyTrainingPrefectureCdNavigations")]
        public virtual Perfecture TrainingPrefectureCdNavigation { get; set; }
        [InverseProperty(nameof(AssetManagement.AcceptingCompany))]
        public virtual ICollection<AssetManagement> AssetManagements { get; set; }
        [InverseProperty(nameof(SubmissionDbLog.AcceptCompanyDbLogNavigation))]
        public virtual ICollection<SubmissionDbLog> SubmissionDbLogs { get; set; }
        [InverseProperty(nameof(Submission.Acceptingcompany))]
        public virtual ICollection<Submission> Submissions { get; set; }
        [InverseProperty(nameof(TraineeMaster.AcceptingCompany))]
        public virtual ICollection<TraineeMaster> TraineeMasters { get; set; }
    }
}
