using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GloableCommunication.DbModels
{
    [Table("SendingCompany")]
    public partial class SendingCompany
    {
        public SendingCompany()
        {
            AssetManagements = new HashSet<AssetManagement>();
            TraineeMasters = new HashSet<TraineeMaster>();
        }

        [Key]
        public int SendingCompanyId { get; set; }
        [Required]
        [StringLength(50)]
        public string SendingComapny { get; set; }
        [Column("sending_Name")]
        [StringLength(100)]
        public string SendingName { get; set; }
        [Required]
        [Column("fullname")]
        [StringLength(100)]
        public string Fullname { get; set; }
        [Column("country_Id")]
        public int CountryId { get; set; }
        [Column("area_Id")]
        public int AreaId { get; set; }
        [Column("zip")]
        [StringLength(50)]
        public string Zip { get; set; }
        [Column("address1")]
        [StringLength(150)]
        public string Address1 { get; set; }
        [Column("address2")]
        [StringLength(150)]
        public string Address2 { get; set; }
        [Column("telephone")]
        [StringLength(18)]
        public string Telephone { get; set; }
        [Column("fax")]
        [StringLength(18)]
        public string Fax { get; set; }
        [StringLength(50)]
        public string CheifExecutiveOfficer { get; set; }
        [Column("charge")]
        [StringLength(50)]
        public string Charge { get; set; }
        [Column("charge_telephone")]
        [StringLength(18)]
        public string ChargeTelephone { get; set; }
        [Column("allowance")]
        public double? Allowance { get; set; }
        [Column("insert_date", TypeName = "datetime")]
        public DateTime InsertDate { get; set; }
        [Column("update_date", TypeName = "datetime")]
        public DateTime? UpdateDate { get; set; }
        [Column("memo1", TypeName = "ntext")]
        public string Memo1 { get; set; }
        [Column("memo2", TypeName = "ntext")]
        public string Memo2 { get; set; }
        [Column("memo3", TypeName = "ntext")]
        public string Memo3 { get; set; }
        public bool IsDeleteSendingCompany { get; set; }

        [ForeignKey(nameof(AreaId))]
        [InverseProperty("SendingCompanies")]
        public virtual Area Area { get; set; }
        [ForeignKey(nameof(CountryId))]
        [InverseProperty("SendingCompanies")]
        public virtual Country Country { get; set; }
        [InverseProperty(nameof(AssetManagement.SendingCompny))]
        public virtual ICollection<AssetManagement> AssetManagements { get; set; }
        [InverseProperty(nameof(TraineeMaster.SendingCompany))]
        public virtual ICollection<TraineeMaster> TraineeMasters { get; set; }
    }
}
