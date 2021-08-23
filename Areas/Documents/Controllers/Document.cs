using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using GloableCommunication.DbModels;
using GloableCommunication.Areas.Documents.Models.ViewModels;
using GloableCommunication.ProPlatform.FileManager;
using System.IO;
using System.Net.Http;
using System.Net;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http;

namespace GloableCommunication.Areas.Documents.Controllers
{
    [Area("Documents")]
    public class DocumentController : Controller
    {
        //Document View
        public IActionResult MediaManager()
        {
            return View();

        }
        public IActionResult Index()
        {

            List<DocumentViewModel> documentViewModels = new List<DocumentViewModel>();
            using (GCommunicationContext db = new GCommunicationContext())
            {
                //documents = db.Document.Where(w=> w.DocumentIsDelete == false).ToList();

                //Get documents with their types
                var documents = db.Documents.Join
                    (db.DocumentTypes,
                        document => document.DocumentTypeId,
                        documentType => documentType.DocumentTypeId,
                        (document, documentType) => new { Document = document, DocumentType = documentType }
                    );
                //Make document view list
                foreach (var document in documents)
                {

                    DocumentViewModel documentViewModel = new DocumentViewModel();
                    documentViewModel.DocumentId = document.Document.DocumentId;
                    documentViewModel.DocumentTypeId = document.Document.DocumentTypeId;
                    documentViewModel.DocumentName = document.Document.DocumentName;
                    documentViewModel.DocumentDescription = document.Document.DocumentDescription;
                    documentViewModel.DocumentFilePath = document.Document.DocumentFilePath;
                    documentViewModel.DocumentIsDelete = document.Document.DocumentIsDelete;
                    documentViewModel.DocumentTypeName = document.DocumentType.DocumentTypeName;
                    documentViewModels.Add(documentViewModel);
                }


            }

            documentViewModels = documentViewModels.Where(w => w.DocumentIsDelete == false).ToList();
            return View(documentViewModels);
        }

        //Add or Edit Document
        public IActionResult AddorEditView(AddDocPara req)
        {

            DocumentViewModel documentManagement = new DocumentViewModel();
            documentManagement.Flag = req.Flag;
            using (GCommunicationContext db = new GCommunicationContext())
            {
                if (req.Id != 0)
                {
                    GloableCommunication.DbModels.Document document = db.Documents
                        .Where(w => w.DocumentId == req.Id).First();

                    documentManagement.DocumentId = document.DocumentId;
                    documentManagement.DocumentTypeId = document.DocumentTypeId;
                    documentManagement.DocumentName = document.DocumentName;
                    documentManagement.DocumentDescription = document.DocumentDescription;
                    documentManagement.DocumentFilePath = document.DocumentFilePath;
                    documentManagement.DocumentIsDelete = document.DocumentIsDelete;
                }

                documentManagement.DocumentTypes = db.DocumentTypes.Where(w => w.DcouemntTypeIsDelete == false).ToList();
            }

            return View(documentManagement);
        }

        // New Document Save Function
        public IActionResult SaveData(Document document)
        {
            //FileStore fileStore = new FileStore();

            //List<FileData> addedFiles  = fileStore.StoreUploadFiles(Request.HttpContext, document.DocumentTypeId, document.DocumentName, document.DocumentDescription, document.DocumentId);
            using (GCommunicationContext db = new GCommunicationContext())
            {
                //document.DocumentFilePath = addedFiles[0].document.DocumentFilePath;
                if (document.DocumentId == 0)
                {
                    FileStore fileStore = new FileStore();

                    List<FileData> addedFiles = fileStore.StoreUploadFiles(Request.HttpContext, document.DocumentTypeId, document.DocumentName, document.DocumentDescription, document.DocumentId);
                    document.DocumentFilePath = addedFiles[0].document.DocumentFilePath;
                    db.Documents.Add(document);
                }
                else
                {
                    Document dbDocument = db.Documents.Where(w => w.DocumentId == document.DocumentId).First();

                    dbDocument.DocumentId = document.DocumentId;
                    dbDocument.DocumentTypeId = document.DocumentTypeId;
                    dbDocument.DocumentName = document.DocumentName;
                    dbDocument.DocumentDescription = document.DocumentDescription;
                    //dbDocument.DocumentFilePath = document.DocumentFilePath;
                    dbDocument.DocumentIsDelete = document.DocumentIsDelete;
                }

                db.SaveChanges();
            }

            return Redirect("/Documents/Documet/Index");
        }


        // Delete Document
        public IActionResult Delete(int Id)
        {
            using (GCommunicationContext db = new GCommunicationContext())
            {
                GloableCommunication.DbModels.Document document = db.Documents.Where(w => w.DocumentId == Id).First();
                document.DocumentIsDelete = true;

                db.SaveChanges();

            }

            return Redirect("/Documents/Document/Index");
        }


        public IActionResult DownloadFile(int Id)
        {


            string documentPath = "";
            byte[] bytes = null;
            using (GCommunicationContext db = new GCommunicationContext())
            {
                var documentViewModel1 = db.Documents.Where(w => w.DocumentId == Id).ToList();
                foreach (var item in documentViewModel1)
                {
                    documentPath = item.DocumentFilePath;
                }
            }

            try
            {
                bytes = System.IO.File.ReadAllBytes(documentPath);

            }
            catch (Exception e)
            {
                documentPath = "DataFolder/1/Users/User/profile.jpg";
                bytes = System.IO.File.ReadAllBytes("DataFolder/1/Users/User/profile.jpg");

            }


            FileInfo fileInfo = new FileInfo(documentPath);
            string fileName = documentPath.Split("\\").Last();
            return File(bytes, "application/octet-stream", fileName);

        }
    }


    public class AddDocPara
    {
        public int Id { get; set; } = 0;
        public long Flag { get; set; } = 0;
    }

}
