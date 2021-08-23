using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GloableCommunication.Areas.Trainee.Models.ViewModel;
using GloableCommunication.Areas.Trainee.Models.RequestModel;
using GloableCommunication.DbModels;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using GloableCommunication.ProPlatform.FileManager;
using System.Globalization;
using System.Text;
using System.Data;
using System.IO;

namespace GloableCommunication.Areas.Trainee.Controllers
{

    [Area("Trainee")]
    public class TraineeMasterController : Controller
    {
        public IActionResult Index(TraineeMasterViewModel postData)
        {
            TraineeMasterViewModel traineeMasterViewModel = new TraineeMasterViewModel();
            List<TraineeEntryDate> traineeEntryDates = new List<TraineeEntryDate>();
            List<TraineeMasterViewModel> traineeMasterViewModels = new List<TraineeMasterViewModel>();
            FilteredData filteredData = new FilteredData();

            using (GCommunicationContext db = new GCommunicationContext())
            {
                traineeMasterViewModel.FromDate = DateTime.Now;
                traineeMasterViewModel.ToDate = DateTime.Now;

                traineeMasterViewModel.TraineeM = db.TraineeMasters.Where(w => w.IsDelete == false).OrderByDescending(x=> x.TraineeId).ToList();
                traineeMasterViewModel.Acceptings = db.AcceptingCompanies.Where(w => w.IsDeleteAcceptCom == false).ToList();
                traineeMasterViewModel.Sendings = db.SendingCompanies.Where(w => w.IsDeleteSendingCompany == false).ToList();
                traineeMasterViewModel.OccupationLists = db.Occupations.Where(w => w.IsDeleteOccupation == false).ToList();
                traineeMasterViewModel.WorkList = db.Works.Where(w => w.IsDeleteWork == false).ToList();

                foreach (var item in db.TraineeMasters)
                {
                    TraineeEntryDate traineeEntryDate = new TraineeEntryDate();

                    string str = item.EntranceDate.ToString("yyyy/MM/dd");
                    traineeEntryDate.TraineeId = item.TraineeId;
                    traineeEntryDate.EntranceDateStr = str;
                    traineeEntryDate.entrancestatus = filteredData.GetEntranceStatus(item.EntranceStatus);
                    traineeEntryDate.positionstatus = filteredData.GetEntranceStatus(item.PositionStatus);
                    traineeEntryDate.sexflagstr = filteredData.GetSexFlag(item.SexFlag);
                    traineeEntryDates.Add(traineeEntryDate);
                }
                traineeMasterViewModel.traineeEntryDates = traineeEntryDates.ToList();
            }
            return View(traineeMasterViewModel);
        }
        public string getLastTraineeNumber() {
            string trainnerId = "";
            string id = "";
            string lastNumber = "";
            using (GCommunicationContext db = new GCommunicationContext())
            {
     
                    trainnerId = db.TraineeMasters.Where(w => w.IsDelete == false).Max(item => item.TraineeNo);
                    if (trainnerId != null) {
                        id = trainnerId.Trim();
                        string[] words = id.Split('T');
                        int Number = int.Parse(words[1]);
                        string nexttrainnerId = (Number + 1).ToString();

                    lastNumber = "T" + nexttrainnerId.ToString().PadLeft(5, '0'); 

                    }else{
                        return trainnerId = "T00001";
                    }
            }
            return lastNumber;
        }
        public IActionResult GetFilteredData(FilterOption postData)
        {
            List<TraineeMaster> traineeMasters = new List<TraineeMaster>();
            List<TraineeMasterViewModel> traineeMasterViewModels = new List<TraineeMasterViewModel>();

            FilteredData filteredData = new FilteredData();
            using (GCommunicationContext db = new GCommunicationContext())
            {
                if(postData.isdelete == false)
                {
                    traineeMasters = db.TraineeMasters.Where(w => w.DeleteFlg == false).ToList();
                }
                else if(postData.isdelete == true)
                {
                    traineeMasters = db.TraineeMasters.ToList();
                }
                if (postData.countryid != 0)
                {
                    traineeMasters = traineeMasters.Where(w => w.CountryId == postData.countryid).ToList();
                }
                if(postData.perfectureid != 0)
                {
                    traineeMasters = filteredData.FilterByPerfecture(postData.perfectureid, traineeMasters).ToList();
                }
                if (postData.acceptingcompanyid != 0)
                {
                    traineeMasters = traineeMasters.Where(w => w.AcceptingCompanyId == postData.acceptingcompanyid).ToList();
                }
                if (postData.occupationid != 0)
                {
                    traineeMasters = traineeMasters.Where(w => w.OccupationId == postData.occupationid).ToList();
                }
                if (postData.sendingCompanyid != 0)
                {
                    traineeMasters = traineeMasters.Where(w => w.SendingCompanyId == postData.sendingCompanyid).ToList();
                }
                if (postData.traineename != null)
                {
                    traineeMasters = filteredData.FilterByName(postData.traineename, traineeMasters).ToList();
                }

                DateTime sentDate = new DateTime(1,1,0001).Date;
                if (postData.returnoption > 0 && postData.fromdate.Date != sentDate && postData.todate.Date != sentDate)
                {
                    traineeMasters = filteredData.FilterByEntry(postData.returnoption, postData.fromdate, postData.todate, traineeMasters).ToList();
                }
                if(postData.graduationflag != null)
                {
                    traineeMasters = traineeMasters.Where(w => w.GraduationFlg == postData.graduationflag).ToList();
                }

                if(postData.entrystatusdeath != null || 
                    postData.entrystatusdisappear != null || 
                    postData.entrystatusdone != null || 
                    postData.entrystatusjapan != null || 
                    postData.entrystatusplan != null || 
                    postData.entrystatusreturn != null || 
                    postData.entrystatusuniontransfer != null)
                {
                    traineeMasters = filteredData.FilterByEntryStatus(postData, traineeMasters).ToList();
                }

                if (postData.positionstatusintern != null ||
                    postData.positionstatusactivity_2 != null ||
                    postData.positionstatusactivity_3 != null ||
                    postData.positionstatusskill_1 != null ||
                    postData.positionstatuskkill_2 != null ||
                    postData.positionstatustraining_1 != null ||
                    postData.positionstatustraining_2 != null ||
                    postData.positionstatustraining_3 != null)
                {
                    traineeMasters = filteredData.FilterByPositionStatus(postData, traineeMasters).ToList();
                }

                if (postData.oldsystem == "1" && postData.newsystem == null)
                {
                    traineeMasters = traineeMasters.Where(w => w.NewOldSystem.Trim() == postData.oldsystem.Trim()).ToList();

                }

                if (postData.newsystem == "0" && postData.oldsystem == null)
                {
                    traineeMasters = traineeMasters.Where(w => w.NewOldSystem.Trim() == postData.newsystem.Trim()).ToList();

                }
                if (postData.newsystem == null && postData.oldsystem == null)
                {
                    traineeMasters = traineeMasters.Where(w => w.NewOldSystem == null).ToList();

                }
                if(postData.traineecode != null)
                {
                    traineeMasters = traineeMasters.Where(w => w.TraineeNo.Trim() == postData.traineecode.Trim()).ToList();
                }

                foreach (var item in traineeMasters)
                {
                    TraineeMasterViewModel traineeMasterViewModel = new TraineeMasterViewModel();
                    traineeMasterViewModel.Acceptings = db.AcceptingCompanies
                        .Where(w=> w.AcceptingCompanyId == item.AcceptingCompanyId).Where(w=> w.IsDeleteAcceptCom ==false).ToList();
                    traineeMasterViewModel.OccupationLists = db.Occupations.
                        Where(w => w.OccupationId == item.OccupationId).Where(w => w.IsDeleteOccupation == false).ToList();
                    traineeMasterViewModel.Sendings = db.SendingCompanies.
                        Where(w => w.SendingCompanyId == item.SendingCompanyId).Where(w => w.IsDeleteSendingCompany == false).ToList();
                    traineeMasterViewModel.WorkList = db.Works.
                        Where(w => w.WorkId == item.WorkId).Where(w => w.IsDeleteWork == false).ToList();

                    traineeMasterViewModel.CountryId = item.CountryId;
                    traineeMasterViewModel.EntranceDate = item.EntranceDate;
                    traineeMasterViewModel.TraineeName = item.TraineeName;
                    traineeMasterViewModel.TraineeNo = item.TraineeNo.Trim();
                    traineeMasterViewModel.KatakanaName = item.KatakanaName;
                    traineeMasterViewModel.SexFlag = item.SexFlag;
                    traineeMasterViewModel.sexflagstr = filteredData.GetSexFlag(item.SexFlag);
                    traineeMasterViewModel.WorkId = item.WorkId;
                    traineeMasterViewModel.OccupationId = item.OccupationId;
                    traineeMasterViewModel.GraduationFlg = item.GraduationFlg;
                    traineeMasterViewModel.NewOldSystem = item.NewOldSystem;
                    traineeMasterViewModel.AcceptingCompanyId = item.AcceptingCompanyId;
                    traineeMasterViewModel.SendingCompanyId = item.SendingCompanyId;
                    traineeMasterViewModel.TraineeId = item.TraineeId;
                    traineeMasterViewModel.ReturnDate = item.ReturnDate;
                    traineeMasterViewModel.IsDelete = item.IsDelete;

                    if (item.EntranceStatus != null)
                    {
                        traineeMasterViewModel.EntranceStatus = item.EntranceStatus.Trim();
                        traineeMasterViewModel.entrancestatus = filteredData.GetEntranceStatus(item.EntranceStatus);
                    }
                    if(item.PositionStatus != null)
                    {
                        traineeMasterViewModel.PositionStatus = item.PositionStatus.Trim();
                        traineeMasterViewModel.positionstatus = filteredData.GetPostionStatus(item.PositionStatus);
                    }
                    traineeMasterViewModel.EntranceDateStr = item.EntranceDate.ToString("yyyy/MM/dd");

                    traineeMasterViewModels.Add(traineeMasterViewModel);
                }

            }
            traineeMasterViewModels = traineeMasterViewModels.ToList();
            switch (postData.issorting)
            {
                case false:
                    traineeMasterViewModels = traineeMasterViewModels.OrderBy(s => s.TraineeNo.Trim()).ToList();
                    return View(traineeMasterViewModels);
                case true:
                    traineeMasterViewModels = traineeMasterViewModels.OrderBy(s => s.EntranceDateStr.Trim()).ToList();
                    return View(traineeMasterViewModels);
            }
        }
        public class FilteredData
        {
            public List<TraineeMaster> FilterByPerfecture(int Id, List<TraineeMaster> traineeMasters)
            {
                List<TraineeMaster> filteredTrinees = new List<TraineeMaster>();
                using (GCommunicationContext db = new GCommunicationContext())
                {

                    var traineePerfecture = traineeMasters.Join(
                        db.AcceptingCompanies.Where(w => w.PerfectureId == Id),
                        traineeMaster => traineeMaster.AcceptingCompanyId,
                        acceptingCompany => acceptingCompany.AcceptingCompanyId,
                        (traineeMaster, acceptingCompany) => new { TraineeMaster = traineeMaster, AcceptingCompany = acceptingCompany }
                        );

                    foreach (var item in traineePerfecture)
                    {
                        TraineeMaster traineeMaster = new TraineeMaster();

                        traineeMaster.CountryId = item.TraineeMaster.CountryId;
                        traineeMaster.EntranceDate = item.TraineeMaster.EntranceDate;
                        traineeMaster.TraineeName = item.TraineeMaster.TraineeName;
                        traineeMaster.TraineeNo = item.TraineeMaster.TraineeNo.Trim();
                        traineeMaster.KatakanaName = item.TraineeMaster.KatakanaName;
                        traineeMaster.SexFlag = item.TraineeMaster.SexFlag;
                        traineeMaster.WorkId = item.TraineeMaster.WorkId;
                        traineeMaster.GraduationFlg = item.TraineeMaster.GraduationFlg;
                        traineeMaster.NewOldSystem = item.TraineeMaster.NewOldSystem;
                        traineeMaster.AcceptingCompanyId = item.TraineeMaster.AcceptingCompanyId;
                        traineeMaster.OccupationId = item.TraineeMaster.OccupationId;
                        traineeMaster.SendingCompanyId = item.TraineeMaster.SendingCompanyId;
                        traineeMaster.TraineeId = item.TraineeMaster.TraineeId;
                        traineeMaster.EntranceStatus = item.TraineeMaster.EntranceStatus;
                        traineeMaster.PositionStatus = item.TraineeMaster.PositionStatus.Trim();
                        traineeMaster.ReturnDate = item.TraineeMaster.ReturnDate;
                        traineeMaster.IsDelete = item.TraineeMaster.IsDelete;


                        filteredTrinees.Add(traineeMaster);
                    }
                }
                return (filteredTrinees);
            }


