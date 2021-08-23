using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GloableCommunication.DbModels;
using GloableCommunication.Areas.AcceptingCompany.Model.ViewModel;

namespace GloableCommunication.Areas.AcceptingCompany.Controllers
{
    [Area("AcceptingCompany")]
    public class AcceptingCompanyController : Controller
    {
        public IActionResult Index(AcceptingCompanyViewModel postData)
        {
          
            List<AcceptingCompanyViewModel> acceptingCompanyViewModels = new List<AcceptingCompanyViewModel>();
            using (GCommunicationContext db = new GCommunicationContext())
            {
                var accepting1 = db.AcceptingCompanies.Join
                    (db.Area,
                    accepting => accepting.AreaId,
                    area => area.AreaId,
                    (accepting, area) => new { AcceptingCompany = accepting, Area = area }
                    );

                var accepting2 = accepting1.Join
                   (db.Perfectures,
                   accepting => accepting.AcceptingCompany.PerfectureId,
                   prefecture => prefecture.PerfectureId,
                   (accepting, prefecture) => new { AcceptingCompany = accepting, Perfecture = prefecture }
                   );

                foreach (var acceptingCompany in accepting2)
                {
                    AcceptingCompanyViewModel acceptingCompanyViewModel = new AcceptingCompanyViewModel();
                    acceptingCompanyViewModel.AcceptingCompanyId = acceptingCompany.AcceptingCompany.AcceptingCompany.AcceptingCompanyId;
                    acceptingCompanyViewModel.AcceptingCompanyCode = acceptingCompany.AcceptingCompany.AcceptingCompany.AcceptingCompanyCode;
                    acceptingCompanyViewModel.AcceptiingCompanyName = acceptingCompany.AcceptingCompany.AcceptingCompany.AcceptiingCompanyName;
                    acceptingCompanyViewModel.AreaId = acceptingCompany.AcceptingCompany.AcceptingCompany.AreaId;
                    acceptingCompanyViewModel.PerfectureId = acceptingCompany.AcceptingCompany.AcceptingCompany.PerfectureId;
                    acceptingCompanyViewModel.AreaName = acceptingCompany.AcceptingCompany.AcceptingCompany.Area.AreaName;
                    acceptingCompanyViewModel.PerfectureName = acceptingCompany.AcceptingCompany.AcceptingCompany.Perfecture.PerfectureName;
                    acceptingCompanyViewModel.IsDeleteAcceptCom = acceptingCompany.AcceptingCompany.AcceptingCompany.IsDeleteAcceptCom;
                    int count = getCount(acceptingCompanyViewModel.AcceptingCompanyId);
                    acceptingCompanyViewModel.entranceCount = count;
                    acceptingCompanyViewModels.Add(acceptingCompanyViewModel);
                }
                acceptingCompanyViewModels = acceptingCompanyViewModels.Where(w => w.IsDeleteAcceptCom == false).ToList();
            }
                return View(acceptingCompanyViewModels);
        }
        public int getCount(int accId)
        {
            int count = 0;
            List<AcceptingCompanyViewModel> acceptingCompanyViewModels = new List<AcceptingCompanyViewModel>();
            using (GCommunicationContext db = new GCommunicationContext())
            {
                var accepting = db.AcceptingCompanies.Where(w => w.AcceptingCompanyId == accId).Join
                    (db.TraineeMasters,
                    accepting => accepting.AcceptingCompanyId,
                    train => train.AcceptingCompanyId,
                    (accepting, train) => new { AcceptingCompany = accepting, TraineeMaster = train }
                    );
                foreach (var item in accepting)
                {
                    //AcceptingCompanyViewModel acceptingCompanyViewModel = new AcceptingCompanyViewModel();
                    if (item.TraineeMaster.EntranceStatus != null)
                    {
                        int status = int.Parse(item.TraineeMaster.EntranceStatus);
                        if (status != 1)
                        {
                            count++;

                        }
                    }
                }
            }
            return count;
        }
        public IActionResult SearchData(AcceptingCompanyViewModel postData)
        {
            int AreaId = postData.AreaId;
            int PerfectureId = postData.PerfectureId;
            string AccCode = postData.AcceptingCompanyCode;
            string Limit = postData.Limit;
            //int limit = int.Parse(Limit);

            List<AcceptingCompanyViewModel> acceptingCompanyViewModels = new List<AcceptingCompanyViewModel>();
            using (GCommunicationContext db = new GCommunicationContext())
            {
                var accepting1 = db.AcceptingCompanies.Join
                   (db.Area,
                   accepting => accepting.AreaId,
                   area => area.AreaId,
                   (accepting, area) => new { AcceptingCompany = accepting, Area = area }
                   );

                var accepting2 = accepting1.Join
                   (db.Perfectures,
                   accepting => accepting.AcceptingCompany.PerfectureId,
                   prefecture => prefecture.PerfectureId,
                   (accepting, prefecture) => new { AcceptingCompany = accepting, Perfecture = prefecture }
                   );
                foreach (var acceptingCompany in accepting2)
                {
                    AcceptingCompanyViewModel acceptingCompanyViewModel = new AcceptingCompanyViewModel();
                    acceptingCompanyViewModel.AcceptingCompanyId = acceptingCompany.AcceptingCompany.AcceptingCompany.AcceptingCompanyId;
                    acceptingCompanyViewModel.AcceptingCompanyCode = acceptingCompany.AcceptingCompany.AcceptingCompany.AcceptingCompanyCode;
                    acceptingCompanyViewModel.AcceptiingCompanyName = acceptingCompany.AcceptingCompany.AcceptingCompany.AcceptiingCompanyName;                   
                    acceptingCompanyViewModel.AreaId = acceptingCompany.AcceptingCompany.AcceptingCompany.AreaId;
                    acceptingCompanyViewModel.PerfectureId = acceptingCompany.AcceptingCompany.AcceptingCompany.PerfectureId;
                    acceptingCompanyViewModel.AreaName = acceptingCompany.AcceptingCompany.AcceptingCompany.Area.AreaName;
                    acceptingCompanyViewModel.PerfectureName = acceptingCompany.AcceptingCompany.AcceptingCompany.Perfecture.PerfectureName;
                    acceptingCompanyViewModel.IsDeleteAcceptCom = acceptingCompany.AcceptingCompany.AcceptingCompany.IsDeleteAcceptCom;
                    int count = getCount(acceptingCompanyViewModel.AcceptingCompanyId);
                    acceptingCompanyViewModel.entranceCount = count;
                    acceptingCompanyViewModels.Add(acceptingCompanyViewModel);
                }
                if(AreaId != 0)
                {
                    acceptingCompanyViewModels = acceptingCompanyViewModels.Where(w => w.IsDeleteAcceptCom == false).Where(w => w.AreaId == AreaId).ToList();
                }
                if(PerfectureId != 0)
                {
                    acceptingCompanyViewModels = acceptingCompanyViewModels.Where(w => w.IsDeleteAcceptCom == false).Where(w => w.PerfectureId == PerfectureId).ToList();
                }
                if(AccCode != null)
                {
                    acceptingCompanyViewModels = acceptingCompanyViewModels.Where(w => w.IsDeleteAcceptCom == false).Where(w => w.AcceptingCompanyCode.Trim() == AccCode).ToList();
                }
                if(Limit != null)
                {
                    acceptingCompanyViewModels = acceptingCompanyViewModels.Where(w => w.IsDeleteAcceptCom == false).ToList();
                }
                else
                {
                    acceptingCompanyViewModels = acceptingCompanyViewModels.Where(w => w.IsDeleteAcceptCom == false).ToList();
                }
            }

                return View(acceptingCompanyViewModels);
        }

