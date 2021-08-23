using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GloableCommunication.DbModels;
using GloableCommunication.Areas.Occupations.Model.ViewModels;

namespace GloableCommunication.Areas.Occupations.Controllers
{
    [Area("Occupations")]
    public class OccupationController : Controller
    {
        public IActionResult Index()
        {
            List<OccupationViewModel> occupationViewModels = new List<OccupationViewModel>();
            List<DbModels.Occupation> occupations = new List<DbModels.Occupation>();
            using (GCommunicationContext db = new GCommunicationContext())
            {

                occupations = db.Occupations.Where(w => w.IsDeleteOccupation == false).ToList();
                foreach (var item in occupations)
                {
                    OccupationViewModel occupationViewModel = new OccupationViewModel();
                    occupationViewModel.OccupationId = item.OccupationId;
                    occupationViewModel.OccupationCode = item.OccupationCode;
                    occupationViewModel.OccupationName = item.OccupationName;
                    occupationViewModel.InsertDateTime = item.InsertDateTime;
                    occupationViewModel.createdate = item.InsertDateTime.ToString("yyyy/MM/dd");
                    if (item.UpdateDateTime != null)
                    {
                        DateTime up = (DateTime)item.UpdateDateTime;
                        occupationViewModel.updatedate = up.ToString("yyyy/MM/dd");
                    }

                    if(item.TraineeYearFlag!= null)
                    {
                        occupationViewModel.TraineeYearFlag = (long)item.TraineeYearFlag;
                    }
                    else
                    {
                        occupationViewModel.TraineeYearFlag = 0;
                    }

                    occupationViewModel.IsDeleteOccupation = item.IsDeleteOccupation;
                    occupationViewModels.Add(occupationViewModel);
                }
                occupationViewModels = occupationViewModels.ToList();
            }
            return View(occupationViewModels);

        }
        public IActionResult AddorEditView(int Id = 0)
        {
            OccupationViewModel occupationViewModel = new OccupationViewModel();
            int CodeMax = 0;
            using (GCommunicationContext db = new GCommunicationContext())
            {
                if (Id != 0)
                {
                    Occupation occupation = db.Occupations.Where(w => w.IsDeleteOccupation == false)
                        .Where(x => x.OccupationId == Id).FirstOrDefault();

                    occupationViewModel.OccupationId = occupation.OccupationId;
                    occupationViewModel.OccupationCode = occupation.OccupationCode;
                    occupationViewModel.OccupationName = occupation.OccupationName.Trim();
                    occupationViewModel.InsertDateTime = occupation.InsertDateTime;
                    occupationViewModel.UpdateDateTime = DateTime.Now;
                    occupationViewModel.TraineeYearFlag = (long)occupation.TraineeYearFlag;
                    occupationViewModel.IsDeleteOccupation = occupation.IsDeleteOccupation;
                }
                else
                {
                    occupationViewModel.occupations = db.Occupations.Where(W => W.IsDeleteOccupation == false).ToList();       
                    CodeMax = db.Occupations.Max(M => M.OccupationCode) + 1;
                    occupationViewModel.OccupationCode = CodeMax;
                }
                occupationViewModel.occupations = db.Occupations.Where(w => w.IsDeleteOccupation == false).ToList();
            }
            return View(occupationViewModel);
        }

        public IActionResult SaveData(DbModels.Occupation occupation)
        {

            using (GCommunicationContext db = new GCommunicationContext())
            {
                if (occupation.OccupationId == 0)
                {
                    occupation.InsertDateTime = DateTime.Now;
                    db.Occupations.Add(occupation);
                }
                else
                {
                    DbModels.Occupation dbOccupation = db.Occupations.Where(w => w.OccupationId == occupation.OccupationId).FirstOrDefault();
                    dbOccupation.OccupationId = occupation.OccupationId;
                    dbOccupation.OccupationCode = occupation.OccupationCode;
                    dbOccupation.OccupationName = occupation.OccupationName;
                    dbOccupation.UpdateDateTime = DateTime.Now;
                    dbOccupation.TraineeYearFlag = (long)occupation.TraineeYearFlag;
                    dbOccupation.IsDeleteOccupation = occupation.IsDeleteOccupation;
                }
                db.SaveChanges();
            }
            return Redirect("/Occupations/Occupation/Index");
        }
        public IActionResult Delete(int Id)
        {
            using (GCommunicationContext db = new GCommunicationContext())
            {
                DbModels.Occupation occupation = db.Occupations.Where(w => w.OccupationId == Id).FirstOrDefault();

                //db.SendingCompanies.Remove(sendingCompany);
                occupation.IsDeleteOccupation = true;
                db.SaveChanges();

            }
            return Redirect("/Occupations/Occupation/Index");
        }
    }
}