            public List<TraineeMaster> FilterByName(string trianeeName, List<TraineeMaster> traineeMasters)
            {
                List<TraineeMaster> filteredTrinees = new List<TraineeMaster>();

                string inputName = trianeeName.ToLower();
                var str = inputName.Trim();
                string inputTrimmed = String.Concat(inputName.Where(c => !Char.IsWhiteSpace(c)));
                str = Regex.Replace(str, @"\s+", " ");
                string[] inputNameArray = str.Split(" ");
                bool isHave = false;

                foreach (var item in traineeMasters)
                {
                    string dbName = item.TraineeName.ToLower().Trim();
                    string dbTrimmed = String.Concat(dbName.Where(c => !Char.IsWhiteSpace(c)));
                    var dbStr = Regex.Replace(dbName, @"\s+", " ");
                    string[] dbNameArray = dbStr.Split(" ");

                    if (inputTrimmed == dbTrimmed)
                    {
                        isHave = true;
                        GetTraineeMaster getTraineeMaster = new GetTraineeMaster();
                        filteredTrinees.Add(getTraineeMaster.GetDbData(item));
                    }
                }
                if (isHave == false)
                {
                    foreach (var item in traineeMasters)
                    {
                        string dbName = item.TraineeName.ToLower().Trim();
                        string dbTrimmed = String.Concat(dbName.Where(c => !Char.IsWhiteSpace(c)));
                        var dbStr = Regex.Replace(dbName, @"\s+", " ");
                        string[] dbNameArray = dbStr.Split(" ");

                        GetTraineeMaster getTraineeMaster = new GetTraineeMaster();
                        bool isCompared = getTraineeMaster.CompareStringData(inputNameArray, dbNameArray);
                        if (isCompared == true)
                        {
                            filteredTrinees.Add(getTraineeMaster.GetDbData(item));
                        }

                    }
                }
                
                filteredTrinees = filteredTrinees.ToList();
                return (filteredTrinees);
            }
            public List<TraineeMaster> FilterByEntry(int Id, DateTime stratDate, DateTime endDate, List<TraineeMaster> traineeMasters)
            {
                List<TraineeMaster> filteredTrinees = new List<TraineeMaster>();
                foreach (var item in traineeMasters)
                {
                    switch (Id)
                    {
                        case 1:
                            int fromEntry = DateTime.Compare(stratDate.Date, item.EntranceDate.Date);
                            int toEntry = DateTime.Compare(endDate.Date, item.EntranceDate.Date);

                            if ((fromEntry <= 0) && (toEntry >= 0))
                            {
                                GetTraineeMaster getTraineeMaster = new GetTraineeMaster();
                                filteredTrinees.Add(getTraineeMaster.GetDbData(item));
                            }
                            break;
                        case 2:
                            if(item.ReturnDate == null)
                            {
                                continue;
                            }
                            else
                            {
                                string returnStr = item.ReturnDate.ToString();
                                DateTime returnDate = Convert.ToDateTime(returnStr);

                                int fromReturn = DateTime.Compare(stratDate.Date, returnDate.Date);
                                int toReturn = DateTime.Compare(endDate.Date, returnDate.Date);

                                if ((fromReturn <= 0) && (toReturn >= 0))
                                {
                                    GetTraineeMaster getTraineeMaster = new GetTraineeMaster();
                                    filteredTrinees.Add(getTraineeMaster.GetDbData(item));
                                }
                                break;
                            }
                        case 3:
                            if (item.PracticalTrainingFrom3 == null)
                            {
                                continue;
                            }
                            else
                            {
                                string trainingStr = item.PracticalTrainingFrom3.ToString();
                                DateTime trainingDate = Convert.ToDateTime(trainingStr);

                                int fromTraining = DateTime.Compare(stratDate.Date, trainingDate.Date);
                                int toTraining = DateTime.Compare(endDate.Date, trainingDate.Date);
                                if ((fromTraining <= 0) && (toTraining >= 0))
                                {
                                    GetTraineeMaster getTraineeMaster = new GetTraineeMaster();
                                    filteredTrinees.Add(getTraineeMaster.GetDbData(item));
                                }
                                break;
                            }

                        default:
                            break;
                    }
                }
                return (filteredTrinees);
            }
            public List<TraineeMaster> FilterByEntryStatus(FilterOption filterOption, List<TraineeMaster> traineeMasters)
            {
                List<TraineeMaster> filteredTrinees = new List<TraineeMaster>();
                foreach (var item in traineeMasters)
                {
                    GetTraineeMaster getTraineeMaster = new GetTraineeMaster();                 
                    if (filterOption.entrystatusplan == item.EntranceStatus.Trim() && item.EntranceStatus != null)
                    {
                        filteredTrinees.Add(getTraineeMaster.GetDbData(item));
                    }
                    if (filterOption.entrystatusdone == item.EntranceStatus.Trim() && item.EntranceStatus != null)
                    {
                        filteredTrinees.Add(getTraineeMaster.GetDbData(item));
                    }
                    if (filterOption.entrystatusdisappear == item.EntranceStatus.Trim() && item.EntranceStatus != null)
                    {
                        filteredTrinees.Add(getTraineeMaster.GetDbData(item));
                    }
                    if (filterOption.entrystatusjapan == item.EntranceStatus.Trim() && item.EntranceStatus != null)
                    {
                        filteredTrinees.Add(getTraineeMaster.GetDbData(item));
                    }
                    if (filterOption.entrystatusreturn == item.EntranceStatus.Trim() && item.EntranceStatus != null)
                    {
                        filteredTrinees.Add(getTraineeMaster.GetDbData(item));
                    }
                    if (filterOption.entrystatusdeath == item.EntranceStatus.Trim() && item.EntranceStatus != null)
                    {
                        filteredTrinees.Add(getTraineeMaster.GetDbData(item));
                    }
                    if (filterOption.entrystatusuniontransfer == item.EntranceStatus.Trim() && item.EntranceStatus != null)
                    {
                        filteredTrinees.Add(getTraineeMaster.GetDbData(item));
                    }                   
                }
                return (filteredTrinees);
            }

            public List<TraineeMaster> FilterByPositionStatus(FilterOption filterOption, List<TraineeMaster> traineeMasters)
            {
                List<TraineeMaster> filteredTrinees = new List<TraineeMaster>();
                foreach (var item in traineeMasters)
                {
                    GetTraineeMaster getTraineeMaster = new GetTraineeMaster();
                    if (filterOption.positionstatusintern == item.PositionStatus.Trim())
                    {
                        filteredTrinees.Add(getTraineeMaster.GetDbData(item));
                    }
                    if (filterOption.positionstatusactivity_2 == item.PositionStatus.Trim())
                    {
                        filteredTrinees.Add(getTraineeMaster.GetDbData(item));
                    }
                    if (filterOption.positionstatusactivity_3 == item.PositionStatus.Trim())
                    {
                        filteredTrinees.Add(getTraineeMaster.GetDbData(item));
                    }
                    if (filterOption.positionstatusskill_1 == item.PositionStatus.Trim())
                    {
                        filteredTrinees.Add(getTraineeMaster.GetDbData(item));
                    }
                    if (filterOption.positionstatuskkill_2 == item.PositionStatus.Trim())
                    {
                        filteredTrinees.Add(getTraineeMaster.GetDbData(item));
                    }
                    if (filterOption.positionstatustraining_1 == item.PositionStatus.Trim())
                    {
                        filteredTrinees.Add(getTraineeMaster.GetDbData(item));
                    }
                    if (filterOption.positionstatustraining_2 == item.PositionStatus.Trim())
                    {
                        filteredTrinees.Add(getTraineeMaster.GetDbData(item));
                    }
                    if (filterOption.positionstatustraining_3 == item.PositionStatus.Trim())
                    {
                        filteredTrinees.Add(getTraineeMaster.GetDbData(item));
                    }
                }
                return (filteredTrinees);
            }

            public string GetSexFlag(string sexflagdata)
            {
                string sexFlagKanji = null;
                if (sexflagdata != null)
                {
                    switch (sexflagdata.Trim())
                    {
                        case "0":
                            sexFlagKanji = "男";
                            break;
                        case "1":
                            sexFlagKanji = "女";
                            break;
                    }
                }
                return sexFlagKanji;
            }