        public IActionResult Add(int Id = 0)
        {
            AcceptingCompanyViewModel acceptingCompanyViewModel = new AcceptingCompanyViewModel();
            using (GCommunicationContext db = new GCommunicationContext())
            {
                if (Id != 0)
                {
                    var accepting1 = db.AcceptingCompanies.Where(w => w.AcceptingCompanyId == Id).Join
                   (db.Area,
                   accepting => accepting.AreaId,
                   area => area.AreaId,
                   (accepting, area) => new { AcceptingCompany = accepting, Area = area }
                   ).FirstOrDefault();

                    var accepting2 = db.AcceptingCompanies.Where(w => w.AcceptingCompanyId == Id).Join
                       (db.Perfectures,
                       accepting => accepting.PerfectureId,
                       prefecture => prefecture.PerfectureId,
                       (accepting, prefecture) => new { AcceptingCompany = accepting, Perfecture = prefecture }
                       ).FirstOrDefault();

                    DbModels.AcceptingCompany acceptingCompany = db.AcceptingCompanies.Where(w => w.AcceptingCompanyId == Id).FirstOrDefault();
                    acceptingCompanyViewModel.AcceptingCompanyId = acceptingCompany.AcceptingCompanyId;
                    acceptingCompanyViewModel.AcceptingCompanyCode = acceptingCompany.AcceptingCompanyCode.Trim();
                    if(acceptingCompany.AcceptiingCompanyName == null)
                    {
                        acceptingCompanyViewModel.AcceptiingCompanyName = null;
                    }
                    else
                    {
                        acceptingCompanyViewModel.AcceptiingCompanyName = acceptingCompany.AcceptiingCompanyName.Trim();
                    }
                    if (acceptingCompany.HiraganaName == null)
                    {
                        acceptingCompanyViewModel.HiraganaName = null;
                    }
                    else
                    {
                        acceptingCompanyViewModel.HiraganaName = acceptingCompany.HiraganaName.Trim();
                    }
                    if (acceptingCompany.EnglishName == null)
                    {
                        acceptingCompanyViewModel.EnglishName = null;
                    }
                    else
                    {
                        acceptingCompanyViewModel.EnglishName = acceptingCompany.EnglishName.Trim();
                    }
                    acceptingCompanyViewModel.AreaId = acceptingCompany.AreaId;
                    acceptingCompanyViewModel.PerfectureId = acceptingCompany.PerfectureId;
                    if (acceptingCompany.Zip == null)
                    {
                        acceptingCompanyViewModel.Zip = null;
                    }
                    else
                    {
                        acceptingCompanyViewModel.Zip = acceptingCompany.Zip.Trim();
                    }
                    if (acceptingCompany.Address1 == null)
                    {
                        acceptingCompanyViewModel.Address1 = null;
                    }
                    else
                    {
                        acceptingCompanyViewModel.Address1 = acceptingCompany.Address1.Trim();
                    }
                    if (acceptingCompany.Address2 == null)
                    {
                        acceptingCompanyViewModel.Address2 = null;
                    }
                    else
                    {
                        acceptingCompanyViewModel.Address2 = acceptingCompany.Address2.Trim();
                    }
                    if (acceptingCompany.TelephoneNo == null)
                    {
                        acceptingCompanyViewModel.TelephoneNo = null;
                    }
                    else
                    {
                        acceptingCompanyViewModel.TelephoneNo = acceptingCompany.TelephoneNo.Trim();
                    }
                    if (acceptingCompany.Fax == null)
                    {
                        acceptingCompanyViewModel.Fax = null;
                    }
                    else
                    {
                        acceptingCompanyViewModel.Fax = acceptingCompany.Fax.Trim();
                    }
                    if (acceptingCompany.CheifExecutiveOfficer == null)
                    {
                        acceptingCompanyViewModel.CheifExecutiveOfficer = null;
                    }
                    else
                    {
                        acceptingCompanyViewModel.CheifExecutiveOfficer = acceptingCompany.CheifExecutiveOfficer.Trim();
                    }
                    if (acceptingCompany.Member == null)
                    {
                        acceptingCompanyViewModel.Member = null;
                    }
                    else
                    {
                        acceptingCompanyViewModel.Member = acceptingCompany.Member.Trim();
                    }
                    acceptingCompanyViewModel.CapitalStock = acceptingCompany.CapitalStock;
                    if (acceptingCompany.Business == null)
                    {
                        acceptingCompanyViewModel.Business = null;
                    }
                    else
                    {
                        acceptingCompanyViewModel.Business = acceptingCompany.Business.Trim();
                    }
                    if (acceptingCompany.Charge == null)
                    {
                        acceptingCompanyViewModel.Charge = null;
                    }
                    else
                    {
                        acceptingCompanyViewModel.Charge = acceptingCompany.Charge.Trim();
                    }
                    acceptingCompanyViewModel.InsertDate = acceptingCompany.InsertDate;
                    acceptingCompanyViewModel.UpdateDate = acceptingCompany.UpdateDate;
                    if (acceptingCompany.TrainingZip == null)
                    {
                        acceptingCompanyViewModel.TrainingZip = null;
                    }
                    else
                    {
                        acceptingCompanyViewModel.TrainingZip = acceptingCompany.TrainingZip.Trim();
                    }
                    if (acceptingCompany.TrainingAdress1 == null)
                    {
                        acceptingCompanyViewModel.TrainingAdress1 = null;
                    }
                    else
                    {
                        acceptingCompanyViewModel.TrainingAdress1 = acceptingCompany.TrainingAdress1.Trim();
                    }
                    if (acceptingCompany.TrainingAdress2 == null)
                    {
                        acceptingCompanyViewModel.TrainingAdress2 = null;
                    }
                    else
                    {
                        acceptingCompanyViewModel.TrainingAdress2 = acceptingCompany.TrainingAdress2.Trim();
                    }
                    if (acceptingCompany.TrainingTel == null)
                    {
                        acceptingCompanyViewModel.TrainingTel = null;
                    }
                    else
                    {
                        acceptingCompanyViewModel.TrainingTel = acceptingCompany.TrainingTel.Trim();
                    }
                    if (acceptingCompany.TrainingFax == null)
                    {
                        acceptingCompanyViewModel.TrainingFax = null;
                    }
                    else
                    {
                        acceptingCompanyViewModel.TrainingFax = acceptingCompany.TrainingFax.Trim();
                    }
                    if (acceptingCompany.Memo1 == null)
                    {
                        acceptingCompanyViewModel.Memo1 = null;
                    }
                    else
                    {
                        acceptingCompanyViewModel.Memo1 = acceptingCompany.Memo1.Trim();
                    }
                    acceptingCompanyViewModel.TrainingPrefectureCd = acceptingCompany.TrainingPrefectureCd;
                    if (acceptingCompany.IpNotificationNo == null)
                    {
                        acceptingCompanyViewModel.IpNotificationNo = null;
                    }
                    else
                    {
                        acceptingCompanyViewModel.IpNotificationNo = acceptingCompany.IpNotificationNo.Trim();
                    }
                    acceptingCompanyViewModel.IpNotificationDate = acceptingCompany.IpNotificationDate;
                    if (acceptingCompany.CompanyMember == null)
                    {
                        acceptingCompanyViewModel.CompanyMember = null;
                    }
                    else
                    {
                        acceptingCompanyViewModel.CompanyMember = acceptingCompany.CompanyMember.Trim();
                    }
                    if (acceptingCompany.LabourInsuranceNum == null)
                    {
                        acceptingCompanyViewModel.LabourInsuranceNum = null;
                    }
                    else
                    {
                        acceptingCompanyViewModel.LabourInsuranceNum = acceptingCompany.LabourInsuranceNum.Trim();
                    }
                    if (acceptingCompany.EmploymentInsuranceNum == null)
                    {
                        acceptingCompanyViewModel.EmploymentInsuranceNum = null;
                    }
                    else
                    {
                        acceptingCompanyViewModel.EmploymentInsuranceNum = acceptingCompany.EmploymentInsuranceNum.Trim();
                    }
                    acceptingCompanyViewModel.AreaName = acceptingCompany.Area.AreaName.Trim();
                    acceptingCompanyViewModel.PerfectureName = acceptingCompany.Perfecture.PerfectureName.Trim();
                    acceptingCompanyViewModel.PerfectureCode = acceptingCompany.Perfecture.PerfectureCode;
                    acceptingCompanyViewModel.IsDeleteAcceptCom = acceptingCompany.IsDeleteAcceptCom;
                }
                acceptingCompanyViewModel.accepCompanies = db.AcceptingCompanies.ToList();
            }
            return View(acceptingCompanyViewModel);

        }

