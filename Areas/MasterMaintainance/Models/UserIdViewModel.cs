using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GloableCommunication.Areas.MasterMaintainance.Models.ViewModels
{
    public class UserIdViewModel
    {
        public long UserId { get; set; }
        public string UserCode { get; set; }
        public string Password { get; set; }

        public string Email { get; set; }

        public int? AccessFlag { get; set; }
        public DateTime InsertDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }

        public List<DbModels.User> Users = new List<GloableCommunication.DbModels.User>();

        //public List<DbModels.Area> Areas = new List<GloableCommunication.DbModels.Area>();



    }
}
