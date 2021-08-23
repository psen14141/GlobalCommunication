using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GloableCommunication.DbModels
{
    [Table("AssetManagement")]
    public partial class AssetManagement
    {
        [Key]
        public int AssetManagementId { get; set; }
        public int AcceptingCompanyId { get; set; }
        public int? SendingCompnyId { get; set; }
        [Column("generation")]
        [StringLength(50)]
        public string Generation { get; set; }
        public double? AcceptingComManagementCost1 { get; set; }
        public double? AcceptingComPreparationCost1 { get; set; }
        public double? SendingComManagementCost1 { get; set; }
        public double? SendingComPreparationCost1 { get; set; }
        public double? AcceptingComManagementCost2 { get; set; }
        public double? AcceptingComPreparationCost2 { get; set; }
        public double? SendingComManagementCost2 { get; set; }
        public double? SendingComPreparationCost2 { get; set; }

        [ForeignKey(nameof(AcceptingCompanyId))]
        [InverseProperty("AssetManagements")]
        public virtual AcceptingCompany AcceptingCompany { get; set; }
        [ForeignKey(nameof(SendingCompnyId))]
        [InverseProperty(nameof(SendingCompany.AssetManagements))]
        public virtual SendingCompany SendingCompny { get; set; }
    }
}
