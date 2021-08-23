using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using GloableCommunication.DbModels;

namespace GloableCommunication.Areas.SendingCompanies.Model.ViewModels
{

    [Table("SendingCompany")]
    public class SendingCompanyViewModel
    {

        public DbModels.SendingCompany SendingCompanyDetail { get; set; }
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
        [Column("memo1")]
        [StringLength(200)]
        public string Memo1 { get; set; }
        [Column("memo2")]
        [StringLength(200)]
        public string Memo2 { get; set; }
        [Column("memo3")]
        [StringLength(200)]
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


        public string CountryName { get; set; }

        public List<Country> Countries { get; set; } = new List<Country>();

        public string AreaName { get; set; }
        public List<Area> Areas { get; set; } = new List<Area>();

        public List<DbModels.Country> sendingCountry { get; set; } = new List<DbModels.Country>();
        public List<DbModels.Area> sendingArea { get; set; } = new List<DbModels.Area>();

        public List<DbModels.SendingCompany> sendingCompanies { get; set; } = new List<DbModels.SendingCompany>();

        public List<CodeList> codeLists { get; set; } = new List<CodeList>();
        public long sendingCompanyLastId { get; set; }

    }

    public class CodeList
    {

       public long SendingCode { get; set; }
    }
}