            public string GetEntranceStatus(string entranceStatusNo)
            {
                string entranceStatusStr = null;
                if (entranceStatusNo != null)
                {
                    switch (entranceStatusNo)
                    {
                        case "0":
                            entranceStatusStr = "予定";
                            break;
                        case "1":
                            entranceStatusStr = "済み";
                            break;
                        case "2":
                            entranceStatusStr = "帰国";
                            break;
                        case "3":
                            entranceStatusStr = "述中帰国";
                            break;
                        case "4":
                            entranceStatusStr = "失踪";
                            break;
                        case "5":
                            entranceStatusStr = "組合移籍";
                            break;
                        case "6":
                            entranceStatusStr = "死亡";
                            break;
                    }
                }
                return entranceStatusStr;
            }

            public string GetPostionStatus(string postionStatusNo)
            {
                string postionStatusStr = null;
                if (postionStatusNo != null)
                {
                    switch (postionStatusNo)
                    {
                        case "0":
                            postionStatusStr = "研修生";
                            break;
                        case "1":
                            postionStatusStr = "特定活動2年";
                            break;
                        case "2":
                            postionStatusStr = "実習1号";
                            break;
                        case "3":
                            postionStatusStr = "実習2号";
                            break;
                        case "4":
                            postionStatusStr = "特定活動3年";
                            break;
                        case "5":
                            postionStatusStr = "実習3号";
                            break;
                        case "6":
                            postionStatusStr = "特定技能1";
                            break;
                        case "7":
                            postionStatusStr = "特定技能2";
                            break;
                    }
                }
                return postionStatusStr;
            }
        }
        public class GetTraineeMaster
        {
            public TraineeMaster GetDbData(TraineeMaster traineeMaster)
            {
                TraineeMaster filteredTrainee = new TraineeMaster();

                filteredTrainee.CountryId = traineeMaster.CountryId;
                filteredTrainee.EntranceDate = traineeMaster.EntranceDate;
                filteredTrainee.TraineeName = traineeMaster.TraineeName.Trim();
                filteredTrainee.TraineeNo = traineeMaster.TraineeNo;
                filteredTrainee.KatakanaName = traineeMaster.KatakanaName;
                filteredTrainee.SexFlag = traineeMaster.SexFlag;
                filteredTrainee.WorkId = traineeMaster.WorkId;
                filteredTrainee.GraduationFlg = traineeMaster.GraduationFlg;
                filteredTrainee.NewOldSystem = traineeMaster.NewOldSystem;
                filteredTrainee.AcceptingCompanyId = traineeMaster.AcceptingCompanyId;
                filteredTrainee.OccupationId = traineeMaster.OccupationId;
                filteredTrainee.SendingCompanyId = traineeMaster.SendingCompanyId;
                filteredTrainee.TraineeId = traineeMaster.TraineeId;
                filteredTrainee.EntranceStatus = traineeMaster.EntranceStatus;
                filteredTrainee.PositionStatus = traineeMaster.PositionStatus;
                filteredTrainee.Immigrationstatus = traineeMaster.Immigrationstatus;
                filteredTrainee.ReturnDate = traineeMaster.ReturnDate;
                traineeMaster.IsDelete = traineeMaster.IsDelete;

                return (filteredTrainee);
            }
            public bool CompareStringData(string[] inputName, string[] dbName)
            {
                bool compared = false;
                foreach (var name in inputName)
                {
                    int dbNameLength = dbName.Length;
                    for (int i=0; i < dbNameLength; i++)
                    {
                        if(dbName[i] == name)
                        {
                            compared = true;
                        }
                    }
                }
                return (compared);

            }
    }

        public IActionResult IndexAll()
        {
            List<TraineeMaster> trainee = new List<TraineeMaster>();
            List<TraineeMasterViewModel> TrMasterViewModels = new List<TraineeMasterViewModel>();

            using (GCommunicationContext db = new GCommunicationContext())
            {
               

                var accptc = db.TraineeMasters.Join
                    (db.AcceptingCompanies,
                    trainm => trainm.AcceptingCompanyId,
                    accptc => accptc.AcceptingCompanyId,
                    (trainm, accptc) => new { TraineeMaster = trainm, AcceptingCompany = accptc }
                    );
                var sendcom = accptc.Join
                     (db.SendingCompanies,
                     trnm =>trnm.TraineeMaster.SendingCompanyId,
                     sendc => sendc.SendingCompanyId,
                     (trnm, sendc) => new {TraineeMaster = trnm, SendingCompany =sendc}
                    );

                var occtrain = sendcom.Join
                    (db.Occupations,
                    trma => trma.TraineeMaster.TraineeMaster.OccupationId,
                    occu => occu.OccupationId,
                    (trma, occu) => new { TraineeMaster = trma, Occupation = occu }
                    );

                foreach (var item in occtrain)
                {
                    TraineeMasterViewModel trainmester = new TraineeMasterViewModel();
                    trainmester.TraineeId = item.TraineeMaster.TraineeMaster.TraineeMaster.TraineeId;
                    trainmester.TraineeNo = item.TraineeMaster.TraineeMaster.TraineeMaster.TraineeNo;
                    trainmester.TraineeName = item.TraineeMaster.TraineeMaster.TraineeMaster.TraineeName;
                    trainmester.KatakanaName = item.TraineeMaster.TraineeMaster.TraineeMaster.KatakanaName;
                    trainmester.AcceptingCompanyId = item.TraineeMaster.TraineeMaster.AcceptingCompany.AcceptingCompanyId;
                    trainmester.AcceptiingCompanyName = item.TraineeMaster.TraineeMaster.AcceptingCompany.AcceptiingCompanyName;
                    trainmester.SendingCompanyId = item.TraineeMaster.SendingCompany.SendingCompanyId;
                    trainmester.SendingName = item.TraineeMaster.SendingCompany.SendingName;
                    trainmester.OccupationId = item.Occupation.OccupationId;
                    trainmester.OccupationName = item.Occupation.OccupationName;
                    trainmester.EntranceDate = item.TraineeMaster.TraineeMaster.TraineeMaster.EntranceDate;
                    trainmester.EntranceStatus = item.TraineeMaster.TraineeMaster.TraineeMaster.EntranceStatus;
                    trainmester.PositionStatus = item.TraineeMaster.TraineeMaster.TraineeMaster.PositionStatus;
                    //trainmester.RentFlg = item.TraineeMaster.TraineeMaster.TraineeMaster.RentFlg;
                    //trainmester.SexFlag = item.TraineeMaster.TraineeMaster.TraineeMaster.SexFlag;
                    //trainmester.EntryDate = item.TraineeMaster.TraineeMaster.TraineeMaster.EntryDate;
                    TrMasterViewModels.Add(trainmester);

                }

            }
            return View(TrMasterViewModels);
        }
        public IActionResult TranningEngineerList()
        {

            List<TraineeMaster> tm = new List<TraineeMaster>();
            using (GCommunicationContext db = new GCommunicationContext())
            {
                tm = db.TraineeMasters.ToList();
            }


            return View(tm);
        }


        public string  replace(string str){

            string pattern = "\\s+";
            string replacement = "";
            string result = "";
            Regex rx = new Regex(pattern);
            if (str == null)
            {
                result =  " ";
            }
            else {
                result = rx.Replace(str, replacement);

            }
            return result;
        }
        public class DynamicObject
        {
            public dynamic Instance = new System.Dynamic.ExpandoObject();

            public void AddProperty(string name, object value)
            {
                ((IDictionary<string, object>)this.Instance).Add(name, value);
            }

            public dynamic GetProperty(string name)
            {
                if (((IDictionary<string, object>)this.Instance).ContainsKey(name))
                    return ((IDictionary<string, object>)this.Instance)[name];
                else
                    return null;
            }

            public void AddMethod(Action methodBody, string methodName)
            {
                this.AddProperty(methodName, methodBody);
            }
        }

