using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GloableCommunication.DbModels;
using GloableCommunication.Areas.SendingCompanies.Model.ViewModels;

namespace GloableCommunication.Areas.SendingCompanies.Controllers
{

    [Area("SendingCompanies")]
    public class SendingCompany : Controller
    {
        //Sending Companies View
        public IActionResult Index()
        {

            List<SendingCompanyViewModel> sendingCompanyViewModels = new List<SendingCompanyViewModel>();
            using (GCommunicationContext db = new GCommunicationContext())
            {
                //Get companies with their countries and areas
                var sendingCompanies = db.SendingCompanies.Join
                    (db.Countries,
                        sendingCompany => sendingCompany.CountryId,
                        country => country.CountryId,
                        (sendingCompany, country) => new { SendingCompany = sendingCompany, Country = country }
                    );

                var areaSendingCompanies = sendingCompanies.Join
                    (db.Area,
                        sendingCompany => sendingCompany.SendingCompany.AreaId,
                        area => area.AreaId,
                        (sendingCompany, area) => new { SendingCompany = sendingCompany, Area = area }
                        );
                //Make SendingCompany view list 
                foreach (var sendingCompany in areaSendingCompanies)
                {

                    SendingCompanyViewModel sendingCompanyViewModel = new SendingCompanyViewModel();
                    sendingCompanyViewModel.SendingCompanyId = sendingCompany.SendingCompany.SendingCompany.SendingCompanyId;
                    sendingCompanyViewModel.SendingComapny = sendingCompany.SendingCompany.SendingCompany.SendingComapny;
                    sendingCompanyViewModel.SendingName = sendingCompany.SendingCompany.SendingCompany.SendingName;
                    sendingCompanyViewModel.Fullname = sendingCompany.SendingCompany.SendingCompany.Fullname;
                    sendingCompanyViewModel.CountryId = sendingCompany.SendingCompany.SendingCompany.CountryId;
                    sendingCompanyViewModel.AreaId = sendingCompany.SendingCompany.SendingCompany.AreaId;
                    sendingCompanyViewModel.Zip = sendingCompany.SendingCompany.SendingCompany.Zip;
                    sendingCompanyViewModel.Address1 = sendingCompany.SendingCompany.SendingCompany.Address1;
                    sendingCompanyViewModel.Address2 = sendingCompany.SendingCompany.SendingCompany.Address2;
                    sendingCompanyViewModel.Telephone = sendingCompany.SendingCompany.SendingCompany.Telephone;
                    sendingCompanyViewModel.Fax = sendingCompany.SendingCompany.SendingCompany.Fax;
                    sendingCompanyViewModel.CheifExecutiveOfficer = sendingCompany.SendingCompany.SendingCompany.CheifExecutiveOfficer;
                    sendingCompanyViewModel.Charge = sendingCompany.SendingCompany.SendingCompany.Charge;
                    sendingCompanyViewModel.ChargeTelephone = sendingCompany.SendingCompany.SendingCompany.ChargeTelephone;
                    sendingCompanyViewModel.Allowance = sendingCompany.SendingCompany.SendingCompany.Allowance;
                    sendingCompanyViewModel.InsertDate = sendingCompany.SendingCompany.SendingCompany.InsertDate;
                    sendingCompanyViewModel.UpdateDate = sendingCompany.SendingCompany.SendingCompany.UpdateDate;
                    sendingCompanyViewModel.Memo1 = sendingCompany.SendingCompany.SendingCompany.Memo1;
                    sendingCompanyViewModel.Memo2 = sendingCompany.SendingCompany.SendingCompany.Memo2;
                    sendingCompanyViewModel.Memo3 = sendingCompany.SendingCompany.SendingCompany.Memo3;
                    sendingCompanyViewModel.IsDeleteSendingCompany = sendingCompany.SendingCompany.SendingCompany.IsDeleteSendingCompany;
                    sendingCompanyViewModel.CountryName = sendingCompany.SendingCompany.Country.CountryName;
                    sendingCompanyViewModel.AreaName = sendingCompany.Area.AreaName;
                    sendingCompanyViewModels.Add(sendingCompanyViewModel);
                }

                
                    sendingCompanyViewModels = sendingCompanyViewModels.Where(w => w.IsDeleteSendingCompany == false).ToList();
                
            }

          return View(sendingCompanyViewModels);

        }



