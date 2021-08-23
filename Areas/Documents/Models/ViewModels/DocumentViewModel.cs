using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GloableCommunication.DbModels;

namespace GloableCommunication.Areas.Documents.Models.ViewModels
{
    public class DocumentViewModel
    {


        public long DocumentId { get; set; }
        public long DocumentTypeId { get; set; }
        public string DocumentName { get; set; }
        public string DocumentDescription { get; set; }
        public string DocumentFilePath { get; set; }
        public bool DocumentIsDelete { get; set; }

        public long? InstituteId { get; set; }

        public long Flag { get; set; }

        public string DocumentTypeName { get; set; }

        public List<DocumentType> DocumentTypes { get; set; } = new List<DocumentType>();

    }
}