        public IActionResult  GetAcceptingCompanies()
        {
            //List<string> accept = new List<string>();


            List<AcceptingCompany> customlist = new List<AcceptingCompany>();

            using (GCommunicationContext db = new GCommunicationContext())
            {
                List<GloableCommunication.DbModels.AcceptingCompany> acceptingCompanies = new List<GloableCommunication.DbModels.AcceptingCompany>();

                acceptingCompanies = db.AcceptingCompanies.ToList();

                foreach (var item in acceptingCompanies)
                {
                    var ac = new AcceptingCompany();
                    ac.AcompanyName = item.AcceptiingCompanyName.Trim();
                    ac.ACompanyId = item.AcceptingCompanyId;
                    customlist.Add(ac);
                }

            }


            return Json(customlist);


        }

        
        [HttpPost]
        public string GetTraineerData([FromBody]  RequestData data)
        {
            string objjsonData =null;
            int accepComId = 0;
            if (data.tblHeaders.Count() == 0) {

                return JsonConvert.SerializeObject("NoselectedDropDown");

            }

            List<DynamicObject> customlist = new List<DynamicObject>();

            using (GCommunicationContext db = new GCommunicationContext())
            {
                List<TraineeMaster> trainee = db.TraineeMasters.ToList();

                if (data.sRadioBtn != 1) {               
              
                    try
                    {
                        accepComId = int.Parse(data.accepCompany);
                        GloableCommunication.DbModels.AcceptingCompany accept = db.AcceptingCompanies.Where(w => w.AcceptingCompanyId == accepComId).First();

                        trainee = db.TraineeMasters.Where(w => w.AcceptingCompanyId == accept.AcceptingCompanyId).ToList();
                    }
                    catch (System.FormatException e)
                    {
                          
                           return JsonConvert.SerializeObject("Nodata");//data.accepCompany =""
                    }
                    catch (System.ArgumentNullException e)
                    {

                            return JsonConvert.SerializeObject("Nodata");//no data

                    }
                }


                foreach (var item in trainee)
                {
                    var SelcterdTraineerData = new DynamicObject();

                    try {
                        GloableCommunication.DbModels.TraineeHistory traineehist = db.TraineeHistories.Where(w => w.TraineeId == item.TraineeId).First();

                        for (int i = 0; i < data.tblHeaders.Count; i++)
                        {
                            if (data.tblHeaders[i] == "TraineeId")
                            {
                                SelcterdTraineerData.Instance.TraineeId = item.TraineeId;
                            }
                            else if (data.tblHeaders[i] == "TraineeName")
                            {

                                if (item.KanjiName == null)
                                {
                                    SelcterdTraineerData.Instance.TraineeName = "";
                                }
                                else
                                {
                                    SelcterdTraineerData.Instance.TraineeName = replace(item.TraineeName.Trim());
                                }
                            }
                            else if (data.tblHeaders[i] == "KanjiName")
                            {

                                if (item.KanjiName == null)
                                {
                                    SelcterdTraineerData.Instance.KanjiName = "";
                                }
                                else
                                {
                                    SelcterdTraineerData.Instance.KanjiName = replace(item.KanjiName.Trim());
                                }
                            }
                            else if (data.tblHeaders[i] == "KatakanaName")
                            {

                                if (item.KatakanaName == null)
                                {
                                    SelcterdTraineerData.Instance.KatakanaName = "";
                                }
                                else
                                {
                                    SelcterdTraineerData.Instance.KatakanaName = replace(item.KatakanaName.Trim());
                                }
                            }
                            else if (data.tblHeaders[i] == "Sex_Flag")
                            {
                                SelcterdTraineerData.Instance.Sex_Flag = replace(item.SexFlag);
                            }
                            else if (data.tblHeaders[i] == "BirthDate")
                            {
                                SelcterdTraineerData.Instance.BirthDate = item.BirthDate;
                            }
                            else if (data.tblHeaders[i] == "Immigrationstatus")
                            {
                                SelcterdTraineerData.Instance.Immigrationstatus = replace(item.Immigrationstatus);
                            }
                            else if (data.tblHeaders[i] == "entrance_date")
                            {
                                SelcterdTraineerData.Instance.entrance_date = item.EntranceDate;

                            }
                            else if (data.tblHeaders[i] == "Schlarship")
                            {


                                if (item.Schlarship == null)
                                {
                                    SelcterdTraineerData.Instance.Schlarship = "";
                                }
                                else
                                {
                                    SelcterdTraineerData.Instance.Schlarship = replace(item.Schlarship.Trim());
                                }
                            }
                            else if (data.tblHeaders[i] == "OccupationId")
                            {
                                SelcterdTraineerData.Instance.OccupationId = item.OccupationId;
                            }
                            else if (data.tblHeaders[i] == "SendingCompanyId")
                            {
                                SelcterdTraineerData.Instance.SendingCompanyId = item.SendingCompanyId;

                            }
                            else if (data.tblHeaders[i] == "CountryId")
                            {
                                GloableCommunication.DbModels.Country country = db.Countries.Where(w => w.CountryId == item.CountryId).First();


                                if (country.CountryName == null)
                                {
                                    SelcterdTraineerData.Instance.CountryId = "";
                                }
                                else
                                {
                                    SelcterdTraineerData.Instance.CountryId = replace(country.CountryName.Trim());
                                }

                            }
                            else if (data.tblHeaders[i] == "ResidentCardNo")
                            {
                                if (traineehist.ResidentCardNo == null)
                                {
                                    SelcterdTraineerData.Instance.ResidentCardNo = "";
                                }
                                else
                                {
                                    SelcterdTraineerData.Instance.ResidentCardNo = traineehist.ResidentCardNo.Trim();
                                }


                            }
                            else if (data.tblHeaders[i] == "ResidentCardExpireDate")
                            {
                                DateTime today = DateTime.Today;
                                string flag = "NO DATE";
                                if (traineehist.ResidentCardExpireDate != null)
                                {
                                    var Expiredate = traineehist.ResidentCardExpireDate.ToString();
                                    DateTime exdate = Convert.ToDateTime(Expiredate);

                                    int toEntry = DateTime.Compare(exdate.Date, today.Date);
                                    if (toEntry > 0)
                                    {
                                        flag = "VALID";

                                    }
                                    else
                                    {
                                        flag = "EXPIRE";
                                    }

                                }
                                SelcterdTraineerData.Instance.ResidentCardExpireDate = flag;

                            }

                        }
                        customlist.Add(SelcterdTraineerData);


                    } catch (Exception ex) {

                        continue;
                    
                    }
  
                }


            }


            if (customlist.Count() == 0) {
                return JsonConvert.SerializeObject("Nodata");
            }

            objjsonData = JsonConvert.SerializeObject(customlist);

            return objjsonData;
        }


    public IActionResult Gettraineer()
        {
            TraineeMasterViewModel traineeMasterViewModels = new TraineeMasterViewModel();
            using (GCommunicationContext db = new GCommunicationContext())
            {

                //List<TraineeMaster> trainee = db.TraineeMasters.ToList();
                var tranning = db.TraineeMasters.Join
                    (db.TraineeHistories,
                    trmaster => trmaster.TraineeId,
                    trhistory => trhistory.TraineeId,
                    (trmaster, trhistory) => new { TraineeMaster = trmaster, TraineeHistory = trhistory }
                    ).ToList();

                foreach (var item in tranning)
                {
                    traineeMasterViewModels.ResidentCardNo = item.TraineeHistory.ResidentCardNo;
                    traineeMasterViewModels.ResidentCardExpireDate = item.TraineeHistory.ResidentCardExpireDate;
                    traineeMasterViewModels.TraineeId = item.TraineeMaster.TraineeId;

                }
            }
            return View();
        }

        public class Trineer
        {
            public List<int> TraineerId { get; set; } = new List<int>();

            public List<string> TraineerName { get; set; } = new List<string>();
        }



        public IActionResult AddTrainee()
        {
           
            TraineeMasterViewModel traineeMasterViewModel = new TraineeMasterViewModel();

            using (GCommunicationContext db = new GCommunicationContext())
            {
                traineeMasterViewModel.BirthDate = DateTime.Now;
                traineeMasterViewModel.workListing = db.Works.ToList();


            }
            

                return View(traineeMasterViewModel);      
        }

        public IActionResult AddNewTrinee()
        {
            TraineeMasterViewModel traineeMasterViewModel = new TraineeMasterViewModel();
            using(GCommunicationContext db = new GCommunicationContext())
            {
               
                traineeMasterViewModel.workListing = db.Works.ToList();
                traineeMasterViewModel.occupationList = db.Occupations.ToList();
            }

            return View(traineeMasterViewModel);
        }