        //SearchData
        public IActionResult GetSearchData(SendingCompanyViewModel postData)
        {
            int CounId = postData.CountryId;
            int ArId = postData.AreaId;
            string SenComapny = postData.SendingComapny;

            List<SendingCompanyViewModel> sendingCompanyViewModels = new List<SendingCompanyViewModel>();
            using (GCommunicationContext db = new GCommunicationContext())
            {
                //Get companies with their countries and areas
                var sendingCompanies = db.SendingCompanies.Join
                    (db.Countries,
                        sendingCompany => sendingCompany.CountryId,
                        country => country.CountryId,
                        (sendingCompany, country) => new { SendingCompany = sendingCompany, Country = country }
                    );

                var areaSendingCompanies = sendingCompanies.Join
                    (db.Area,
                        sendingCompany => sendingCompany.SendingCompany.AreaId,
                        area => area.AreaId,
                        (sendingCompany, area) => new { SendingCompany = sendingCompany, Area = area }
                        );
                //Make SendingCompany view list 
                foreach (var sendingCompany in areaSendingCompanies)
                {

                    SendingCompanyViewModel sendingCompanyViewModel = new SendingCompanyViewModel();
                    sendingCompanyViewModel.SendingCompanyId = sendingCompany.SendingCompany.SendingCompany.SendingCompanyId;
                    sendingCompanyViewModel.SendingComapny = sendingCompany.SendingCompany.SendingCompany.SendingComapny;
                    sendingCompanyViewModel.SendingName = sendingCompany.SendingCompany.SendingCompany.SendingName;
                    sendingCompanyViewModel.Fullname = sendingCompany.SendingCompany.SendingCompany.Fullname;
                    sendingCompanyViewModel.CountryId = sendingCompany.SendingCompany.SendingCompany.CountryId;
                    sendingCompanyViewModel.AreaId = sendingCompany.SendingCompany.SendingCompany.AreaId;
                    sendingCompanyViewModel.Zip = sendingCompany.SendingCompany.SendingCompany.Zip;
                    sendingCompanyViewModel.Address1 = sendingCompany.SendingCompany.SendingCompany.Address1;
                    sendingCompanyViewModel.Address2 = sendingCompany.SendingCompany.SendingCompany.Address2;
                    sendingCompanyViewModel.Telephone = sendingCompany.SendingCompany.SendingCompany.Telephone;
                    sendingCompanyViewModel.Fax = sendingCompany.SendingCompany.SendingCompany.Fax;
                    sendingCompanyViewModel.CheifExecutiveOfficer = sendingCompany.SendingCompany.SendingCompany.CheifExecutiveOfficer;
                    sendingCompanyViewModel.Charge = sendingCompany.SendingCompany.SendingCompany.Charge;
                    sendingCompanyViewModel.ChargeTelephone = sendingCompany.SendingCompany.SendingCompany.ChargeTelephone;
                    sendingCompanyViewModel.Allowance = sendingCompany.SendingCompany.SendingCompany.Allowance;
                    sendingCompanyViewModel.InsertDate = sendingCompany.SendingCompany.SendingCompany.InsertDate;
                    sendingCompanyViewModel.UpdateDate = sendingCompany.SendingCompany.SendingCompany.UpdateDate;
                    sendingCompanyViewModel.Memo1 = sendingCompany.SendingCompany.SendingCompany.Memo1;
                    sendingCompanyViewModel.Memo2 = sendingCompany.SendingCompany.SendingCompany.Memo2;
                    sendingCompanyViewModel.Memo3 = sendingCompany.SendingCompany.SendingCompany.Memo3;
                    sendingCompanyViewModel.IsDeleteSendingCompany = sendingCompany.SendingCompany.SendingCompany.IsDeleteSendingCompany;
                    sendingCompanyViewModel.CountryName = sendingCompany.SendingCompany.Country.CountryName;
                    sendingCompanyViewModel.AreaName = sendingCompany.Area.AreaName;
                    sendingCompanyViewModels.Add(sendingCompanyViewModel);
                }

                if (CounId != 0)
                {
                    sendingCompanyViewModels = sendingCompanyViewModels.Where(w => w.IsDeleteSendingCompany == false).Where(w => w.CountryId == CounId).ToList();
                }

                if (ArId != 0)
                {
                    sendingCompanyViewModels = sendingCompanyViewModels.Where(w => w.IsDeleteSendingCompany == false).Where(w => w.AreaId == ArId).ToList();
                }


                if (SenComapny != null)
                {
                    sendingCompanyViewModels = sendingCompanyViewModels.Where(w => w.IsDeleteSendingCompany == false).Where(w => w.SendingComapny.Trim() == SenComapny).ToList();
                }

                else
                {
                    sendingCompanyViewModels = sendingCompanyViewModels.Where(w => w.IsDeleteSendingCompany == false).ToList();
                }
            }

        return View(sendingCompanyViewModels);
        }

         