        public IActionResult SaveData(DbModels.AcceptingCompany formacceptingCompany)
        {
            using (GCommunicationContext db = new GCommunicationContext())
            {
                if(formacceptingCompany.AcceptingCompanyId == 0)
                {
                    db.AcceptingCompanies.Add(formacceptingCompany);
                }
                else
                {
                    DbModels.AcceptingCompany dbacceptingCompany = db.AcceptingCompanies.Where(w => w.AcceptingCompanyId == formacceptingCompany.AcceptingCompanyId).FirstOrDefault();
                    dbacceptingCompany.AcceptingCompanyId = formacceptingCompany.AcceptingCompanyId;
                    dbacceptingCompany.AcceptingCompanyCode = formacceptingCompany.AcceptingCompanyCode;
                    dbacceptingCompany.AcceptiingCompanyName = formacceptingCompany.AcceptiingCompanyName;
                    dbacceptingCompany.HiraganaName = formacceptingCompany.HiraganaName;
                    dbacceptingCompany.EnglishName = formacceptingCompany.EnglishName;
                    dbacceptingCompany.AreaId = formacceptingCompany.AreaId;
                    dbacceptingCompany.PerfectureId = formacceptingCompany.PerfectureId;
                    dbacceptingCompany.Zip = formacceptingCompany.Zip;
                    dbacceptingCompany.Address1 = formacceptingCompany.Address1;
                    dbacceptingCompany.Address2 = formacceptingCompany.Address2;
                    dbacceptingCompany.TelephoneNo = formacceptingCompany.TelephoneNo;
                    dbacceptingCompany.Fax = formacceptingCompany.Fax;
                    dbacceptingCompany.CheifExecutiveOfficer = formacceptingCompany.CheifExecutiveOfficer;
                    dbacceptingCompany.Member = formacceptingCompany.Member;
                    dbacceptingCompany.CapitalStock = formacceptingCompany.CapitalStock;
                    dbacceptingCompany.Business = formacceptingCompany.Business;
                    dbacceptingCompany.Charge = formacceptingCompany.Charge;
                    dbacceptingCompany.InsertDate = formacceptingCompany.InsertDate;
                    dbacceptingCompany.UpdateDate = formacceptingCompany.UpdateDate;
                    dbacceptingCompany.TrainingZip = formacceptingCompany.TrainingZip;
                    dbacceptingCompany.TrainingAdress1 = formacceptingCompany.TrainingAdress1;
                    dbacceptingCompany.TrainingAdress2 = formacceptingCompany.TrainingAdress2;
                    dbacceptingCompany.TrainingTel = formacceptingCompany.TrainingTel;
                    dbacceptingCompany.TrainingFax = formacceptingCompany.TrainingFax;
                    dbacceptingCompany.Memo1 = formacceptingCompany.Memo1;
                    dbacceptingCompany.TrainingPrefectureCd = formacceptingCompany.TrainingPrefectureCd;
                    dbacceptingCompany.IpNotificationNo = formacceptingCompany.IpNotificationNo;
                    dbacceptingCompany.IpNotificationDate = formacceptingCompany.IpNotificationDate;
                    dbacceptingCompany.CompanyMember = formacceptingCompany.CompanyMember;
                    dbacceptingCompany.LabourInsuranceNum = formacceptingCompany.LabourInsuranceNum;
                    dbacceptingCompany.EmploymentInsuranceNum = formacceptingCompany.EmploymentInsuranceNum;
                    dbacceptingCompany.IsDeleteAcceptCom = formacceptingCompany.IsDeleteAcceptCom;
                }
                db.SaveChanges();
            }
            return Redirect("/AcceptingCompany/AcceptingCompany/Index");
        }