        public IActionResult EditTrainee(long Id)
        {

            TraineeMasterViewModel traineeMasterViewModel = new TraineeMasterViewModel();
       

            DownloadFile(Id);
            using (GCommunicationContext db = new GCommunicationContext())
            {

                if (Id != 0)
                {


                    var TraineeCom = db.TraineeMasters.Where(w => w.TraineeId == Id).Join
                   (db.Countries,
                       tmaster => tmaster.CountryId,
                       country => country.CountryId,
                       (tmaster, country) => new { TraineeMaster = tmaster, Country = country }
                   ).FirstOrDefault();

                    var Traineewrk = db.TraineeMasters.Where(w => w.TraineeId == Id).Join
                   (db.Works,
                       tmaster => tmaster.WorkId,
                       wrk => wrk.WorkId,
                       (tmaster, wrk) => new { TraineeMaster = tmaster, Work = wrk }
                   ).FirstOrDefault();

                    var TraineeSendingCompanies = db.TraineeMasters.Where(w => w.TraineeId == Id).Join
                  (db.SendingCompanies,
                     Tmaster => Tmaster.SendingCompanyId,
                      scom => scom.SendingCompanyId,
                      (Tmaster, scom) => new { TraineeMaster = Tmaster, SendingCompany = scom }
                      ).FirstOrDefault();

                    var TraineeAcceptCompanies = db.TraineeMasters.Where(w => w.TraineeId == Id).Join
                 (db.AcceptingCompanies,
                    Tmaster => Tmaster.AcceptingCompanyId,
                     acom => acom.AcceptingCompanyId,
                     (Tmaster, acom) => new { TraineeMaster = Tmaster, AcceptingCompany = acom }
                     ).FirstOrDefault();

                    var TraineeHisty = db.TraineeMasters.Where(w => w.TraineeId == Id).Join
                    (db.TraineeHistories,
                    Tmaster => Tmaster.TraineeId,
                     trnhistry => trnhistry.TraineeId,
                     (Tmaster, trnhistry) => new { TraineeMaster = Tmaster, TraineeHistory = trnhistry }
                     ).FirstOrDefault();




                    GloableCommunication.DbModels.TraineeMaster traineeMast = db.TraineeMasters.Where(w => w.TraineeId == Id).First();
                    traineeMasterViewModel.TraineeId = traineeMast.TraineeId;
                    traineeMasterViewModel.TraineeNo = traineeMast.TraineeNo;
                    traineeMasterViewModel.GraduationFlg = traineeMast.GraduationFlg;
                    traineeMasterViewModel.DelayedEntry = traineeMast.DelayedEntry;
                    traineeMasterViewModel.TraineeName = traineeMast.TraineeName;
                    traineeMasterViewModel.KatakanaName = traineeMast.KatakanaName;
                    traineeMasterViewModel.KanjiName = traineeMast.KanjiName;
                    if (traineeMast.SexFlag != null)
                    {
                        traineeMasterViewModel.SexFlag = traineeMast.SexFlag.Trim();
                    }
                    if (traineeMast.EntranceStatus != null)
                    {
                        traineeMasterViewModel.EntranceStatus = traineeMast.EntranceStatus.Trim();
                    }


                    traineeMasterViewModel.BirthDate = traineeMast.BirthDate;
                    traineeMasterViewModel.BirthPlace = traineeMast.BirthPlace;
                    traineeMasterViewModel.BirthdayByEra = traineeMast.BirthdayByEra;
                    traineeMasterViewModel.Age = traineeMast.Age;
                    traineeMasterViewModel.CountryId = traineeMast.CountryId;
                    if (traineeMast.Zip !=null && traineeMast.Zip !="null")
                    {
                        traineeMasterViewModel.Zip = traineeMast.Zip;
                    }
                    if (traineeMast.Address1 != null && traineeMast.Address1 != "null")
                    {
                        traineeMasterViewModel.Address1 = traineeMast.Address1;
                    }
                   
                    traineeMasterViewModel.Address2 = traineeMast.Address2;
                    if (traineeMast.TelephoneNo != null && traineeMast.TelephoneNo != "null")
                    {
                        traineeMasterViewModel.TelephoneNo = traineeMast.TelephoneNo;
                    }
                
                    if (traineeMast.Email != null && traineeMast.Email != "null")
                    {
                        traineeMasterViewModel.Email = traineeMast.Email;
                    }
                   
                    if (traineeMast.SpouseFlg != null)
                    {
                        traineeMasterViewModel.SpouseFlg = traineeMast.SpouseFlg.Trim();
                    }

                    traineeMasterViewModel.EntranceDate = traineeMast.EntranceDate;
                    traineeMasterViewModel.traineeimagestringformat = traineeMast.TraineeImage;


                    if (traineeMast.Memo1 !=null)
                    {
                        traineeMasterViewModel.Memo1 = traineeMast.Memo1.Trim();
                    }

                    if (traineeMast.Memo2 != null)
                    {
                        traineeMasterViewModel.Memo2 = traineeMast.Memo2.Trim();
                    }
                    if (traineeMast.Memo3 != null)
                    {
                        traineeMasterViewModel.Memo3 = traineeMast.Memo3.Trim();
                    }


                   
                    if (traineeMast.PositionStatus != null)
                    {
                        traineeMasterViewModel.PositionStatus = traineeMast.PositionStatus.Trim();
                    }

                    traineeMasterViewModel.AcceptingCompanyId = traineeMast.AcceptingCompanyId;

                    if (traineeMast.GroupFrom != null)
                    {
                        string dateStr322 = traineeMast.GroupFrom.ToString();
                        traineeMasterViewModel.GroupFromstr = Convert.ToDateTime(dateStr322);
                        traineeMasterViewModel.GroupFrom = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.GroupFrom = null;
                    }


                    if (traineeMast.GroupTo != null)
                    {
                        string dateStr1 = traineeMast.GroupTo.ToString();
                        traineeMasterViewModel.GroupTostr = Convert.ToDateTime(dateStr1);
                        traineeMasterViewModel.GroupTo = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.GroupTo = null;
                    }


                    if (traineeMast.PracticalTrainingFrom != null)
                    {
                        string dateStr2 = traineeMast.PracticalTrainingFrom.ToString();
                        traineeMasterViewModel.PracticalTrainingFromstr = Convert.ToDateTime(dateStr2);
                        traineeMasterViewModel.PracticalTrainingFrom = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.PracticalTrainingFrom = null;
                    }


                    if (traineeMast.PracticalTrainingTo != null)
                    {
                        string dateStr3 = traineeMast.PracticalTrainingTo.ToString();
                        traineeMasterViewModel.PracticalTrainingTostr = Convert.ToDateTime(dateStr3);
                        traineeMasterViewModel.PracticalTrainingTo = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.PracticalTrainingTo = null;
                    }

                    if (traineeMast.PracticalTrainingFrom2 != null)
                    {
                        string dateStr4 = traineeMast.PracticalTrainingFrom2.ToString();
                        traineeMasterViewModel.PracticalTrainingFrom2str = Convert.ToDateTime(dateStr4);
                        traineeMasterViewModel.PracticalTrainingFrom2 = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.PracticalTrainingFrom2 = null;
                    }

                    if (traineeMast.PracticalTrainingTo2 != null)
                    {
                        string dateStr2 = traineeMast.PracticalTrainingTo2.ToString();
                        traineeMasterViewModel.PracticalTrainingTo2str = Convert.ToDateTime(dateStr2);
                        traineeMasterViewModel.PracticalTrainingTo2 = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.PracticalTrainingTo2 = null;
                    }

                    if (traineeMast.PracticalTrainingFrom3 != null)
                    {
                        string dateStr2 = traineeMast.PracticalTrainingFrom3.ToString();
                        traineeMasterViewModel.PracticalTrainingFrom3str = Convert.ToDateTime(dateStr2);
                        traineeMasterViewModel.PracticalTrainingFrom3 = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.PracticalTrainingFrom3 = null;
                    }

                    if (traineeMast.PracticalTrainingTo3 != null)
                    {
                        string dateStr2 = traineeMast.PracticalTrainingTo3.ToString();
                        traineeMasterViewModel.PracticalTrainingTo3str = Convert.ToDateTime(dateStr2);
                        traineeMasterViewModel.PracticalTrainingTo3 = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.PracticalTrainingTo3 = null;
                    }

                    if (traineeMast.TechnicalFrom != null)
                    {
                        string dateStr2 = traineeMast.TechnicalFrom.ToString();
                        traineeMasterViewModel.TechnicalFromstr = Convert.ToDateTime(dateStr2);
                        traineeMasterViewModel.TechnicalFrom = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.TechnicalFrom = null;
                    }

                    if (traineeMast.TechnicalTo != null)
                    {
                        string dateStr2 = traineeMast.TechnicalTo.ToString();
                        traineeMasterViewModel.TechnicalTostr = Convert.ToDateTime(dateStr2);
                        traineeMasterViewModel.TechnicalTo = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.TechnicalTo = null;
                    }


                    if (traineeMast.SpecificActivityFrom != null)
                    {
                        string dateStr2 = traineeMast.SpecificActivityFrom.ToString();
                        traineeMasterViewModel.SpecificActivityFromstr = Convert.ToDateTime(dateStr2);
                        traineeMasterViewModel.SpecificActivityFrom = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.SpecificActivityFrom = null;
                    }


                    if (traineeMast.Specificskillstart1 != null)
                    {
                        string dateStr2 = traineeMast.Specificskillstart1.ToString();
                        traineeMasterViewModel.Specificskillstart1str = Convert.ToDateTime(dateStr2);
                        traineeMasterViewModel.Specificskillstart1 = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.Specificskillstart1 = null;
                    }

                    if (traineeMast.Specificskillstart2 != null)
                    {
                        string dateStr2 = traineeMast.Specificskillstart2.ToString();
                        traineeMasterViewModel.Specificskillstart2str = Convert.ToDateTime(dateStr2);
                        traineeMasterViewModel.Specificskillstart2 = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.Specificskillstart2 = null;
                    }

                    if (traineeMast.SpecificskillRhome1 != null)
                    {
                        string dateStr2 = traineeMast.SpecificskillRhome1.ToString();
                        traineeMasterViewModel.SpecificskillRhome1str = Convert.ToDateTime(dateStr2);
                        traineeMasterViewModel.SpecificskillRhome1 = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.SpecificskillRhome1 = null;
                    }

                    if (traineeMast.SpecificskillRhome2 != null)
                    {
                        string dateStr2 = traineeMast.SpecificskillRhome2.ToString();
                        traineeMasterViewModel.SpecificskillRhome2str = Convert.ToDateTime(dateStr2);
                        traineeMasterViewModel.SpecificskillRhome2 = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.SpecificskillRhome2 = null;
                    }

                    traineeMasterViewModel.SendingCompanyId = traineeMast.SendingCompanyId;
                    traineeMasterViewModel.WorkId = traineeMast.WorkId;

                    if (traineeMast.EntryDate != null)
                    {
                        string dateStr2 = traineeMast.EntryDate.ToString();
                        traineeMasterViewModel.EntryDatestr = Convert.ToDateTime(dateStr2);
                        traineeMasterViewModel.EntryDate = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.EntryDate = null;
                    }

                    if (traineeMast.HiringDate != null)
                    {
                        string dateStr2 = traineeMast.HiringDate.ToString();
                        traineeMasterViewModel.HiringDatestr = Convert.ToDateTime(dateStr2);
                        traineeMasterViewModel.HiringDate = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.HiringDate = null;
                    }

                    if (traineeMast.SpecificNo1From != null)
                    {
                        string dateStr2 = traineeMast.SpecificNo1From.ToString();
                        traineeMasterViewModel.SpecificNo1Fromstr = Convert.ToDateTime(dateStr2);
                        traineeMasterViewModel.SpecificNo1From = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.SpecificNo1From = null;
                    }

                    if (traineeMast.SpecificNo1To != null)
                    {
                        string dateStr2 = traineeMast.SpecificNo1To.ToString();
                        traineeMasterViewModel.SpecificNo1Tostr = Convert.ToDateTime(dateStr2);
                        traineeMasterViewModel.SpecificNo1To = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.SpecificNo1To = null;
                    }

                    if (traineeMast.SpecificNo2From != null)
                    {
                        string dateStr2 = traineeMast.SpecificNo2From.ToString();
                        traineeMasterViewModel.SpecificNo2Fromstr = Convert.ToDateTime(dateStr2);
                        traineeMasterViewModel.SpecificNo2From = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.SpecificNo2From = null;
                    }

                    if (traineeMast.SpecificNo2To != null)
                    {
                        string dateStr2 = traineeMast.SpecificNo2To.ToString();
                        traineeMasterViewModel.SpecificNo2Tostr = Convert.ToDateTime(dateStr2);
                        traineeMasterViewModel.SpecificNo2To = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.SpecificNo2To = null;
                    }

                    if (traineeMast.BloodTypeFlg != null)
                    {
                        traineeMasterViewModel.BloodTypeFlg = traineeMast.BloodTypeFlg.Trim();
                    }


                    if (traineeMast.PracticalTrainingFrom2 != null)
                    {
                        string dateStr2 = traineeMast.PracticalTrainingFrom2.ToString();
                        traineeMasterViewModel.PracticalTrainingFrom2str = Convert.ToDateTime(dateStr2);
                        traineeMasterViewModel.PracticalTrainingFrom2 = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.PracticalTrainingFrom2 = null;
                    }
                    traineeMasterViewModel.Certification1No = traineeMast.Certification1No;

                    if (traineeMast.Certification1Date != null)
                    {
                        string dateStr2 = traineeMast.Certification1Date.ToString();
                        traineeMasterViewModel.Certification1Datestr = Convert.ToDateTime(dateStr2);
                        traineeMasterViewModel.Certification1Date = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.Certification1Date = null;
                    }

                    if (traineeMast.Certification1From != null)
                    {
                        string dateStr2 = traineeMast.Certification1From.ToString();
                        traineeMasterViewModel.Certification1Fromstr = Convert.ToDateTime(dateStr2);
                        traineeMasterViewModel.Certification1From = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.Certification1From = null;
                    }

                    if (traineeMast.Certification1To != null)
                    {
                        string dateStr2 = traineeMast.Certification1To.ToString();
                        traineeMasterViewModel.Certification1Tostr = Convert.ToDateTime(dateStr2);
                        traineeMasterViewModel.Certification1To = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.Certification1To = null;
                    }
                    traineeMasterViewModel.Certification2No = traineeMast.Certification2No;

                    if (traineeMast.Certification2Date != null)
                    {
                        string dateStr2 = traineeMast.Certification2Date.ToString();
                        traineeMasterViewModel.Certification2Datestr = Convert.ToDateTime(dateStr2);
                        traineeMasterViewModel.Certification2Date = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.Certification2Date = null;
                    }

                    if (traineeMast.Certification2From != null)
                    {
                        string dateStr2 = traineeMast.Certification2From.ToString();
                        traineeMasterViewModel.Certification2Fromstr = Convert.ToDateTime(dateStr2);
                        traineeMasterViewModel.Certification2From = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.Certification2From = null;
                    }

                    if (traineeMast.Certification2To != null)
                    {
                        string dateStr2 = traineeMast.Certification2To.ToString();
                        traineeMasterViewModel.Certification2Tostr = Convert.ToDateTime(dateStr2);
                        traineeMasterViewModel.Certification2To = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.Certification2To = null;
                    }
                    traineeMasterViewModel.Certification3No = traineeMast.Certification3No;

                    if (traineeMast.Certification3Date != null)
                    {
                        string dateStr2 = traineeMast.Certification3Date.ToString();
                        traineeMasterViewModel.Certification3Datestr = Convert.ToDateTime(dateStr2);
                        traineeMasterViewModel.Certification3Date = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.Certification3Date = null;
                    }

                    if (traineeMast.Certification3From != null)
                    {
                        string dateStr2 = traineeMast.Certification3From.ToString();
                        traineeMasterViewModel.Certification3Fromstr = Convert.ToDateTime(dateStr2);
                        traineeMasterViewModel.Certification3From = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.Certification3From = null;
                    }

                    if (traineeMast.Certification3To != null)
                    {
                        string dateStr2 = traineeMast.Certification3To.ToString();
                        traineeMasterViewModel.Certification3Tostr = Convert.ToDateTime(dateStr2);
                        traineeMasterViewModel.Certification3To = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.Certification3To = null;
                    }

                    if (traineeMast.NewOldSystem != null)
                    {
                        traineeMasterViewModel.NewOldSystem = traineeMast.NewOldSystem.Trim();
                    }

                    traineeMasterViewModel.Schlarship = traineeMast.Schlarship;



                    if (traineeMast.NewSystemstartDate != null)
                    {
                        string dateStr2 = traineeMast.NewSystemstartDate.ToString();
                        traineeMasterViewModel.NewSystemstartDatestr = Convert.ToDateTime(dateStr2);
                        traineeMasterViewModel.NewSystemstartDate = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.NewSystemstartDate = null;
                    }

                    if (traineeMast.Scheduledstartdateforboth != null)
                    {
                        string dateStr2 = traineeMast.Scheduledstartdateforboth.ToString();
                        traineeMasterViewModel.Scheduledstartdateforbothstr = Convert.ToDateTime(dateStr2);
                        traineeMasterViewModel.Scheduledstartdateforboth = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.Scheduledstartdateforboth = null;
                    }


                    if (traineeMast.TotalStartDate != null)
                    {
                        string dateStr2 = traineeMast.TotalStartDate.ToString();
                        traineeMasterViewModel.TotalStartDatestr = Convert.ToDateTime(dateStr2);
                        traineeMasterViewModel.TotalStartDate = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.TotalStartDate = null;
                    }


                    if (traineeMast.Returndate3 != null)
                    {
                        string dateStr2 = traineeMast.Returndate3.ToString();
                        traineeMasterViewModel.Returndate3str = Convert.ToDateTime(dateStr2);
                        traineeMasterViewModel.Returndate3 = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.SpecificNo2To = null;
                    }

                    if (traineeMast.ReturnDate != null)
                    {
                        string dateStr2 = traineeMast.ReturnDate.ToString();
                        traineeMasterViewModel.ReturnDatestr = Convert.ToDateTime(dateStr2);
                        traineeMasterViewModel.ReturnDate = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.ReturnDate = null;
                    }
                    traineeMasterViewModel.Position = traineeMast.Position;
                    traineeMasterViewModel.Testname = traineeMast.Testname;
                    if (traineeMast.Classname1 != null)
                    {
                        traineeMasterViewModel.Classname1 = traineeMast.Classname1.Trim();
                    }

                    if (traineeMast.Passdate != null)
                    {
                        string dateStr2 = traineeMast.Passdate.ToString();
                        traineeMasterViewModel.Passdatestr = Convert.ToDateTime(dateStr2);
                        traineeMasterViewModel.Passdate = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.Passdate = null;
                    }
                    if (traineeMast.Result != null)
                    {
                        traineeMasterViewModel.Result = traineeMast.Result.Trim();
                    }

                    if (traineeMast.Classname2 != null)
                    {
                        traineeMasterViewModel.Classname2 = traineeMast.Classname2.Trim();
                    }

                    if (traineeMast.Passdate2 != null)
                    {
                        string dateStr2 = traineeMast.Passdate2.ToString();
                        traineeMasterViewModel.Passdate2str = Convert.ToDateTime(dateStr2);
                        traineeMasterViewModel.Passdate2 = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.Passdate2 = null;
                    }

                    if (traineeMast.Result2 != null)
                    {
                        traineeMasterViewModel.Result2 = traineeMast.Result2.Trim();
                    }


                    if (traineeMast.ReturnPlanDate1 != null)
                    {
                        string dateStr2 = traineeMast.ReturnPlanDate1.ToString();
                        traineeMasterViewModel.ReturnPlanDate1str = Convert.ToDateTime(dateStr2);
                        traineeMasterViewModel.ReturnPlanDate1 = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.ReturnPlanDate1 = null;
                    }

                    if (traineeMast.ReturnPlanDate2 != null)
                    {
                        string dateStr2 = traineeMast.ReturnPlanDate2.ToString();
                        traineeMasterViewModel.ReturnPlanDate2str = Convert.ToDateTime(dateStr2);
                        traineeMasterViewModel.ReturnPlanDate2 = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.ReturnPlanDate2 = null;
                    }

                    GloableCommunication.DbModels.TraineeHistory traineehst = db.TraineeHistories.Where(w => w.TraineeId == Id).First();
                    traineeMasterViewModel.TraineeHistoryId = traineehst.TraineeHistoryId;
                    traineeMasterViewModel.PassportNo = traineehst.PassportNo;

                    if (traineehst.PassportLimit != null)
                    {
                        string dateStr32 = traineehst.PassportLimit.ToString();
                        traineeMasterViewModel.PassportLimitstr = Convert.ToDateTime(dateStr32);
                        traineeMasterViewModel.PassportLimit = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.PassportLimit = null;
                    }
                    if (traineehst.RegistrationNo != null)
                    {
                        traineeMasterViewModel.RegistrationNo = traineehst.RegistrationNo.Trim().ToString();
                    }
                  


                    if (traineehst.RegistrationLimit != null)
                    {
                        string dateStr32 = traineehst.RegistrationLimit.ToString();
                        traineeMasterViewModel.ResidentCardExpireDatestr = Convert.ToDateTime(dateStr32);
                        traineeMasterViewModel.RegistrationLimit = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.RegistrationLimit = null;
                    }




                    if (traineehst.PlanDate != null)
                    {
                        string dateStr32 = traineehst.PlanDate.ToString();
                        traineeMasterViewModel.PlanDatestr = Convert.ToDateTime(dateStr32);
                        traineeMasterViewModel.PlanDate = DateTime.Today;

                    }
                    else
                    {
                        traineeMasterViewModel.PlanDate = null;
                    }

                    if (traineehst.PassportImg != null)
                    {
                        traineeMasterViewModel.PassportImgstringformat = traineehst.PassportImg;
                    }
                    if (traineehst.DesactvisaImg1 != null)
                    {
                        traineeMasterViewModel.DesactvisaImg1stringformat = traineehst.DesactvisaImg1;
                    }
                    if (traineehst.LandingPermit != null)
                    {
                        traineeMasterViewModel.LandingPermitstringformat = traineehst.LandingPermit;
                    }
                    if (traineehst.LandingPermit != null)
                    {
                        traineeMasterViewModel.LandingPermitstringformat = traineehst.LandingPermit;
                    }
                    if (traineehst.DesactvisaImg2 != null)
                    {
                        traineeMasterViewModel.DesactvisaImg2stringformat = traineehst.DesactvisaImg2;
                    }
                    if (traineehst.RegistrationImg2 != null)
                    {
                        traineeMasterViewModel.RegistrationImg2stringformat = traineehst.RegistrationImg2;
                    }
                    if (traineehst.TraineevisaImg1 != null)
                    {
                        traineeMasterViewModel.TraineevisaImg1stringformat = traineehst.TraineevisaImg1;
                    }
                    if (traineehst.ResidentCard2 != null)
                    {
                        traineeMasterViewModel.ResidentCard2stringformat = traineehst.ResidentCard2;
                    }

                    if (traineehst.Residentcardyear2 != null)
                    {
                        traineeMasterViewModel.Residentcardyear2stringformat = traineehst.Residentcardyear2;
                    }
                    if (traineehst.ResidentCard2 != null)
                    {
                        traineeMasterViewModel.ResidentCard2stringformat = traineehst.ResidentCard2;
                    }
                    if (traineehst.Residentcard3 != null)
                    {
                        traineeMasterViewModel.Residentcard3stringformat = traineehst.Residentcard3;
                    }
                    if (traineehst.Residentcardyear3 != null)
                    {
                        traineeMasterViewModel.Residentcardyear3stringformat = traineehst.Residentcardyear3;
                    }
                    if (traineehst.Residentcard4 != null)
                    {
                        traineeMasterViewModel.Residentcard4stringformat = traineehst.Residentcard4;
                    }
                    if (traineehst.Residentcardyear4 != null)
                    {
                        traineeMasterViewModel.esidentcardyear4stringformat = traineehst.Residentcardyear4;
                    }
                    if (traineehst.Residentcard5 != null)
                    {
                        traineeMasterViewModel.Residentcard5stringformat = traineehst.Residentcard5;
                    }
                    if (traineehst.Residentcardyesr5 != null)
                    {
                        traineeMasterViewModel.Residentcardyesr5stringformat = traineehst.Residentcardyesr5;
                    }
                    if (traineehst.Other1 != null)
                    {
                        traineeMasterViewModel.Other1stringformat = traineehst.Other1;
                    }
                    if (traineehst.Other2 != null)
                    {
                        traineeMasterViewModel.Other2stringformat = traineehst.Other2;
                    }
                    traineeMasterViewModel.CountryCode = TraineeCom.Country.CountryCode;
                    traineeMasterViewModel.AcceptingCompanyId = TraineeAcceptCompanies.AcceptingCompany.AcceptingCompanyId;
                    traineeMasterViewModel.AcceptingCompanyCode = TraineeAcceptCompanies.AcceptingCompany.AcceptingCompanyCode;
                    traineeMasterViewModel.AcceptiingCompanyName = TraineeAcceptCompanies.AcceptingCompany.AcceptiingCompanyName;
                    traineeMasterViewModel.ZipAccptingCom = TraineeAcceptCompanies.AcceptingCompany.Zip;
                    traineeMasterViewModel.Address1AccptCom = TraineeAcceptCompanies.AcceptingCompany.Address1;
                    traineeMasterViewModel.Address2AccptCom = TraineeAcceptCompanies.AcceptingCompany.Address2;
                    traineeMasterViewModel.Business = TraineeAcceptCompanies.AcceptingCompany.Business;
                    traineeMasterViewModel.FaxAccptCom = TraineeAcceptCompanies.AcceptingCompany.Fax;
                    traineeMasterViewModel.TelephoneNoAccptCom = TraineeAcceptCompanies.AcceptingCompany.TelephoneNo;
                    traineeMasterViewModel.IpNotificationNo = TraineeAcceptCompanies.AcceptingCompany.IpNotificationNo;
                    traineeMasterViewModel.SendingName = TraineeSendingCompanies.SendingCompany.SendingName;
                    traineeMasterViewModel.SendingComapny = TraineeSendingCompanies.SendingCompany.SendingComapny;
                    traineeMasterViewModel.SendingCompanyId = TraineeSendingCompanies.SendingCompany.SendingCompanyId;
                    traineeMasterViewModel.SendingName = TraineeSendingCompanies.SendingCompany.SendingName;
                    traineeMasterViewModel.Fullname = TraineeSendingCompanies.SendingCompany.Fullname;
                    if (traineeMast.WorkId != null)
                    {
                        traineeMasterViewModel.WorkName = Traineewrk.Work.WorkName;
                    }

                    
                    traineeMasterViewModel.Generation = traineeMast.Generation;
                }

                traineeMasterViewModel.workListing = db.Works.ToList();



            }


            return View(traineeMasterViewModel);
        }


