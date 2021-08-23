using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GloableCommunication.DbModels;

namespace GloableCommunication.Areas.Documents.Models.ViewModels
{
    public class DocumentTypeViewModel
    {

        public long DocumentTypeId { get; set; }
        public long InsitutteId { get; set; }
        public long DocumentTypeParentId { get; set; }
        public string DocumentTypeName { get; set; }
        public string DocumentTypeDescription { get; set; }
        public bool DocumentTypeIsDelete { get; set; }
        public string FolderPath { get; set; }

        //public string InstituteName { get; set; }

        //public List<Institute> Institutes { get; set; } = new List<Institute>();

    }
}