        public IActionResult DetailView(int Id)
        {
            AcceptingCompanyViewModel acceptingCompanyViewModel = new AcceptingCompanyViewModel();
            
            using (GCommunicationContext db = new GCommunicationContext())
            {
                acceptingCompanyViewModel.AcceptingCompany = db.AcceptingCompanies.Where(w => w.AcceptingCompanyId == Id).FirstOrDefault();

                acceptingCompanyViewModel.accepArea = db.AcceptingCompanies.Where(w => w.AcceptingCompanyId == Id).Join(db.Area,
                    acceptingCompany => acceptingCompany.AreaId,
                    area => area.AreaId,
                    (acceptingCompany, area) => new { AcceptingCompany = acceptingCompany, Area = area }).Select(s => s.Area).ToList();

                acceptingCompanyViewModel.accepPerfectures = db.AcceptingCompanies.Where(w => w.AcceptingCompanyId == Id).Join(db.Perfectures,
                    acceptingCompany => acceptingCompany.PerfectureId,
                    perfecture => perfecture.PerfectureId,
                    (acceptingCompany, perfecture) => new { AcceptingCompany = acceptingCompany, Perfecture = perfecture }).Select(s => s.Perfecture).ToList();

                acceptingCompanyViewModel.accepTrainee = db.AcceptingCompanies.Where(w => w.AcceptingCompanyId == Id).Join(db.TraineeMasters,
                   acceptingCompany => acceptingCompany.AcceptingCompanyId,
                   traineeMaster => traineeMaster.AcceptingCompanyId,
                   (acceptingCompany, traineeMaster) => new { AcceptingCompany = acceptingCompany, TraineeMaster = traineeMaster }).Select(s => s.TraineeMaster).ToList();

            }
            return View(acceptingCompanyViewModel);
        }

