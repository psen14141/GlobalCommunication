using GloableCommunication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using GloableCommunication.Areas.Trainee.Models.ViewModel;
using GloableCommunication.DbModels;
using GloableCommunication.Models.ViewModels;

namespace GloableCommunication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            ViewBag.TotTrainers = getTotalTrainners();
            ViewBag.TotSendingCompany = getTotalSendingCompany();
            ViewBag.TotHostCompany = getTotalHostCompany();
            ViewBag.TotVisaRemainingDays = getVisaRemainingDays(); 



            List<HomeViewModel> homeViewModels = new List<HomeViewModel>();
            using (GCommunicationContext db = new GCommunicationContext())
            {
                
                var countryTrainee = db.Countries.Where(w => w.IsDeleteCountry == false).Join
                    (db.TraineeMasters,
                        country => country.CountryId,
                        traineeMaster => traineeMaster.CountryId,
                        (country, traineeMaster) => new { Country = country, TraineeMaster = traineeMaster }
                    );

               
            foreach (var item in db.Countries.Where(w => w.IsDeleteCountry == false))
                {
                    FilteredCount filteredCount = new FilteredCount();

                    HomeViewModel homeViewModel = new HomeViewModel();

                    homeViewModel.Training1 = filteredCount.GetPositionStatusCount(item.CountryId, "2");
                    homeViewModel.Training2 = filteredCount.GetPositionStatusCount(item.CountryId, "3");
                    homeViewModel.Training3 = filteredCount.GetPositionStatusCount(item.CountryId, "5"); 
                    homeViewModel.SpecificSkill1 = filteredCount.GetPositionStatusCount(item.CountryId, "6");
                    homeViewModel.SpecificSkill2 = filteredCount.GetPositionStatusCount(item.CountryId, "7");
                    homeViewModel.SpecificSkillTotal = homeViewModel.SpecificSkill1 + homeViewModel.SpecificSkill2;
                    homeViewModel.DuringResidence = filteredCount.GetEntranceStatusCount(item.CountryId, "1");
                    homeViewModel.ReturnHome = filteredCount.GetEntranceStatusCount(item.CountryId, "2");
                    homeViewModel.ReturnJapan = filteredCount.GetEntranceStatusCount(item.CountryId, "3");
                    homeViewModel.Disappearance = filteredCount.GetEntranceStatusCount(item.CountryId, "4");
                    homeViewModel.UnionTransfer = filteredCount.GetEntranceStatusCount(item.CountryId, "5");
                    homeViewModel.Death = filteredCount.GetEntranceStatusCount(item.CountryId, "6");
                    homeViewModel.TrainingTotal = homeViewModel.Training1 + homeViewModel.Training2 + homeViewModel.Training3;
                    homeViewModel.AllPersons = filteredCount.GetCountryCount(item.CountryId, null);
                    homeViewModel.CountryId = item.CountryId;
                    homeViewModel.CountryName = item.CountryName;
                    homeViewModels.Add(homeViewModel);
                }


            }


            homeViewModels = homeViewModels.ToList();
            return View(homeViewModels);

        }

        public class FilteredCount
        {
            public int GetCountryCount(int Id, String str)
            {
                int Count = 0;

                List<TraineeMaster>traineeMaster = new List<TraineeMaster>();

                using (GCommunicationContext db = new GCommunicationContext())
                {
                    traineeMaster = db.TraineeMasters.Where(w => w.CountryId == Id).Where(w => w.DeleteFlg == false).ToList();
                    foreach (var item in traineeMaster)
                    {
                       


                        if ((item.CountryId == Id)&&(str== null))
                        {
                            Count++;
                        }


                    }


                }

                return (Count);
            }



            public int GetEntranceStatusCount(int Id, String str)
            {
                int Count = 0;

                List<TraineeMaster> traineeMaster = new List<TraineeMaster>();

                using (GCommunicationContext db = new GCommunicationContext())
                {
                    traineeMaster = db.TraineeMasters.Where(w => w.CountryId == Id).Where(w => w.DeleteFlg == false).ToList();
                    foreach (var item in traineeMaster)
                    {
                        

                        if (item.EntranceStatus != null)
                        {

                            if ((item.EntranceStatus.Trim() == str) && (str != null))
                            {
                                Count++;
                            }
                        }




                    }


                }

                return (Count);
            }





            public int GetPositionStatusCount(int Id, String str)
            {
                int Count = 0;

                List<TraineeMaster> traineeMaster = new List<TraineeMaster>();

                using (GCommunicationContext db = new GCommunicationContext())
                {
                    traineeMaster = db.TraineeMasters.Where(w => w.CountryId == Id).Where(w => w.DeleteFlg == false).ToList();
                    foreach (var item in traineeMaster)
                    {
                        if (item.PositionStatus != null)
                        {
                            string inputString = item.PositionStatus.Trim();

                            if ((item.PositionStatus.Trim() == str) && (str != null))
                            {
                                Count++;
                            }
                        }



                    }


                }

                return (Count);
            }





        }
        public int getVisaRemainingDays()
        {
           int flag = 0;
           var days  = 0;
           var today = DateTime.Today;
           
             

             using (GCommunicationContext db = new GCommunicationContext())
             { 
             

              List<TraineeHistory> traineeHistory = db.TraineeHistories.ToList();
                 foreach (var item in traineeHistory)
                {
                    if (item.PassportLimit != null)
                    {
                        var appDay = (DateTime)item.PassportLimit;
                        days = (int)appDay.Subtract(today).TotalDays;
                        if (days < 30) { flag = 1; }
                        else if ((days < 90) && flag != 1) { flag = 2; }
                        else if ((days >= 90) && (flag != 1) && (flag != 2)) { flag = 3; }
                    }


                 }

                
             }
            
            return flag;
        }



        public int getTotalTrainners() {
            int count = 0;
            using (GCommunicationContext db = new GCommunicationContext())
            {
                count = db.TraineeMasters.Count();

            }
            return count;
        }
        public int getTotalSendingCompany()
        {
            int count = 0;
            using (GCommunicationContext db = new GCommunicationContext())
            {
                count = db.SendingCompanies.Count();

            }
            return count;
        }
        public int getTotalHostCompany()
        {
            int count = 0;
            using (GCommunicationContext db = new GCommunicationContext())
            {
                count = db.AcceptingCompanies.Count();

            }
            return count;
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
 
    }
}
