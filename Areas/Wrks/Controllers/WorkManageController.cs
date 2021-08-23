using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GloableCommunication.DbModels;
using GloableCommunication.Areas.Wrks.Models.ViewModels;

namespace GloableCommunication.Areas.Wrks.Controllers
{

    [Area("Wrks")]
    public class WorkManageController : Controller
    {
        public IActionResult Index()
        {
            //List<Work> worklist = new List<Work>();
            List<WorksViewModel> wrkViewModels = new List<WorksViewModel>();
            using (GCommunicationContext db = new GCommunicationContext())
            {


                var workselectiony = db.Works.Where( w => w.IsDeleteWork == false).Join
                    (db.Occupations,
                        wrkl => wrkl.OccupationId,
                        occu => occu.OccupationId,
                        (wrkl, occu) => new { Work = wrkl, Occupation = occu }
                    );
                foreach (var item in workselectiony)
                {
                    //Work work = new Work();
                    WorksViewModel workViewModel = new WorksViewModel();
                    workViewModel.WorkId = item.Work.WorkId;
                    workViewModel.WorkName = item.Work.WorkName;
                    workViewModel.OccupationId = item.Occupation.OccupationId;
                    workViewModel.OccupationName = item.Occupation.OccupationName;
                    workViewModel.VerifcationName = item.Work.VerifcationName;
                    wrkViewModels.Add(workViewModel);
                }
                wrkViewModels = wrkViewModels.Where(w => w.IsDeleteWork == false).ToList();


            }


            return View(wrkViewModels);
        }

        public IActionResult AddView(int Id = 0)
        {

         WorksViewModel worksViewModel = new WorksViewModel();
            using (GCommunicationContext db = new GCommunicationContext())
            {


                if (Id != 0)
                {

                    Work work = db.Works.Where(w => w.WorkId == Id).FirstOrDefault();

                    worksViewModel.WorkId = work.WorkId;
                    worksViewModel.WorkName = work.WorkName;
                    worksViewModel.VerifcationName = work.VerifcationName;
                    worksViewModel.OccupationId = work.OccupationId;
                    
                
                }
                worksViewModel.occupations = db.Occupations.Where(w => w.IsDeleteOccupation == false).ToList();
                worksViewModel.InsertDateTime = DateTime.Now;
            }
        
            return View(worksViewModel);

        }


        public IActionResult SaveNewData(Work working)
        {
            using (GCommunicationContext db = new GCommunicationContext())
            {
                if (working.WorkId == 0)
                {
                    working.InsertDateTime = DateTime.Now;
                    db.Works.Add(working);
                }
                else
                {
                    Work dbwork = db.Works.Where(w =>
                                    w.WorkId == working.WorkId).First();
                    dbwork.WorkId = working.WorkId;
                    dbwork.WorkName = working.WorkName;
                    dbwork.OccupationId = working.OccupationId;
                    dbwork.VerifcationName = working.VerifcationName;
                    dbwork.UpdateDateTime = DateTime.Now;

                   

                }
                db.SaveChanges();
            }
            return Redirect("/Wrks/WorkManage/Index");
        }

        public IActionResult EditView(int Id = 0)
        {

            WorksViewModel worksViewModel = new WorksViewModel();
            using (GCommunicationContext db = new GCommunicationContext())
            {


                if (Id != 0)
                {

                    Work work = db.Works.Where(w => w.WorkId == Id).FirstOrDefault();

                    worksViewModel.WorkId = work.WorkId;
                    worksViewModel.WorkName = work.WorkName;
                    worksViewModel.VerifcationName = work.VerifcationName;
                    worksViewModel.OccupationId = work.OccupationId;


                }
                worksViewModel.occupations = db.Occupations.Where(w => w.IsDeleteOccupation == false).ToList();
                worksViewModel.InsertDateTime = DateTime.Now;
            }

            return View(worksViewModel);

        }

        public IActionResult SaveEditData(Work working)
        {
            using (GCommunicationContext db = new GCommunicationContext())
            {
                if (working.WorkId == 0)
                {
                    working.InsertDateTime = DateTime.Now;
                    db.Works.Add(working);
                }
                else
                {
                    Work dbwork = db.Works.Where(w =>
                                    w.WorkId == working.WorkId).First();
                    dbwork.WorkId = working.WorkId;
                    dbwork.WorkName = working.WorkName;
                    dbwork.OccupationId = working.OccupationId;
                    dbwork.VerifcationName = working.VerifcationName;
                    dbwork.UpdateDateTime = DateTime.Now;



                }
                db.SaveChanges();
            }
            return Redirect("/Wrks/WorkManage/Index");
        }

        public IActionResult Delete(int Id)
        {
            using (GCommunicationContext db = new GCommunicationContext())
            {
                Work wrking = db.Works.Where(w =>
                                        w.WorkId == Id).First();
                wrking.IsDeleteWork = true;
                db.SaveChanges();
            }
            return Redirect("/Wrks/WorkManage/Index");

        }

    }
}
