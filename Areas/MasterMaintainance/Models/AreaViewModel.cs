using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GloableCommunication.Areas.MasterMaintainance.Models.ViewModels
{

    public class AreaViewModel
    {
        public DbModels.Area Area { get; set; }
        public long AreaId { get; set; }
        public int AreaCode { get; set; }
        public string AreaName { get; set; }
        public DateTime InsertDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public bool IsDeleteArea { get; set; }

        //public virtual CountryViewModel Country { get; set; }

        public List<DbModels.Country> Countries = new List<GloableCommunication.DbModels.Country>();

        public List<DbModels.Area> Areas = new List<GloableCommunication.DbModels.Area>();


        public List<CodeList> AreacodeLists { get; set; } = new List<CodeList>();
        public long AreaLastId { get; set; }

    }
    public class CodeList
    {

        public long AreaCode { get; set; }
    }

}
