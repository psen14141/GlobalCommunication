using GloableCommunication.Areas.Trainee.Models.ViewModel;
using GloableCommunication.DbModels;


using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GloableCommunication.Models.ViewModel;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.AspNetCore.Http;

namespace GloableCommunication.Controllers
{

    //---------------------Controller 1  -----------Start----



    public class IndexWarningController : Controller
    {
        public class IndexWarningData
        {
            GCommunicationContext db = null;
            IDbContextTransaction transaction = null;
            HttpContext context;
            public IndexWarningData(HttpContext context_)
            {
                context = context_;
                db = new GCommunicationContext();
            }

            ~IndexWarningData()
            {
                removeObject();
            }

            private void removeObject()
            {
                if (db != null)
                {
                    db.Dispose();
                    db = null;
                }
                if (transaction != null)
                {
                    transaction.Dispose();
                    transaction = null;
                }
            }
            public void ExtentPassLimitDays(int id)
            {
                try
                {
                    transaction = db.Database.BeginTransaction();

                    if (id != 0)
                    {
                        TraineeHistory dbtraineeHistory = db.TraineeHistories.Where(w => w.TraineeId == id).FirstOrDefault();
                        TraineeHistory traineeHistory = new TraineeHistory();

                        DateTime d1 = (DateTime)dbtraineeHistory.PassportLimit;
                        dbtraineeHistory.PassportLimit = (DateTime?)d1.AddMonths(6);

                        db.SaveChanges();
                        transaction.Commit();
                    }
                }

                catch (Exception e)
                {
                    Console.Write("Error info:" + e.Message);
                    transaction.Rollback();
                }
                finally
                {
                    removeObject();
                }
            }
        }
        public IActionResult Index()
        {
            List<WarningViewModel> warningViewModels = new List<WarningViewModel>();
            using (GCommunicationContext db = new GCommunicationContext())
            {

                //List<TraineeMaster> trainee = db.TraineeMasters.ToList();
                var tranning = db.TraineeHistories.Join
                    (db.TraineeMasters,
                    trhistory => trhistory.TraineeId,
                    trmaster => trmaster.TraineeId,
                    (trhistory, trmaster) => new { TraineeHistory = trhistory, TraineeMaster = trmaster }
                    );

                var tranning2 = tranning.Join
                    (db.SendingCompanies,
                    trmaster => trmaster.TraineeMaster.SendingCompanyId,
                    sendingCompanies => sendingCompanies.SendingCompanyId,
                    (trmaster, sendingCompanies) => new { TraineeMaster = trmaster, SendingCompany = sendingCompanies }
                    );


                foreach (var item in tranning2)
                {

                    if (item.TraineeMaster.TraineeHistory.PassportLimit != null)
                    {
                        WarningViewModel warningViewModel = new WarningViewModel();
                        FilteredData filteredData = new FilteredData();
                        warningViewModel.TraineeId = item.TraineeMaster.TraineeMaster.TraineeId;
                        warningViewModel.TraineeName = item.TraineeMaster.TraineeMaster.TraineeName;

                        //string stayLimit = item.TraineeMaster.TraineeHistory.PassportLimit.ToString();
                        //DateTime passDate = Convert.ToDateTime(stayLimit);
                        //warningViewModel.RemainingDays = filteredData.GetRemaingingDays(passDate);
                        int rimdays = filteredData.GetRemaingingDays((DateTime)item.TraineeMaster.TraineeHistory.PassportLimit);
                        warningViewModel.RemainingDays = rimdays;

                        warningViewModel.SendingName = item.SendingCompany.SendingName;
                        warningViewModel.Schlarship = item.TraineeMaster.TraineeMaster.Schlarship;
                      var PassportLimit = (DateTime)item.TraineeMaster.TraineeHistory.PassportLimit;

                        warningViewModel.PassportLimit= PassportLimit.ToString("dd/MM/yyyy");








                        if (warningViewModel.RemainingDays <= 90)
                        {
                            if(warningViewModel.RemainingDays < 0)
                            {
                                warningViewModel.Status = "期限が切れている !!!";

                            }
                            else if(warningViewModel.RemainingDays == 0) { warningViewModel.Status = "今日期限切れ !!!"; } else
                            {
                                warningViewModel.Status = "残り" + rimdays.ToString() + "日ある";

                            }
                            warningViewModels.Add(warningViewModel);
                        }
                    }


                }
                warningViewModels = warningViewModels.ToList();

            }
            return View(warningViewModels);


        }

       
        public class FilteredData
        {
            public int GetRemaingingDays(DateTime date)
            {
                using (GCommunicationContext db = new GCommunicationContext())
                {
                    var today = DateTime.Today; //like DateTime.Now but with no time aspect
                    var appDay = date.Date;
                    return (int)appDay.Subtract(today).TotalDays;



                   
                }

            }

        }

        


        public IActionResult EditTraineeHistory(int id)
        {
            // it has come
            IndexWarningData indexWarningData = new IndexWarningData(Request.HttpContext);
            indexWarningData.ExtentPassLimitDays(id);
            return Redirect("/IndexWarning");

        }

    }
    //------------------Controller 1----------End-----










    //-----------controller 2 ------------Start------

    //public class IndexWarningController : Controller
    //{
    //    List<TraineeMaster> traineeMaster = new List<TraineeMaster>();
    //    List<TraineeHistory> traineeHistory = new List<TraineeHistory>();
    //    List<SendingCompany> sendingCompany = new List<SendingCompany>();

    //    public ActionResult Index()
    //    {

    //        var warningViewModel = from tm in traineeMaster
    //                               join th in traineeHistory on tm.TraineeId equals th.TraineeId
    //                               join sc in sendingCompany on tm.SendingCompanyId equals sc.SendingCompanyId

    //                               select new WarningViewModel
    //                               {
    //                                   traineeMastervm = tm,
    //                                   traineeHistoryvm = th,
    //                                   sendingCompanyvm = sc
    //                               };

    //        return View(warningViewModel);


    //    }
    //}


    //----------------------controller 2 ---------------------End---



}