        public IActionResult IsDelete(int Id)
        {
            try
            {
                using (GCommunicationContext db = new GCommunicationContext())
                {
                    DbModels.AcceptingCompany acceptingCompany = db.AcceptingCompanies.Where(w => w.AcceptingCompanyId == Id).First();
                    acceptingCompany.IsDeleteAcceptCom = true;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }
            return Redirect("/AcceptingCompany/AcceptingCompany/Index");
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

        //Perfecture List View
        public IActionResult PerfectureListView()
        {
            List<Perfecture> perfectures = new List<Perfecture>();
            using (GCommunicationContext db = new GCommunicationContext())
            {
                perfectures = db.Perfectures.Where(w => w.IsDeletePerfecture == false).ToList();
            }
            return View(perfectures);
        }

        public IActionResult TraineePerfectureListView()
        {
            List<Perfecture> perfectures = new List<Perfecture>();
            using (GCommunicationContext db = new GCommunicationContext())
            {
                perfectures = db.Perfectures.Where(w => w.IsDeletePerfecture == false).ToList();
            }
            return View(perfectures);
        }


        public string getLastAcceptingCode()
        {
            string AcceptingCode = "";
            string id = "";
            string lastCode = "";
            using (GCommunicationContext db = new GCommunicationContext())
            {

                AcceptingCode = db.AcceptingCompanies.Where(w => w.IsDeleteAcceptCom == false).Max(item => item.AcceptingCompanyCode);
                if (AcceptingCode != null)
                {
                    id = AcceptingCode.Trim();
                    //string[] words = id.Split('T');
                    int Number = int.Parse(id);
                    string nextCode = (Number + 1).ToString();

                    lastCode = nextCode.ToString().PadLeft(6, '0');
                }
                else
                {
                    return AcceptingCode = "000001";
                }
            }
            return lastCode;
        }

    }
}