        public IActionResult TraineeImageedit(string TraineeImage)
        {
            byte[] bytes = null;
            try
            {
                bytes = System.IO.File.ReadAllBytes(TraineeImage);
            }
            catch (Exception e)
            {
                TraineeImage = "DataFolder/NoImage.jpg";
                bytes = System.IO.File.ReadAllBytes("DataFolder/NoImage.jpg");
            }

            return File(bytes, "application/octet-stream", TraineeImage);
        }



        
  public IActionResult passprtimgeedit(string passprtimg)
        {


            byte[] bytes = null;
            try
            {
                bytes = System.IO.File.ReadAllBytes(passprtimg);
            }
            catch (Exception e)
            {
                passprtimg = "DataFolder/NoImage.jpg";
                bytes = System.IO.File.ReadAllBytes("DataFolder/NoImage.jpg");
            }

            return File(bytes, "application/octet-stream", passprtimg);
        }

        public IActionResult DetailViewTrainee(long Id)
        {
            TraineeMasterDetailView traineeMasterDetailView = new TraineeMasterDetailView();

            using (GCommunicationContext db = new GCommunicationContext())
            {
                traineeMasterDetailView.TraineeMaster = db.TraineeMasters.Where(w => w.TraineeId == Id).FirstOrDefault();
                traineeMasterDetailView.TraineeHistory = db.TraineeHistories.Where(w => w.TraineeId == Id).FirstOrDefault();

                traineeMasterDetailView.countries = db.TraineeMasters.Where(w => w.TraineeId == Id).Join(db.Countries,
                     trainee => trainee.CountryId,
                     country => country.CountryId,
                     (trainee, country) => new { TraineeMaster = trainee, Country = country }).Select(s => s.Country).ToList();

                traineeMasterDetailView.acceptingCompanies = db.TraineeMasters.Where(w => w.TraineeId == Id).Join(db.AcceptingCompanies,
                   trainee => trainee.AcceptingCompanyId,
                   accepting => accepting.AcceptingCompanyId,
                   (trainee, accepting) => new { TraineeMaster = trainee, AcceptingCompany = accepting }).Select(s => s.AcceptingCompany).ToList();

                traineeMasterDetailView.occupations = db.TraineeMasters.Where(w => w.TraineeId == Id).Join(db.Occupations,
                   trainee => trainee.OccupationId,
                   occupation => occupation.OccupationId,
                   (trainee, occupation) => new { TraineeMaster = trainee, Occupation = occupation }).Select(s => s.Occupation).ToList();

                traineeMasterDetailView.sendingCompany = db.TraineeMasters.Where(w => w.TraineeId == Id).Join(db.SendingCompanies,
                   trainee => trainee.SendingCompanyId,
                   sending => sending.SendingCompanyId,
                   (trainee, sending) => new { TraineeMaster = trainee, SendingCompany = sending }).Select(s => s.SendingCompany).ToList();

                traineeMasterDetailView.works = db.TraineeMasters.Where(w => w.TraineeId == Id).Join(db.Works,
                   trainee => trainee.WorkId,
                   work => work.WorkId,
                   (trainee, work) => new { TraineeMaster = trainee, Work = work }).Select(s => s.Work).ToList();

                traineeMasterDetailView.traineeHistories = db.TraineeMasters.Where(w => w.TraineeId == Id).Join(db.TraineeHistories,
                   trainee => trainee.TraineeId,
                   traineehis => traineehis.TraineeId,
                   (trainee, traineehis) => new { TraineeMaster = trainee, TraineeHistory = traineehis }).Select(s => s.TraineeHistory).ToList();
                
                traineeMasterDetailView.TraineeImage = traineeMasterDetailView.TraineeMaster.TraineeImage;
                traineeMasterDetailView.PassportImg = traineeMasterDetailView.TraineeHistory.PassportImg;
                traineeMasterDetailView.LandingPermit = traineeMasterDetailView.TraineeHistory.LandingPermit;
                traineeMasterDetailView.TraineevisaImg1 = traineeMasterDetailView.TraineeHistory.TraineevisaImg1;
                traineeMasterDetailView.RegistrationImg2 = traineeMasterDetailView.TraineeHistory.RegistrationImg2;
                traineeMasterDetailView.DesactvisaImg1 = traineeMasterDetailView.TraineeHistory.DesactvisaImg1;
                traineeMasterDetailView.DesactvisaImg2 = traineeMasterDetailView.TraineeHistory.DesactvisaImg2;
                traineeMasterDetailView.Residentcardyear2 = traineeMasterDetailView.TraineeHistory.Residentcardyear2;
                traineeMasterDetailView.ResidentCard2 = traineeMasterDetailView.TraineeHistory.ResidentCard2;
                traineeMasterDetailView.Residentcardyear3 = traineeMasterDetailView.TraineeHistory.Residentcardyear3;
                traineeMasterDetailView.Residentcard3 = traineeMasterDetailView.TraineeHistory.Residentcard3;
                traineeMasterDetailView.Residentcardyear4 = traineeMasterDetailView.TraineeHistory.Residentcardyear4;
                traineeMasterDetailView.Residentcard4 = traineeMasterDetailView.TraineeHistory.Residentcard4;
                traineeMasterDetailView.Residentcardyesr5 = traineeMasterDetailView.TraineeHistory.Residentcardyesr5;
                traineeMasterDetailView.Residentcard5 = traineeMasterDetailView.TraineeHistory.Residentcard5;
                traineeMasterDetailView.Other1 = traineeMasterDetailView.TraineeHistory.Other1;
                traineeMasterDetailView.Other2 = traineeMasterDetailView.TraineeHistory.Other2;
                //traineeMasterViewModel.BirthDate = DateTime.Now;
                //traineeMasterViewModel.ReturnDate = DateTime.Now;
            }
            return View(traineeMasterDetailView);
        }

