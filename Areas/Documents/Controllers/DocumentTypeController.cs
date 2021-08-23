using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GloableCommunication.DbModels;

namespace GloableCommunication.Areas.Documents.Controllers
{
    [Area("Documents")]
    public class DocumentTypeController : Controller
    {//DocumentType View
        public IActionResult Index()
        {
            List<GloableCommunication.DbModels.DocumentType> documentTypes = new List<GloableCommunication.DbModels.DocumentType>();
            using (GCommunicationContext db = new GCommunicationContext())
            {
                documentTypes = db.DocumentTypes.Where(w => w.DcouemntTypeIsDelete == false).ToList();
            }

          
            return View(documentTypes);
        }

        //DocumentType Add or Edit

        public IActionResult AddorEditView(int Id = 0)
        {
            DocumentType type = null;
            if (Id == 0)
            {
                type = new DocumentType();
                type.DocumentTypeId = 0;
            }
            else
            {
                using (GCommunicationContext db = new GCommunicationContext())
                {
                    type = db.DocumentTypes.Where(w => w.DocumentTypeId == Id).First();
                }
            }
            return View(type);


        }

        // New Document Type Save Function
        public IActionResult SaveData(DocumentType type)
        {
            using (GCommunicationContext db = new GCommunicationContext())
            {
                if (type.DocumentTypeId == 0)
                {
                    db.DocumentTypes.Add(type);
                }
                else
                {
                    DocumentType dbDocumentType = db.DocumentTypes.Where(w => w.DocumentTypeId == type.DocumentTypeId).First();

                    dbDocumentType.DocumentTypeId = type.DocumentTypeId;
                    dbDocumentType.DocumentTypeName = type.DocumentTypeName;
                    dbDocumentType.DocumentTypeDescription = type.DocumentTypeDescription;
                    dbDocumentType.DcouemntTypeIsDelete = type.DcouemntTypeIsDelete;
                }

                db.SaveChanges();
            }

            return Redirect("/Documents/DocumentType/Index");
        }


        // Delete Document Type
        public IActionResult Delete(int Id)
        {
            using (GCommunicationContext db = new GCommunicationContext())
            {
                DocumentType type = db.DocumentTypes.Where(w => w.DocumentTypeId == Id).First();

                type.DcouemntTypeIsDelete = true;
                db.SaveChanges();

            }

            return Redirect("/Documents/DocumentType/Index");
        }

    }
}