        //Sending Companies Add or Edit

        public IActionResult AddorEditView(int Id = 0)
        {
            SendingCompanyViewModel sendingViewModel = new SendingCompanyViewModel();
            long SendingCodeMax = 0;
            using (GCommunicationContext db = new GCommunicationContext())
            {

                if (Id != 0)
                {

                    var sendingCompanies = db.SendingCompanies.Where(w => w.SendingCompanyId == Id).Join
                   (db.Countries,
                       sendingCompany => sendingCompany.CountryId,
                       country => country.CountryId,
                       (sendingCompany, country) => new { SendingCompany = sendingCompany, Country = country }
                   ).FirstOrDefault();


                    var areaSendingCompanies = db.SendingCompanies.Where(w => w.SendingCompanyId == Id).Join
                   (db.Area,
                       sendingCompany => sendingCompany.AreaId,
                       area => area.AreaId,
                       (sendingCompany, area) => new { SendingCompany = sendingCompany, Area = area }
                       ).FirstOrDefault();

                    GloableCommunication.DbModels.SendingCompany sending = db.SendingCompanies.Where(w => w.SendingCompanyId == Id).First();

                    sendingViewModel.SendingCompanyId = sending.SendingCompanyId;

                    sendingViewModel.SendingComapny = sending.SendingComapny.Trim();

                    if (sending.SendingName == null) { sendingViewModel.SendingName = null; }
                    else{ sendingViewModel.SendingName = sending.SendingName.Trim();}

                    sendingViewModel.Fullname = sending.Fullname.Trim();

                    sendingViewModel.CountryId = sending.CountryId;
                    sendingViewModel.AreaId = sending.AreaId;
                    if (sending.Zip == null) { sendingViewModel.Zip = null; }
                    else { sendingViewModel.Zip = sending.Zip.Trim(); }

                    if (sending.Address1 == null) { sendingViewModel.Address1 = null; }
                    else { sendingViewModel.Address1 = sending.Address1.Trim(); }

                    if (sending.Address2 == null) { sendingViewModel.Address2 = null; }
                    else { sendingViewModel.Address2 = sending.Address2.Trim(); }

                    if (sending.Telephone == null) { sendingViewModel.Telephone = null; }
                    else{ sendingViewModel.Telephone = sending.Telephone.Trim();}

                    if (sending.Fax == null) { sendingViewModel.Fax = null; }
                    else { sendingViewModel.Fax = sending.Fax.Trim(); }

                    if (sending.CheifExecutiveOfficer == null) { sendingViewModel.CheifExecutiveOfficer = null; }
                    else { sendingViewModel.CheifExecutiveOfficer = sending.CheifExecutiveOfficer.Trim(); }

                    if (sending.Charge == null) { sendingViewModel.Charge = null; }
                    else { sendingViewModel.Charge = sending.Charge.Trim(); }

                    if (sending.ChargeTelephone == null) { sendingViewModel.ChargeTelephone = null; }
                    else { sendingViewModel.ChargeTelephone = sending.ChargeTelephone.Trim(); }

                    sendingViewModel.InsertDate = sending.InsertDate;
                    sendingViewModel.UpdateDate = sending.UpdateDate;

                    if (sending.Memo1 == null) { sendingViewModel.Memo1 = null; }
                    else { sendingViewModel.Memo1 = sending.Memo1.Trim(); }

                    sendingViewModel.IsDeleteSendingCompany = sending.IsDeleteSendingCompany;


                    sendingViewModel.CountryName = sendingCompanies.Country.CountryName.Trim();
                    sendingViewModel.AreaName = areaSendingCompanies.Area.AreaName.Trim();

                }
                else
                {
                    sendingViewModel.sendingCompanies = db.SendingCompanies.Where(W=>W.IsDeleteSendingCompany==false).ToList();

                    List<CodeList> codeLists = new List<CodeList>();

                    foreach (var item in sendingViewModel.sendingCompanies)
                    {

                        CodeList codeList = new CodeList();
                        codeList.SendingCode = long.Parse(item.SendingComapny);
                        codeLists.Add(codeList);
                    }

                    codeLists = codeLists.ToList();

                   SendingCodeMax = codeLists.Max(M=>M.SendingCode) +1;
                    
                string sendingCompanyId = SendingCodeMax.ToString().PadLeft(6, '0');

                sendingViewModel.SendingComapny = sendingCompanyId;

                }
                sendingViewModel.sendingCompanies = db.SendingCompanies.ToList();
            }



            return View(sendingViewModel);
        }


