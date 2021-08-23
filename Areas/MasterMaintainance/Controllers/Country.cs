using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GloableCommunication.DbModels;
using GloableCommunication.Areas.MasterMaintainance.Models.ViewModels;

namespace GloableCommunication.Areas.MasterMaintainance.Controllers
{

    [Area("MasterMaintainance")]
    public class Country : Controller
    {
        //Documents View
        public IActionResult Index()
        {

            List<GloableCommunication.DbModels.Country> country = new List<GloableCommunication.DbModels.Country>();
            using (GCommunicationContext db = new GCommunicationContext())
            {
                country = db.Countries.Where(w => w.IsDeleteCountry == false).ToList();
            }


            return View(country);
        }

        public IActionResult AddorEditView(int Id )
        {
            CountryViewModel countryViewModel = new CountryViewModel();
            int CountryCodeMax = 0;
            using (GCommunicationContext db = new GCommunicationContext())
            {
                if (Id != 0)
                {
                    GloableCommunication.DbModels.Country country = db.Countries.Where(w => w.CountryId == Id).First();

                    countryViewModel.CountryId = country.CountryId;
                    countryViewModel.CountryCode = country.CountryCode;
                    countryViewModel.CountryName = country.CountryName;
                    countryViewModel.InsertDateTime = country.InsertDateTime;
                    countryViewModel.UpdateDateTime = country.UpdateDateTime;
                    countryViewModel.CountryId = country.CountryId;



                }
                else
                {
                        countryViewModel.Countries = db.Countries.Where(W => W.IsDeleteCountry == false).ToList();
                        List<CodeListCountry> AreacodeLists = new List<CodeListCountry>();
                        CountryCodeMax = db.Countries.Max(M => M.CountryCode) + 1;
                        countryViewModel.CountryCode = CountryCodeMax;


                    countryViewModel.InsertDateTime = DateTime.Now;
                    countryViewModel.UpdateDateTime = DateTime.Now;
                }
                countryViewModel.Countries = db.Countries.ToList();
              
            }
            return View(countryViewModel);
        }
        public ActionResult SaveChanges(DbModels.Country formcountry)
        {
            using (GCommunicationContext db = new GCommunicationContext())
            {
                if (formcountry.CountryId == 0)
                {
                    formcountry.InsertDateTime = DateTime.Today;
                    formcountry.IsDeleteCountry = false;
                    db.Countries.Add(formcountry);

                }
                else
                {
                    DbModels.Country dbCountry = db.Countries.Where(w => w.CountryId == formcountry.CountryId).FirstOrDefault();
                    dbCountry.CountryId = formcountry.CountryId;
                    dbCountry.CountryCode = formcountry.CountryCode;
                    dbCountry.CountryName = formcountry.CountryName.Trim();
                    dbCountry.UpdateDateTime = DateTime.Today;

                }
                db.SaveChanges();
            }
            return Redirect("/MasterMaintainance/Country/Index");
        }



        public IActionResult Delete(int Id)
        {
            using (GCommunicationContext db = new GCommunicationContext())
            {
                DbModels.Country country = db.Countries.Where(w => w.CountryId == Id).First();
                country.IsDeleteCountry = true;
                db.SaveChanges();
                return Redirect("/MasterMaintainance/Country/Index");
            }
        }
        public IActionResult DetailView(int Id)
        {

            CountryViewModel countryViewModel = new CountryViewModel();
            using (GCommunicationContext db = new GCommunicationContext())

            {

                GloableCommunication.DbModels.Country country = db.Countries.Where(w => w.CountryId == Id).First();
                countryViewModel.CountryCode = country.CountryCode;
                countryViewModel.CountryName = country.CountryName;
                countryViewModel.UpdateDateTime = country.UpdateDateTime;


            }
            return View(countryViewModel);
        }
    }
}
