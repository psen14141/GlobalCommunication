using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GloableCommunication.DbModels
{
    [Table("ConfirmStatus")]
    public partial class ConfirmStatus
    {
        [Key]
        public int ConfirmStatusId { get; set; }
        public int UserId { get; set; }
        public bool ConfirmDisplay { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty("ConfirmStatuses")]
        public virtual User User { get; set; }
    }
}