 // New Sending Company Save Function
        public IActionResult SaveData(DbModels.SendingCompany sendingCompany)
        {
            using (GCommunicationContext db = new GCommunicationContext())
            {
                if (sendingCompany.SendingCompanyId == 0)
                {

                    db.SendingCompanies.Add(sendingCompany);
                }
                else
                {
                    DbModels.SendingCompany dbSendingCompany = db.SendingCompanies.Where(w => w.SendingCompanyId == sendingCompany.SendingCompanyId).First();

                    dbSendingCompany.SendingCompanyId = sendingCompany.SendingCompanyId;
                    dbSendingCompany.SendingComapny = sendingCompany.SendingComapny;
                    dbSendingCompany.SendingName = sendingCompany.SendingName;
                    dbSendingCompany.Fullname = sendingCompany.Fullname;
                    dbSendingCompany.CountryId = sendingCompany.CountryId;
                    dbSendingCompany.AreaId = sendingCompany.AreaId;
                    dbSendingCompany.Zip = sendingCompany.Zip;
                    dbSendingCompany.Address1 = sendingCompany.Address1;
                    dbSendingCompany.Address2 = sendingCompany.Address2;
                    dbSendingCompany.Telephone = sendingCompany.Telephone;
                    dbSendingCompany.Fax = sendingCompany.Fax;
                    dbSendingCompany.CheifExecutiveOfficer = sendingCompany.CheifExecutiveOfficer;
                    dbSendingCompany.Charge = sendingCompany.Charge;
                    dbSendingCompany.ChargeTelephone = sendingCompany.ChargeTelephone;
                    dbSendingCompany.InsertDate = sendingCompany.InsertDate;
                    dbSendingCompany.UpdateDate = sendingCompany.UpdateDate;
                    dbSendingCompany.Memo1 = sendingCompany.Memo1;
                    dbSendingCompany.IsDeleteSendingCompany = sendingCompany.IsDeleteSendingCompany;
                }

                db.SaveChanges();
            }

            return Redirect("/SendingCompanies/SendingCompany/Index");
        }

        //Detail view
        public IActionResult DetailView(int Id)
        {
            SendingCompanyViewModel sendingViewModels = new SendingCompanyViewModel();
            using (GCommunicationContext db = new GCommunicationContext())
            {
                sendingViewModels.SendingCompanyDetail = db.SendingCompanies.Where(w => w.SendingCompanyId == Id).FirstOrDefault();

                sendingViewModels.sendingCountry = db.SendingCompanies.Where(w => w.SendingCompanyId == Id).Join(db.Countries,
                            sendingCompany => sendingCompany.CountryId,
                            country => country.CountryId,
                            (sendingCompany, country) => new { SendingCompany = sendingCompany, Country = country })
                        .Select(s => s.Country).ToList();

                sendingViewModels.sendingArea = db.SendingCompanies.Where(w => w.SendingCompanyId == Id).Join(db.Area,
                           sendingCompany => sendingCompany.AreaId,
                           area => area.AreaId,
                           (sendingCompany, area) => new { SendingCompany = sendingCompany, Area = area })
                       .Select(s => s.Area).ToList()
                       ;

            }


            return View(sendingViewModels);
        }


        // Delete Sending Company Delete view
        public IActionResult Delete(int Id)
        {
            using (GCommunicationContext db = new GCommunicationContext())
            {
                DbModels.SendingCompany sendingCompany = db.SendingCompanies.Where(w => w.SendingCompanyId == Id).First();

                //db.SendingCompanies.Remove(sendingCompany);
                sendingCompany.IsDeleteSendingCompany = true;
                db.SaveChanges();

            }

            return Redirect("/SendingCompanies/SendingCompany/Index");
        }



        //Country List View
        public IActionResult CountyListView()
        {
            List<Country> countries = new List<Country>();
            using (GCommunicationContext db = new GCommunicationContext())
            {
                    countries = db.Countries.Where(w => w.IsDeleteCountry == false).ToList();
            }
            return View(countries);
        }


        //Area List View
        public IActionResult AreaListView()
        {
            List<Area> areas = new List<Area>();
            using (GCommunicationContext db = new GCommunicationContext())
            {
                areas = db.Area.Where(w => w.IsDeleteArea == false).ToList();
            }
            return View(areas);
        }


    }
}
