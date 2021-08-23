using GloableCommunication.Areas.MasterMaintainance.Models.ViewModels;
using GloableCommunication.DbModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GloableCommunication.Areas.MasterMaintainance.Controllers
{
    [Area("MasterMaintainance")]
    public class Prefecture : Controller
    {
        public IActionResult Index()
        {
            List<PrefectureViewModel> prefectureViewModels = new List<PrefectureViewModel>();
            using (GCommunicationContext db = new GCommunicationContext())
            {
                var classPrefectureArea = db.Perfectures.Where(w => w.IsDeletePerfecture == false).Join(
                    db.Area,

                         prefecture => prefecture.AreaId,
                         areas => areas.AreaId,


                        (prefecture, areas) => new { Prefecture = prefecture, Area = areas }
                    );

                foreach (var item in classPrefectureArea)
                {
                    PrefectureViewModel prefectureareaViewModel = new PrefectureViewModel();
                    prefectureareaViewModel.PerfectureId = item.Prefecture.PerfectureId;
                    prefectureareaViewModel.PerfectureCode = item.Prefecture.PerfectureCode;
                    prefectureareaViewModel.PerfectureName = item.Prefecture.PerfectureName;
                    prefectureareaViewModel.InsertDatetTime = item.Prefecture.InsertDatetTime;
                    prefectureareaViewModel.UpdateDateTime = item.Area.UpdateDateTime;
                    prefectureareaViewModel.AreaId = item.Prefecture.AreaId;
                    prefectureareaViewModel.AreaName = item.Area.AreaName;

                    prefectureareaViewModel.areas = db.Area.Where(w => w.IsDeleteArea == false).ToList();

                    //prefectureareaViewModel.Prefectures = db.Perfectures.Where(w => w.IsDeletePerfecture == false).ToList();

                    prefectureViewModels.Add(prefectureareaViewModel);

                }
            }
            prefectureViewModels = prefectureViewModels.ToList();
            return View(prefectureViewModels);
        }
        
        public IActionResult AddorEdit(int Id)
        {
            PrefectureViewModel prefectureViewModel = new PrefectureViewModel();
            using (GCommunicationContext db = new GCommunicationContext())
            {
                var PrefectureArea = db.Perfectures.Where(w => w.PerfectureId == Id).Join(
                          db.Area,
                          prefecture => prefecture.AreaId,
                           areas => areas.AreaId,
                           (prefecture, areas) => new { Prefecture = prefecture, Area = areas }
                      ).FirstOrDefault();


                if (Id != 0)
                {
                    DbModels.Perfecture item = db.Perfectures
                        .Where(w => w.PerfectureId == Id).First();

                    prefectureViewModel.PerfectureId = PrefectureArea.Prefecture.PerfectureId;
                    prefectureViewModel.PerfectureCode = PrefectureArea.Prefecture.PerfectureCode;
                    prefectureViewModel.PerfectureName = PrefectureArea.Prefecture.PerfectureName;
                    prefectureViewModel.InsertDatetTime = PrefectureArea.Prefecture.InsertDatetTime;
                    prefectureViewModel.UpdateDateTime = PrefectureArea.Prefecture.UpdateDateTime;
                    prefectureViewModel.AreaName = PrefectureArea.Area.AreaName;


                }

                if (Id == 0)
                {
                   
                    int maxPreCode = db.Perfectures.Where(p=>p.IsDeletePerfecture==false).Max(p => (int?)p.PerfectureCode) ?? 0;
                    prefectureViewModel.PerfectureCode = maxPreCode + 1;


                }

                prefectureViewModel.Currentdate = DateTime.Now.ToString("dd/MM/yyyy");
                prefectureViewModel.areas = db.Area.Where(w => w.IsDeleteArea == false).ToList();

            }
            return View(prefectureViewModel);
        }



        public IActionResult Detail(int Id)
        {
            PrefectureViewModel prefectureViewModel = new PrefectureViewModel();
            using (GCommunicationContext db = new GCommunicationContext())
            {
                var PrefectureArea = db.Perfectures.Where(w => w.PerfectureId == Id).Join(
                          db.Area,
                          prefecture => prefecture.AreaId,
                           areas => areas.AreaId,
                           (prefecture, areas) => new { Prefecture = prefecture, Area = areas }
                      ).FirstOrDefault();


                if (Id != 0)
                {
                    DbModels.Perfecture item = db.Perfectures
                        .Where(w => w.PerfectureId == Id).First();

                    prefectureViewModel.PerfectureId = PrefectureArea.Prefecture.PerfectureId;
                    prefectureViewModel.PerfectureCode = PrefectureArea.Prefecture.PerfectureCode;
                    prefectureViewModel.PerfectureName = PrefectureArea.Prefecture.PerfectureName;
                    prefectureViewModel.InsertDatetTime = PrefectureArea.Prefecture.InsertDatetTime;
                    prefectureViewModel.UpdateDateTime = PrefectureArea.Prefecture.UpdateDateTime;
                    prefectureViewModel.AreaName = PrefectureArea.Area.AreaName;
                    prefectureViewModel.AreaCode = PrefectureArea.Area.AreaCode;


                }
                prefectureViewModel.areas = db.Area.Where(w => w.IsDeleteArea == false).ToList();

            }
            return View(prefectureViewModel);






        }


        // New prefecture Save Function
        public IActionResult SaveData(DbModels.Perfecture perfecture)
        {
            using (GCommunicationContext db = new GCommunicationContext())
            {
                if (perfecture.PerfectureId == 0)
                {
                    perfecture.InsertDatetTime = DateTime.Now;
                    perfecture.IsDeletePerfecture = false;
                    db.Perfectures.Add(perfecture);
                }
                else
                {
                    DbModels.Perfecture dbperfecture = db.Perfectures.Where(w => w.PerfectureId == perfecture.PerfectureId).First();

                    //dbperfecture.PerfectureId = perfecture.PerfectureId;
                    dbperfecture.PerfectureCode = perfecture.PerfectureCode;
                    dbperfecture.PerfectureName = perfecture.PerfectureName;
                    //dbperfecture.InsertDatetTime = perfecture.InsertDatetTime;
                    dbperfecture.UpdateDateTime = DateTime.Now;
                    dbperfecture.AreaId = perfecture.AreaId;



                }

                db.SaveChanges();

                return Redirect("/MasterMaintainance/Prefecture/Index");
            }



        }

        public IActionResult Delete(int Id)
        {
            using (GCommunicationContext db = new GCommunicationContext())
            {
                DbModels.Perfecture prefecture = db.Perfectures.Where(w => w.PerfectureId == Id).First();
                prefecture.IsDeletePerfecture = true;
                //db.Branch.Remove(branch);
                db.SaveChanges();
                return Redirect("/MasterMaintainance/Prefecture/Index");


            }




        }
    }
}