        public IActionResult TraineeImage(string TraineeImage)
        {
            byte[] bytes = null;
            try
            {
            bytes = System.IO.File.ReadAllBytes(TraineeImage);
            }
            catch (Exception e)
            {
                TraineeImage = "DataFolder/NoImage.jpg";
                bytes = System.IO.File.ReadAllBytes("DataFolder/NoImage.jpg");
            }
           
            return File(bytes, "application/octet-stream", TraineeImage);
        }

        public IActionResult PassportImg(string PassportImg)
        {
            byte[] bytes = null;
            try
            {
                bytes = System.IO.File.ReadAllBytes(PassportImg);
            }
            catch (Exception e)
            {
                PassportImg = "DataFolder/NoImage.jpg";
                bytes = System.IO.File.ReadAllBytes("DataFolder/NoImage.jpg");
            }
            return File(bytes, "application/octet-stream", PassportImg);
        }

        public IActionResult LandingPermit(string LandingPermit)
        {
            byte[] bytes = null;
            try
            {
                bytes = System.IO.File.ReadAllBytes(LandingPermit);
            }
            catch (Exception e)
            {
                LandingPermit = "DataFolder/NoImage.jpg";
                bytes = System.IO.File.ReadAllBytes("DataFolder/NoImage.jpg");
            }
            return File(bytes, "application/octet-stream", LandingPermit);
        }

        public IActionResult TraineevisaImg1(string TraineevisaImg1)
        {
            byte[] bytes = null;
            try
            {
                bytes = System.IO.File.ReadAllBytes(TraineevisaImg1);
            }
            catch (Exception e)
            {
                TraineevisaImg1 = "DataFolder/NoImage.jpg";
                bytes = System.IO.File.ReadAllBytes("DataFolder/NoImage.jpg");
            }
            return File(bytes, "application/octet-stream", TraineevisaImg1);
        }

        public IActionResult RegistrationImg2(string RegistrationImg2)
        {
            byte[] bytes = null;
            try
            {
                bytes = System.IO.File.ReadAllBytes(RegistrationImg2);
            }
            catch (Exception e)
            {
                RegistrationImg2 = "DataFolder/NoImage.jpg";
                bytes = System.IO.File.ReadAllBytes("DataFolder/NoImage.jpg");
            }
            return File(bytes, "application/octet-stream", RegistrationImg2);
        }

        public IActionResult DesactvisaImg1(string DesactvisaImg1)
        {
            byte[] bytes = null;
            try
            {
                bytes = System.IO.File.ReadAllBytes(DesactvisaImg1);
            }
            catch (Exception e)
            {
                DesactvisaImg1 = "DataFolder/NoImage.jpg";
                bytes = System.IO.File.ReadAllBytes("DataFolder/NoImage.jpg");
            }
            return File(bytes, "application/octet-stream", DesactvisaImg1);
        }

        public IActionResult DesactvisaImg2(string DesactvisaImg2)
        {
            byte[] bytes = null;
            try
            {
                bytes = System.IO.File.ReadAllBytes(DesactvisaImg2);
            }
            catch (Exception e)
            {
                DesactvisaImg2 = "DataFolder/NoImage.jpg";
                bytes = System.IO.File.ReadAllBytes("DataFolder/NoImage.jpg");
            }
            return File(bytes, "application/octet-stream", DesactvisaImg2);
        }

        public IActionResult Residentcardyear2(string Residentcardyear2)
        {
            byte[] bytes = null;
            try
            {
                bytes = System.IO.File.ReadAllBytes(Residentcardyear2);
            }
            catch (Exception e)
            {
                Residentcardyear2 = "DataFolder/NoImage.jpg";
                bytes = System.IO.File.ReadAllBytes("DataFolder/NoImage.jpg");
            }
            return File(bytes, "application/octet-stream", Residentcardyear2);
        }

