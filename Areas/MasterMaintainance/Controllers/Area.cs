using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GloableCommunication.DbModels;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Internal;
using GloableCommunication.Areas.MasterMaintainance.Models.ViewModels;

namespace GloableCommunication.Areas.MasterMaintainance.Controllers
{
    [Area("MasterMaintainance")]
    public class AreaController : Controller
    {
        public IActionResult Index(int Id)
        {
            List<AreaViewModel> areaViewModels = new List<AreaViewModel>();
            using (GCommunicationContext db = new GCommunicationContext())
            {
                var classAreaCountry = db.Area.Join(
                    db.Countries,
                        areas => areas.CountryId,
                        country => country.CountryId,
                        
                        (areas, country) => new { Area = areas, Country = country }
                    );

                foreach (var item in classAreaCountry)
                {
                    AreaViewModel areacountryViewModel = new AreaViewModel();
                    areacountryViewModel.AreaId = item.Area.AreaId;
                    areacountryViewModel.AreaCode = item.Area.AreaCode;
                    areacountryViewModel.AreaName = item.Area.AreaName;
                    areacountryViewModel.InsertDateTime = item.Area.InsertDateTime;
                    areacountryViewModel.UpdateDateTime = item.Area.UpdateDateTime;
                    areacountryViewModel.CountryId = item.Area.CountryId;
                    areacountryViewModel.CountryName = item.Country.CountryName;
                    areacountryViewModel.IsDeleteArea = item.Area.IsDeleteArea;
                    areaViewModels.Add(areacountryViewModel);
                }
                if(Id == 0)
                {
                    areaViewModels = areaViewModels.Where(w => w.IsDeleteArea == false).ToList();
                }
                else
                {
                    areaViewModels = areaViewModels.Where(w => w.IsDeleteArea == false && w.CountryId == Id).ToList();
                }
            }
            return View(areaViewModels);
        }

        public IActionResult AddView(int Id = 0)
        {
            AreaViewModel areaViewModel = new AreaViewModel();
            int AreaCodeMax = 0;
            using (GCommunicationContext db = new GCommunicationContext())
            {
                if (Id != 0)
                {
                    var classAreaCountry = db.Area.Join(
                    db.Countries,
                        areas => areas.CountryId,
                        country => country.CountryId,

                        (areas, country) => new { Area = areas, Country = country }
                    );

                    Area area = db.Area.Where(w => w.AreaId == Id).First();
                    areaViewModel.AreaId = area.AreaId;
                    areaViewModel.AreaCode = area.AreaCode;
                    areaViewModel.AreaName = area.AreaName;
                    areaViewModel.InsertDateTime = area.InsertDateTime;
                    areaViewModel.UpdateDateTime = area.UpdateDateTime;
                    areaViewModel.CountryId = area.CountryId;
                    areaViewModel.IsDeleteArea = area.IsDeleteArea;
                }
                else
                {
                    areaViewModel.Areas = db.Area.Where(W => W.IsDeleteArea == false).ToList();

                    List<CodeList> AreacodeLists = new List<CodeList>();

                    AreaCodeMax = db.Area.Max(M => M.AreaCode) + 1;

                    //string areaCode = AreaCodeMax.PadLeft(6, '0');

                    areaViewModel.AreaCode = AreaCodeMax;

                }
                areaViewModel.Countries = db.Countries.ToList();
            }
            return View(areaViewModel);
        }

        public IActionResult DetailView(int Id)
        {
            AreaViewModel areaViewModel = new AreaViewModel();
            using (GCommunicationContext db = new GCommunicationContext())
            {
                areaViewModel.Area = db.Area.Where(w => w.AreaId == Id).FirstOrDefault();

                areaViewModel.Countries = db.Area.Where(w => w.AreaId == Id).Join(db.Countries,
                            area => area.CountryId,
                            country => country.CountryId,
                            (area, country) => new { Area = area, Country = country })
                        .Select(s => s.Country).ToList();
            }
            return View(areaViewModel);
        }

        public ActionResult SaveChanges(Area formarea)
        {
            using (GCommunicationContext db = new GCommunicationContext())
            {
                if (formarea.AreaId == 0)
                {
                    db.Area.Add(formarea);
                }
                else
                {
                    Area dbArea = db.Area.Where(w => w.AreaId == formarea.AreaId).FirstOrDefault();
                    dbArea.AreaId = formarea.AreaId;
                    dbArea.CountryId = formarea.CountryId;
                    dbArea.AreaCode = formarea.AreaCode;
                    dbArea.AreaName = formarea.AreaName;
                    dbArea.InsertDateTime = formarea.InsertDateTime;
                    dbArea.UpdateDateTime = formarea.UpdateDateTime;
                    dbArea.IsDeleteArea = formarea.IsDeleteArea;
                }
                db.SaveChanges();
            }
            return Redirect("/MasterMaintainance/Area/Index");
        }
        public IActionResult IsDelete(int Id)
        {
            try
            {
                using (GCommunicationContext db = new GCommunicationContext())
                {
                    Area area = db.Area.Where(w => w.AreaId == Id).FirstOrDefault();
                    area.IsDeleteArea = true;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }
            
            return Redirect("/MasterMaintainance/Area/Index");
        }
    }
}
