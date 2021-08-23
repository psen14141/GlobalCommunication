using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GloableCommunication.DbModels
{
    [Table("TraineeMaster")]
    public partial class TraineeMaster
    {
        public TraineeMaster()
        {
            TraineeDocuments = new HashSet<TraineeDocument>();
            TraineeHistories = new HashSet<TraineeHistory>();
        }

        [Key]
        public long TraineeId { get; set; }
        [Required]
        [StringLength(100)]
        public string TraineeNo { get; set; }
        [Required]
        [StringLength(100)]
        public string TraineeName { get; set; }
        [StringLength(60)]
        public string KatakanaName { get; set; }
        [StringLength(30)]
        public string KanjiName { get; set; }
        [Required]
        [Column("Sex_Flag")]
        [StringLength(10)]
        public string SexFlag { get; set; }
        [Column(TypeName = "date")]
        public DateTime BirthDate { get; set; }
        [StringLength(15)]
        public string JapaneseDate { get; set; }
        [StringLength(60)]
        public string BirthPlace { get; set; }
        public int Age { get; set; }
        public int CountryId { get; set; }
        [Required]
        [StringLength(10)]
        public string Zip { get; set; }
        [Required]
        [StringLength(100)]
        public string Address1 { get; set; }
        [StringLength(100)]
        public string Address2 { get; set; }
        [Required]
        [StringLength(18)]
        public string TelephoneNo { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Column("Spouse_flg")]
        [StringLength(10)]
        public string SpouseFlg { get; set; }
        [StringLength(50)]
        public string PensionNo { get; set; }
        [Column("Graduation_flg")]
        public long? GraduationFlg { get; set; }
        [Column("Trainee_Image")]
        [StringLength(250)]
        public string TraineeImage { get; set; }
        [Column(TypeName = "ntext")]
        public string Memo1 { get; set; }
        [Column(TypeName = "ntext")]
        public string Memo2 { get; set; }
        [Column(TypeName = "ntext")]
        public string Memo3 { get; set; }
        [Column("entrance_date", TypeName = "date")]
        public DateTime EntranceDate { get; set; }
        [Column("entranceStatus")]
        [StringLength(15)]
        public string EntranceStatus { get; set; }
        [Column("positionStatus")]
        [StringLength(15)]
        public string PositionStatus { get; set; }
        public int AcceptingCompanyId { get; set; }
        public int? OccupationId { get; set; }
        [Column("Group_from", TypeName = "date")]
        public DateTime? GroupFrom { get; set; }
        [Column("Group_to", TypeName = "date")]
        public DateTime? GroupTo { get; set; }
        [Column("PracticalTraining_from", TypeName = "date")]
        public DateTime? PracticalTrainingFrom { get; set; }
        [Column("PracticalTraining_To", TypeName = "date")]
        public DateTime? PracticalTrainingTo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? PracticalTrainingFrom2 { get; set; }
        [Column(TypeName = "date")]
        public DateTime? PracticalTrainingTo2 { get; set; }
        [Column(TypeName = "date")]
        public DateTime? PracticalTrainingFrom3 { get; set; }
        [Column(TypeName = "date")]
        public DateTime? PracticalTrainingTo3 { get; set; }
        [Column("technical_from", TypeName = "date")]
        public DateTime? TechnicalFrom { get; set; }
        [Column("technical_to", TypeName = "date")]
        public DateTime? TechnicalTo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? SpecificActivityFrom { get; set; }
        [Column(TypeName = "date")]
        public DateTime? SpecificActivityto { get; set; }
        [Column("colum")]
        [StringLength(10)]
        public string Colum { get; set; }
        public int SendingCompanyId { get; set; }
        [Column("delete_flg")]
        public bool? DeleteFlg { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InsertDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDate { get; set; }
        [Column("generation")]
        [StringLength(10)]
        public string Generation { get; set; }
        public int? WorkId { get; set; }
        [Column("entry_date", TypeName = "date")]
        public DateTime? EntryDate { get; set; }
        [Column("return_plan_date1", TypeName = "date")]
        public DateTime? ReturnPlanDate1 { get; set; }
        [Column("return_plan_date2", TypeName = "date")]
        public DateTime? ReturnPlanDate2 { get; set; }
        [Column("return_date", TypeName = "date")]
        public DateTime? ReturnDate { get; set; }
        [Column("return_comments")]
        [StringLength(100)]
        public string ReturnComments { get; set; }
        [Column("m_return_comments")]
        [StringLength(100)]
        public string MReturnComments { get; set; }
        [Column("sprint_comments")]
        [StringLength(100)]
        public string SprintComments { get; set; }
        [Column("transfers_comments")]
        [StringLength(100)]
        public string TransfersComments { get; set; }
        [Column("death_comments")]
        [StringLength(100)]
        public string DeathComments { get; set; }
        [Column("emergency_tel")]
        [StringLength(18)]
        public string EmergencyTel { get; set; }
        [Column("interview_date", TypeName = "date")]
        public DateTime? InterviewDate { get; set; }
        [Column("rent")]
        public double? Rent { get; set; }
        [Column("utilitycosts")]
        public double? Utilitycosts { get; set; }
        [Column("hiring_date", TypeName = "date")]
        public DateTime? HiringDate { get; set; }
        [Column("specific_no1_from", TypeName = "date")]
        public DateTime? SpecificNo1From { get; set; }
        [Column("specific_no1_to", TypeName = "date")]
        public DateTime? SpecificNo1To { get; set; }
        [Column("specific_no2_from", TypeName = "date")]
        public DateTime? SpecificNo2From { get; set; }
        [Column("specific_no2_to", TypeName = "date")]
        public DateTime? SpecificNo2To { get; set; }
        [Column("rent_flg")]
        public bool? RentFlg { get; set; }
        [Column("utilitycosts_flg")]
        public bool? UtilitycostsFlg { get; set; }
        [Column("blood_type_flg")]
        [StringLength(10)]
        public string BloodTypeFlg { get; set; }
        [Column("certification1_no")]
        [StringLength(100)]
        public string Certification1No { get; set; }
        [Column("certification1_date", TypeName = "date")]
        public DateTime? Certification1Date { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Certification1From { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Certification1To { get; set; }
        [Column("certification2_no")]
        [StringLength(100)]
        public string Certification2No { get; set; }
        [Column("certification2_date", TypeName = "date")]
        public DateTime? Certification2Date { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Certification2From { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Certification2To { get; set; }
        [Column("certification3_no")]
        [StringLength(100)]
        public string Certification3No { get; set; }
        [Column("certification3_date", TypeName = "date")]
        public DateTime? Certification3Date { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Certification3From { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Certification3To { get; set; }
        [Column("training3_from", TypeName = "date")]
        public DateTime? Training3From { get; set; }
        [Column("training3_to", TypeName = "date")]
        public DateTime? Training3To { get; set; }
        [Column("new_old_system")]
        [StringLength(10)]
        public string NewOldSystem { get; set; }
        [Column("new_system_date", TypeName = "date")]
        public DateTime? NewSystemDate { get; set; }
        [Column("ip_notification0_date", TypeName = "date")]
        public DateTime? IpNotification0Date { get; set; }
        [Column("ip_notification1_date", TypeName = "date")]
        public DateTime? IpNotification1Date { get; set; }
        [Column("grade")]
        public long? Grade { get; set; }
        [Column("success_failure_0")]
        public long? SuccessFailure0 { get; set; }
        [Column("success_failure_1")]
        public long? SuccessFailure1 { get; set; }
        [Column("training3_plan_date", TypeName = "date")]
        public DateTime? Training3PlanDate { get; set; }
        [Column("tp_return_date_from", TypeName = "date")]
        public DateTime? TpReturnDateFrom { get; set; }
        [Column("tp_return_date_to", TypeName = "date")]
        public DateTime? TpReturnDateTo { get; set; }
        [Column("training3_date", TypeName = "date")]
        public DateTime? Training3Date { get; set; }
        [StringLength(100)]
        public string DelayedEntry { get; set; }
        public bool IsDelete { get; set; }
        [StringLength(10)]
        public string Schlarship { get; set; }
        [StringLength(15)]
        public string BirthdayByEra { get; set; }
        [Column(TypeName = "date")]
        public DateTime? NewSystemstartDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Scheduledstartdateforboth { get; set; }
        [Column(TypeName = "date")]
        public DateTime? TotalStartDate { get; set; }
        [StringLength(20)]
        public string Immigrationstatus { get; set; }
        [Column("returndate3", TypeName = "date")]
        public DateTime? Returndate3 { get; set; }
        [Column("position")]
        [StringLength(50)]
        public string Position { get; set; }
        [Column("specificskillstart1", TypeName = "date")]
        public DateTime? Specificskillstart1 { get; set; }
        [Column(TypeName = "date")]
        public DateTime? SpecificskillRhome1 { get; set; }
        [Column("specificskillstart2", TypeName = "date")]
        public DateTime? Specificskillstart2 { get; set; }
        [Column(TypeName = "date")]
        public DateTime? SpecificskillRhome2 { get; set; }
        [Column("testname")]
        [StringLength(100)]
        public string Testname { get; set; }
        [Column("classname1")]
        [StringLength(25)]
        public string Classname1 { get; set; }
        [Column("passdate", TypeName = "date")]
        public DateTime? Passdate { get; set; }
        [Column("result")]
        [StringLength(50)]
        public string Result { get; set; }
        [Column("classname2")]
        [StringLength(50)]
        public string Classname2 { get; set; }
        [Column("passdate2", TypeName = "date")]
        public DateTime? Passdate2 { get; set; }
        [Column("result2")]
        [StringLength(50)]
        public string Result2 { get; set; }

        [ForeignKey(nameof(AcceptingCompanyId))]
        [InverseProperty("TraineeMasters")]
        public virtual AcceptingCompany AcceptingCompany { get; set; }
        [ForeignKey(nameof(CountryId))]
        [InverseProperty("TraineeMasters")]
        public virtual Country Country { get; set; }
        [ForeignKey(nameof(OccupationId))]
        [InverseProperty("TraineeMasters")]
        public virtual Occupation Occupation { get; set; }
        [ForeignKey(nameof(SendingCompanyId))]
        [InverseProperty("TraineeMasters")]
        public virtual SendingCompany SendingCompany { get; set; }
        [ForeignKey(nameof(WorkId))]
        [InverseProperty("TraineeMasters")]
        public virtual Work Work { get; set; }
        [InverseProperty(nameof(TraineeDocument.Trainee))]
        public virtual ICollection<TraineeDocument> TraineeDocuments { get; set; }
        [InverseProperty(nameof(TraineeHistory.Trainee))]
        public virtual ICollection<TraineeHistory> TraineeHistories { get; set; }
    }
}