        public IActionResult ResidentCard2(string ResidentCard2)
        {
            byte[] bytes = null;
            try
            {
                bytes = System.IO.File.ReadAllBytes(ResidentCard2);
            }
            catch (Exception e)
            {
                ResidentCard2 = "DataFolder/NoImage.jpg";
                bytes = System.IO.File.ReadAllBytes("DataFolder/NoImage.jpg");
            }
            return File(bytes, "application/octet-stream", ResidentCard2);
        }

        public IActionResult Residentcardyear3(string Residentcardyear3)
        {
            byte[] bytes = null;
            try
            {
                bytes = System.IO.File.ReadAllBytes(Residentcardyear3);
            }
            catch (Exception e)
            {
                Residentcardyear3 = "DataFolder/NoImage.jpg";
                bytes = System.IO.File.ReadAllBytes("DataFolder/NoImage.jpg");
            }
            return File(bytes, "application/octet-stream", Residentcardyear3);
        }

        public IActionResult Residentcard3(string Residentcard3)
        {
            byte[] bytes = null;
            try
            {
                bytes = System.IO.File.ReadAllBytes(Residentcard3);
            }
            catch (Exception e)
            {
                Residentcard3 = "DataFolder/NoImage.jpg";
                bytes = System.IO.File.ReadAllBytes("DataFolder/NoImage.jpg");
            }
            return File(bytes, "application/octet-stream", Residentcard3);
        }

        public IActionResult Residentcardyear4(string Residentcardyear4)
        {
            byte[] bytes = null;
            try
            {
                bytes = System.IO.File.ReadAllBytes(Residentcardyear4);
            }
            catch (Exception e)
            {
                Residentcardyear4 = "DataFolder/NoImage.jpg";
                bytes = System.IO.File.ReadAllBytes("DataFolder/NoImage.jpg");
            }
            return File(bytes, "application/octet-stream", Residentcardyear4);
        }

        public IActionResult Residentcard4(string Residentcard4)
        {
            byte[] bytes = null;
            try
            {
                bytes = System.IO.File.ReadAllBytes(Residentcard4);
            }
            catch (Exception e)
            {
                Residentcard4 = "DataFolder/NoImage.jpg";
                bytes = System.IO.File.ReadAllBytes("DataFolder/NoImage.jpg");
            }
            return File(bytes, "application/octet-stream", Residentcard4);
        }

        public IActionResult Residentcardyesr5(string Residentcardyesr5)
        {
            byte[] bytes = null;
            try
            {
                bytes = System.IO.File.ReadAllBytes(Residentcardyesr5);
            }
            catch (Exception e)
            {
                Residentcardyesr5 = "DataFolder/NoImage.jpg";
                bytes = System.IO.File.ReadAllBytes("DataFolder/NoImage.jpg");
            }
            return File(bytes, "application/octet-stream", Residentcardyesr5);
        }

        public IActionResult Residentcard5(string Residentcard5)
        {
            byte[] bytes = null;
            try
            {
                bytes = System.IO.File.ReadAllBytes(Residentcard5);
            }
            catch (Exception e)
            {
                Residentcard5 = "DataFolder/NoImage.jpg";
                bytes = System.IO.File.ReadAllBytes("DataFolder/NoImage.jpg");
            }
            return File(bytes, "application/octet-stream", Residentcard5);
        }

        public IActionResult Other1(string Other1)
        {
            byte[] bytes = null;
            try
            {
                bytes = System.IO.File.ReadAllBytes(Other1);
            }
            catch (Exception e)
            {
                Other1 = "DataFolder/NoImage.jpg";
                bytes = System.IO.File.ReadAllBytes("DataFolder/NoImage.jpg");
            }
            return File(bytes, "application/octet-stream", Other1);
        }

        public IActionResult Other2(string Other2)
        {
            byte[] bytes = null;
            try
            {
                bytes = System.IO.File.ReadAllBytes(Other2);
            }
            catch (Exception e)
            {
                Other2 = "DataFolder/NoImage.jpg";
                bytes = System.IO.File.ReadAllBytes("DataFolder/NoImage.jpg");
            }
            return File(bytes, "application/octet-stream", Other2);
        }

        public IActionResult SaveNewTrainee( TraineeMasterViewModel postData)
        {
                        // it has come
            AddTraaneeData addTraaneeData = new AddTraaneeData(Request.HttpContext);
            addTraaneeData.DataSaving(postData);

            return Redirect("/Trainee/TraineeMaster/Index");

         
        }
        public IActionResult SaveEditedTrainee(TraineeMasterViewModel postData)
        {
            // it has come
            EditTraineeData editTraaneeData = new EditTraineeData(Request.HttpContext);
            editTraaneeData.DataSaving(postData);

            return Redirect("/Trainee/TraineeMaster/Index");


        }
        public IActionResult DownloadFile(long Id)
        {
            string documentPath = "";
            byte[] bytes = null;
            using (GCommunicationContext db = new GCommunicationContext())
            {
                {
                var documentViewModel1 = db.TraineeMasters.Where(w => w.TraineeId == Id).ToList();
                foreach (var item in documentViewModel1)
                {
                    documentPath = item.TraineeImage;
                }
            }

            try
            {
                    if ( documentPath !=null)
                    {
                        bytes = System.IO.File.ReadAllBytes(documentPath);
                    }

               
             
                }
            catch (Exception e)
            {
                

            }
                if (bytes != null)
                {

                    FileInfo fileInfo = new FileInfo(documentPath);
                    string fileName = documentPath;
                    return File(bytes, "application/octet-stream", fileName);
                }
                else {

                    string fileName = "/DataFolder/NoImage.jpg";
                    bytes = System.IO.File.ReadAllBytes("DataFolder/NoImage.jpg");
                    return File(bytes, "application/octet-stream", fileName);
                }


            }
    }

        public IActionResult DeleteTrainee(long Id)
        {

            using (GCommunicationContext db = new GCommunicationContext())
            {
                DbModels.TraineeMaster tmas = db.TraineeMasters.Where(w => w.TraineeId == Id).First();

                tmas.IsDelete = true;
                tmas.DeleteFlg = true;
                db.SaveChanges();

            }
            return Redirect("/Trainee/TraineeMaster/Index");
        }

        public int GetOccupationId(int WorkId)
        {
            int OccupationId;
            using (GCommunicationContext db = new GCommunicationContext())
            {
                var Traineneeocuupation = db.Works.Where(w => w.WorkId == WorkId).Join
                   (db.Occupations,
                       tmaster => tmaster.OccupationId,
                       occu => occu.OccupationId,
                       (tmaster, occu) => new { Work = tmaster, Occupation = occu }
                   ).FirstOrDefault();
                OccupationId = Traineneeocuupation.Occupation.OccupationId;
            }
             
            return OccupationId;
        }
        public string GetJapanEra(DateTime birthDate)
        {
            string flag = "";

            JapaneseCalendar niponEra = new JapaneseCalendar();

            DateTime nullDate = new DateTime(1, 1, 0001).Date;

            DateTime birthdayInput = new DateTime(birthDate.Year, birthDate.Month,
                birthDate.Day, new GregorianCalendar());

            if (birthdayInput != nullDate)
            {
                int era = niponEra.GetEra(birthdayInput);
                switch (era)
                {
                    case 1:
                        flag = "明治";
                        break;
                    case 2:
                        flag = "大正";
                        break;
                    case 3:
                        flag = "昭和";
                        break;
                    case 4:
                        flag = "平成";
                        break;
                    case 5:
                        flag = "令和";
                        break;
                }

            }

            return flag;
        }

        public int GetAge(DateTime birthDate)
{
            int age = 0;
            var today = DateTime.Today;
            age = today.Year - birthDate.Year;
            int m = today.Month - birthDate.Month;
            int d = today.Day - birthDate.Day;
            if (m < 0 || ((m == 0) && (d < 0)))
            {
                age--;
                    //$("input[name='Age']").val(age);
            }
            return age;
        }

        public IActionResult CountyListView()
        {
            List<Country> countries = new List<Country>();
            using(GCommunicationContext db = new GCommunicationContext())
            {

                countries = db.Countries.Where(w=> w.IsDeleteCountry == false).ToList();

            }
            return View(countries);
        }

        public IActionResult PrefectureListView()
        {
            List<Perfecture> perfectures = new List<Perfecture>();
            using (GCommunicationContext db = new GCommunicationContext())
            {

                var acceptingPerfecture = db.Perfectures.Where(w => w.IsDeletePerfecture == false).Join(
                    db.AcceptingCompanies.Where(w=> w.IsDeleteAcceptCom == false),
                    perfecture => perfecture.PerfectureId,
                    acceptingCompany => acceptingCompany.PerfectureId,
                    (perfecture, acceptingCompany) => new { Perfecture = perfecture, AcceptingCompany = acceptingCompany }
                    );

                int Id = 0;

                foreach (var item in acceptingPerfecture)
                {
                    Perfecture perfecture = new Perfecture();

                    if (Id != item.Perfecture.PerfectureId)
                    {
                        Id = item.Perfecture.PerfectureId;
                        perfecture.PerfectureId = item.Perfecture.PerfectureId;
                        perfecture.PerfectureCode = item.Perfecture.PerfectureCode;
                        perfecture.PerfectureName = item.Perfecture.PerfectureName;
                        perfectures.Add(perfecture);
                    }
                }
            }
            return View(perfectures);
        }

        public IActionResult SendingCompanyList()
        {
            List<SendingCompany> sendingCompanies = new List<SendingCompany>();
            using (GCommunicationContext db = new GCommunicationContext())
            {


                sendingCompanies = db.SendingCompanies.Where(w=> w.IsDeleteSendingCompany == false).ToList();

            }
            return View(sendingCompanies);
        }

        public IActionResult AcceptingCompanyList()
        {
            List<DbModels.AcceptingCompany> acceptingCompanies = new List<DbModels.AcceptingCompany>();
            using (GCommunicationContext db = new GCommunicationContext())
            {

                acceptingCompanies = db.AcceptingCompanies.Where(w=> w.IsDeleteAcceptCom == false).ToList();

            }
            return View(acceptingCompanies);
        }

        public IActionResult OccupationList()
        {
            List<DbModels.Occupation> occupations = new List<DbModels.Occupation>();
            using (GCommunicationContext db = new GCommunicationContext())
            {

                occupations = db.Occupations.Where(w=> w.IsDeleteOccupation == false).ToList();
            }
            return View(occupations);
        }

       
        public class RequestData
        {
            public List<string> tblHeaders { get; set; }
            public string accepCompany { get; set; }
            public int sRadioBtn { get; set; }

        }
        public class AcceptingCompany
        {
            public string AcompanyName { get; set; }
            public int ACompanyId { get; set; }

        }
    }
}
