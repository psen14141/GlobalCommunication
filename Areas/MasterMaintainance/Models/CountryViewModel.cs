using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GloableCommunication.Areas.MasterMaintainance.Models.ViewModels
{
    public class CountryViewModel
    {
        public int CountryId { get; set; }
        public int CountryCode { get; set; }
        public string CountryName { get; set; }
        public DateTime? UpdateDateTime { get; set; }
        public DateTime InsertDateTime { get; set; }

        public List<DbModels.Country> Countries = new List<GloableCommunication.DbModels.Country>();

        public List<DbModels.Area> Areas = new List<GloableCommunication.DbModels.Area>();


        public List<CodeListCountry> CountryCodelist { get; set; } = new List<CodeListCountry>();
        public long CountryLastId { get; set; }

    }
    public class CodeListCountry
    {

        public long CountryCode { get; set; }
    }
}
