using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GloableCommunication.DbModels
{
    [Table("TraineeHistory")]
    public partial class TraineeHistory
    {
        [Key]
        public int TraineeHistoryId { get; set; }
        public long TraineeId { get; set; }
        [Column("hst_from1", TypeName = "date")]
        public DateTime? HstFrom1 { get; set; }
        [Column("hst_to1", TypeName = "date")]
        public DateTime? HstTo1 { get; set; }
        [Column("career1")]
        [StringLength(50)]
        public string Career1 { get; set; }
        [Column("hst_from2", TypeName = "date")]
        public DateTime? HstFrom2 { get; set; }
        [Column("hst_to2", TypeName = "date")]
        public DateTime? HstTo2 { get; set; }
        [Column("career2")]
        [StringLength(50)]
        public string Career2 { get; set; }
        [Column("hst_from3", TypeName = "date")]
        public DateTime? HstFrom3 { get; set; }
        [Column("hst_to3", TypeName = "date")]
        public DateTime? HstTo3 { get; set; }
        [Column("career3")]
        [StringLength(50)]
        public string Career3 { get; set; }
        [Column("hst_from4", TypeName = "date")]
        public DateTime? HstFrom4 { get; set; }
        [Column("hst_to4", TypeName = "date")]
        public DateTime? HstTo4 { get; set; }
        [Column("career4")]
        [StringLength(50)]
        public string Career4 { get; set; }
        [Column("hst_from5", TypeName = "date")]
        public DateTime? HstFrom5 { get; set; }
        [Column("hst_to5", TypeName = "date")]
        public DateTime? HstTo5 { get; set; }
        [Column("career5")]
        [StringLength(50)]
        public string Career5 { get; set; }
        [Column("hst_from6", TypeName = "date")]
        public DateTime? HstFrom6 { get; set; }
        [Column("hst_to6", TypeName = "date")]
        public DateTime? HstTo6 { get; set; }
        [Column("career6")]
        [StringLength(50)]
        public string Career6 { get; set; }
        [Column("hst_from7", TypeName = "date")]
        public DateTime? HstFrom7 { get; set; }
        [Column("hst_to7", TypeName = "date")]
        public DateTime? HstTo7 { get; set; }
        [Column("career7")]
        [StringLength(50)]
        public string Career7 { get; set; }
        [Column("hst_from8", TypeName = "date")]
        public DateTime? HstFrom8 { get; set; }
        [Column("hst_to8", TypeName = "date")]
        public DateTime? HstTo8 { get; set; }
        [Column("career8")]
        [StringLength(50)]
        public string Career8 { get; set; }
        [Column("hst_from9", TypeName = "date")]
        public DateTime? HstFrom9 { get; set; }
        [Column("hst_to9", TypeName = "date")]
        public DateTime? HstTo9 { get; set; }
        [Column("career9")]
        [StringLength(50)]
        public string Career9 { get; set; }
        [Column("homecmp_name")]
        [StringLength(100)]
        public string HomecmpName { get; set; }
        [Column("homecmp_zip")]
        [StringLength(10)]
        public string HomecmpZip { get; set; }
        [Column("homecmp_adress1")]
        [StringLength(100)]
        public string HomecmpAdress1 { get; set; }
        [Column("homecmp_adress2")]
        [StringLength(100)]
        public string HomecmpAdress2 { get; set; }
        [Column("homecmp_tel")]
        [StringLength(100)]
        public string HomecmpTel { get; set; }
        [Column("homecmp_business")]
        [StringLength(50)]
        public string HomecmpBusiness { get; set; }
        [Column("homecmp_year")]
        public int? HomecmpYear { get; set; }
        [Column("homecmp_month")]
        public int? HomecmpMonth { get; set; }
        [Column("visit_flg")]
        public bool? VisitFlg { get; set; }
        [Column("passport_no")]
        [StringLength(20)]
        public string PassportNo { get; set; }
        [Column("passport_limit", TypeName = "date")]
        public DateTime? PassportLimit { get; set; }
        [Column("registration_no")]
        [StringLength(20)]
        public string RegistrationNo { get; set; }
        [Column("registration_limit", TypeName = "date")]
        public DateTime? RegistrationLimit { get; set; }
        [Column("passport_img")]
        [StringLength(150)]
        public string PassportImg { get; set; }
        [Column("traineevisa_img1")]
        [StringLength(150)]
        public string TraineevisaImg1 { get; set; }
        [Column("traineevisa_img2")]
        [StringLength(150)]
        public string TraineevisaImg2 { get; set; }
        [Column("desactvisa_img1")]
        [StringLength(150)]
        public string DesactvisaImg1 { get; set; }
        [Column("desactvisa_img2")]
        [StringLength(150)]
        public string DesactvisaImg2 { get; set; }
        [Column("registration_img1")]
        [StringLength(150)]
        public string RegistrationImg1 { get; set; }
        [Column("registration_img2")]
        [StringLength(150)]
        public string RegistrationImg2 { get; set; }
        [Column("insert_date", TypeName = "date")]
        public DateTime? InsertDate { get; set; }
        [Column("update_date", TypeName = "date")]
        public DateTime? UpdateDate { get; set; }
        [Column("plan_date", TypeName = "date")]
        public DateTime? PlanDate { get; set; }
        [Column("check_plan")]
        public bool? CheckPlan { get; set; }
        [Column("documentId")]
        public long? DocumentId { get; set; }
        public bool IsDeleteTraineeHistory { get; set; }
        [StringLength(10)]
        public string ResidentCardNo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ResidentCardExpireDate { get; set; }
        [Column("landingPermit")]
        [StringLength(150)]
        public string LandingPermit { get; set; }
        [Column("residentCard2")]
        [StringLength(150)]
        public string ResidentCard2 { get; set; }
        [Column("residentcardyear2")]
        [StringLength(150)]
        public string Residentcardyear2 { get; set; }
        [Column("residentcard3")]
        [StringLength(150)]
        public string Residentcard3 { get; set; }
        [Column("residentcardyear3")]
        [StringLength(150)]
        public string Residentcardyear3 { get; set; }
        [Column("residentcard4")]
        [StringLength(150)]
        public string Residentcard4 { get; set; }
        [Column("residentcardyear4")]
        [StringLength(150)]
        public string Residentcardyear4 { get; set; }
        [Column("residentcard5")]
        [StringLength(150)]
        public string Residentcard5 { get; set; }
        [Column("residentcardyesr5")]
        [StringLength(150)]
        public string Residentcardyesr5 { get; set; }
        [Column("other1")]
        [StringLength(150)]
        public string Other1 { get; set; }
        [Column("other2")]
        [StringLength(150)]
        public string Other2 { get; set; }

        [ForeignKey(nameof(DocumentId))]
        [InverseProperty("TraineeHistories")]
        public virtual Document Document { get; set; }
        [ForeignKey(nameof(TraineeId))]
        [InverseProperty(nameof(TraineeMaster.TraineeHistories))]
        public virtual TraineeMaster Trainee { get; set; }
    }
}
