using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GloableCommunication.DbModels
{
    [Table("Country")]
    public partial class Country
    {
        public Country()
        {
            Areas = new HashSet<Area>();
            SendingCompanies = new HashSet<SendingCompany>();
            TraineeMasters = new HashSet<TraineeMaster>();
        }

        [Key]
        public int CountryId { get; set; }
        public int CountryCode { get; set; }
        [Required]
        [StringLength(50)]
        public string CountryName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime InsertDateTime { get; set; }
        public bool IsDeleteCountry { get; set; }

        [InverseProperty(nameof(Area.Country))]
        public virtual ICollection<Area> Areas { get; set; }
        [InverseProperty(nameof(SendingCompany.Country))]
        public virtual ICollection<SendingCompany> SendingCompanies { get; set; }
        [InverseProperty(nameof(TraineeMaster.Country))]
        public virtual ICollection<TraineeMaster> TraineeMasters { get; set; }
    }
}
