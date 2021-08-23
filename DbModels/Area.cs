using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GloableCommunication.DbModels
{
    [Table("Area")]
    public partial class Area
    {
        public Area()
        {
            AcceptingCompanies = new HashSet<AcceptingCompany>();
            Perfectures = new HashSet<Perfecture>();
            SendingCompanies = new HashSet<SendingCompany>();
        }

        [Key]
        public int AreaId { get; set; }
        public int AreaCode { get; set; }
        [Required]
        [StringLength(50)]
        public string AreaName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime InsertDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdateDateTime { get; set; }
        public int CountryId { get; set; }
        public bool IsDeleteArea { get; set; }

        [ForeignKey(nameof(CountryId))]
        [InverseProperty("Areas")]
        public virtual Country Country { get; set; }
        [InverseProperty(nameof(AcceptingCompany.Area))]
        public virtual ICollection<AcceptingCompany> AcceptingCompanies { get; set; }
        [InverseProperty(nameof(Perfecture.Area))]
        public virtual ICollection<Perfecture> Perfectures { get; set; }
        [InverseProperty(nameof(SendingCompany.Area))]
        public virtual ICollection<SendingCompany> SendingCompanies { get; set; }
    }
}
