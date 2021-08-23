using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Storage;
using GloableCommunication.Areas.Trainee.Models.ViewModel;
using GloableCommunication.DbModels;
using System.IO;

namespace GloableCommunication.Areas.Trainee.Controllers
{
    public class EditTraineeData
    {

        GCommunicationContext db = null;
        IDbContextTransaction transaction = null;
        HttpContext context;

        public EditTraineeData(HttpContext context_)
        {
            context = context_;
            db = new GCommunicationContext();
        }

        ~EditTraineeData()
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

        public void DataSaving(TraineeMasterViewModel traineeMasterViewModel)
        {
            try
            {
                transaction = db.Database.BeginTransaction();
                TraineeMaster traineeMasterData = new TraineeMaster();

                traineeMasterData = TraineerInfomationSection(traineeMasterViewModel, traineeMasterData);
                traineeMasterData = TraineerInfomationQualificationSection(traineeMasterViewModel, traineeMasterData);
                traineeMasterData = SendingInformationSection(traineeMasterViewModel, traineeMasterData);
                traineeMasterData = CertificateDetails(traineeMasterViewModel, traineeMasterData);
                traineeMasterData = TestInfoSection(traineeMasterViewModel, traineeMasterData);

                TraineeHistory traineeHistoryData = new TraineeHistory();
                traineeHistoryData = TraineeHistoryInformationSection(traineeMasterViewModel, traineeHistoryData);
                traineeHistoryData = ImageUpload(traineeMasterViewModel, traineeHistoryData);


           

               DbModels.TraineeMaster tm =  db.TraineeMasters.Where(w => w.TraineeId == traineeMasterViewModel.TraineeId).First();
                tm.TraineeNo = traineeMasterData.TraineeNo;
                tm.GraduationFlg = traineeMasterData.GraduationFlg;
                tm.NewOldSystem = traineeMasterData.NewOldSystem;
                tm.Schlarship = traineeMasterData.Schlarship;
                tm.DelayedEntry = traineeMasterData.DelayedEntry;
                tm.TraineeName = traineeMasterData.TraineeName;
                tm.KatakanaName = traineeMasterData.KatakanaName;
                tm.KanjiName = traineeMasterData.KanjiName;
                tm.BloodTypeFlg = traineeMasterData.BloodTypeFlg;
                tm.SexFlag = traineeMasterData.SexFlag;
                tm.SpouseFlg = traineeMasterData.SpouseFlg;
                tm.BirthDate = traineeMasterData.BirthDate;
                tm.BirthPlace = traineeMasterData.BirthPlace;
                tm.BirthdayByEra = traineeMasterData.BirthdayByEra;
                tm.Age = traineeMasterData.Age;
                tm.CountryId = traineeMasterData.CountryId;
                tm.Zip = traineeMasterData.Zip;
                tm.Address1 = traineeMasterData.Address1;
                tm.Address2 = traineeMasterData.Address2;
                tm.TelephoneNo = traineeMasterData.TelephoneNo;
                tm.Email = traineeMasterData.Email;
                tm.WorkId = traineeMasterData.WorkId;
                tm.SendingCompanyId = traineeMasterData.SendingCompanyId;
                tm.AcceptingCompanyId = traineeMasterData.AcceptingCompanyId;
                tm.Memo1 = traineeMasterData.Memo1;
                tm.Memo2 = traineeMasterData.Memo2;
                tm.Memo3 = traineeMasterData.Memo3;
                tm.Memo3 = traineeMasterData.Memo3;
                if (traineeMasterData.TraineeImage != null)
                {
                    tm.TraineeImage = traineeMasterData.TraineeImage;
                }
             
                tm.GroupTo = traineeMasterData.GroupTo;
                tm.GroupFrom = traineeMasterData.GroupFrom;
                tm.PracticalTrainingFrom = traineeMasterData.PracticalTrainingFrom;
                tm.PracticalTrainingTo = traineeMasterData.PracticalTrainingTo;
                tm.PracticalTrainingFrom2 = traineeMasterData.PracticalTrainingFrom2;
                tm.PracticalTrainingTo2 = traineeMasterData.PracticalTrainingTo2;
                tm.PracticalTrainingFrom3 = traineeMasterData.PracticalTrainingFrom3;
                tm.PracticalTrainingTo3 = traineeMasterData.PracticalTrainingTo3;
                tm.TechnicalFrom = traineeMasterData.TechnicalFrom;
                tm.TechnicalTo = traineeMasterData.TechnicalTo;
                tm.SpecificActivityFrom = traineeMasterData.SpecificActivityFrom;
                tm.SpecificActivityto = traineeMasterData.SpecificActivityto;
                tm.SpecificNo1From = traineeMasterData.SpecificNo1From;
                tm.SpecificNo1To = traineeMasterData.SpecificNo1To;
                tm.SpecificNo2From = traineeMasterData.SpecificNo2From;
                tm.SpecificNo2To = traineeMasterData.SpecificNo2To;
                tm.EntranceDate = traineeMasterData.EntranceDate;
                tm.EntryDate = traineeMasterData.EntryDate;
                tm.HiringDate = traineeMasterData.HiringDate;
                tm.ReturnDate = traineeMasterData.ReturnDate;
                tm.NewSystemstartDate = traineeMasterData.NewSystemstartDate;
                tm.Scheduledstartdateforboth = traineeMasterData.Scheduledstartdateforboth;
                tm.ReturnPlanDate1 = traineeMasterData.ReturnPlanDate1;
                tm.ReturnPlanDate2 = traineeMasterData.ReturnPlanDate2;
                tm.TotalStartDate = traineeMasterData.TotalStartDate;
                tm.Returndate3 = traineeMasterData.Returndate3;
                tm.PositionStatus = traineeMasterData.PositionStatus;
                tm.EntranceStatus = traineeMasterData.EntranceStatus;
                tm.Specificskillstart1 = traineeMasterData.Specificskillstart1;
                tm.Specificskillstart2 = traineeMasterData.Specificskillstart2;
                tm.SpecificskillRhome1 = traineeMasterData.SpecificskillRhome1;
                tm.SpecificskillRhome2 = traineeMasterData.SpecificskillRhome2;
                tm.Testname = traineeMasterData.Testname;
                tm.Classname1 = traineeMasterData.Classname1;
                tm.Passdate = traineeMasterData.Passdate;
                tm.Result = traineeMasterData.Result;
                tm.Classname2 = traineeMasterData.Classname2;
                tm.Passdate2 = traineeMasterData.Passdate2;
                tm.Result2 = traineeMasterData.Result2;
                tm.Certification1No = traineeMasterData.Certification1No;
                tm.Generation = traineeMasterData.Generation;
                tm.Certification1Date = traineeMasterData.Certification1Date;
                tm.Certification1From = traineeMasterData.Certification1From;
                tm.Certification1To = traineeMasterData.Certification1To;
                tm.Certification2No = traineeMasterData.Certification2No;
                tm.Certification2Date = traineeMasterData.Certification2Date;
                tm.Certification2From = traineeMasterData.Certification2From;
                tm.Certification2To = traineeMasterData.Certification2To;
                tm.Certification3No = traineeMasterData.Certification3No;
                tm.Certification3Date = traineeMasterData.Certification3Date;
                tm.Certification3From = traineeMasterData.Certification3From;
                tm.Certification3To = traineeMasterData.Certification3To;

                DbModels.TraineeHistory th = db.TraineeHistories.Where(w => w.TraineeHistoryId == traineeMasterViewModel.TraineeHistoryId).First();
        
                th.PassportNo = traineeHistoryData.PassportNo;
                th.PassportLimit = traineeHistoryData.PassportLimit;
                if (traineeHistoryData.RegistrationNo != null)
                {
                    th.ResidentCardNo = traineeHistoryData.RegistrationNo.ToString();
                }

                if (traineeHistoryData.RegistrationLimit != null)
                {
                    th.RegistrationLimit = traineeHistoryData.RegistrationLimit;
                }
               
                th.UpdateDate = traineeHistoryData.UpdateDate;
                if (traineeHistoryData.PassportImg != null)
                {
                    th.PassportImg = traineeHistoryData.PassportImg;
                }

                if (traineeHistoryData.LandingPermit != null)
                {
                    th.LandingPermit = traineeHistoryData.LandingPermit;
                }
                if (traineeHistoryData.TraineevisaImg1 != null)
                {
                    th.TraineevisaImg1 = traineeHistoryData.TraineevisaImg1;
                }
                if (traineeHistoryData.RegistrationImg2 != null)
                {
                    th.RegistrationImg2 = traineeHistoryData.RegistrationImg2;
                }

                if (traineeHistoryData.DesactvisaImg1 != null)
                {
                    th.DesactvisaImg1 = traineeHistoryData.DesactvisaImg1;
                }
                if (traineeHistoryData.DesactvisaImg2 != null)
                {
                    th.DesactvisaImg2 = traineeHistoryData.DesactvisaImg2;
                }

                if (traineeHistoryData.ResidentCard2 != null)
                {
                    th.ResidentCard2 = traineeHistoryData.ResidentCard2;
                }

                if (traineeHistoryData.Residentcardyear2 != null)
                {
                    th.Residentcardyear2 = traineeHistoryData.Residentcardyear2;
                }
                if (traineeHistoryData.Residentcardyear2 != null)
                {
                    th.Residentcardyear2 = traineeHistoryData.Residentcardyear2;
                }

                if (traineeHistoryData.Residentcard3 != null)
                {
                    th.Residentcard3 = traineeHistoryData.Residentcard3;
                }

                if (traineeHistoryData.Residentcardyear3 != null)
                {
                    th.Residentcardyear3 = traineeHistoryData.Residentcardyear3;
                }
                if (traineeHistoryData.Residentcard4 != null)
                {
                    th.Residentcard4 = traineeHistoryData.Residentcard4;
                }
                if (traineeHistoryData.Residentcardyear4 != null)
                {
                    th.Residentcardyear4 = traineeHistoryData.Residentcardyear4;
                }
                if (traineeHistoryData.Residentcard5 != null)
                {
                    th.Residentcard5 = traineeHistoryData.Residentcard5;
                }
                if (traineeHistoryData.Residentcardyesr5 != null)
                {
                    th.Residentcardyesr5 = traineeHistoryData.Residentcardyesr5;
                }
                if (traineeHistoryData.Other1 != null)
                {
                    th.Other1 = traineeHistoryData.Other1;
                }
                if (traineeHistoryData.Other2 != null)
                {
                    th.Other2 = traineeHistoryData.Other1;
                }
                db.SaveChanges();
                transaction.Commit();
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

         private TraineeMaster TraineerInfomationSection(TraineeMasterViewModel traineeMasterViewModel, TraineeMaster traineeMasterData)
        {
           traineeMasterData.TraineeId = traineeMasterViewModel.TraineeId;
            traineeMasterData.TraineeNo = traineeMasterViewModel.TraineeNo;
            traineeMasterData.GraduationFlg = traineeMasterViewModel.GraduationFlg;
            traineeMasterData.NewOldSystem = traineeMasterViewModel.NewOldSystem;
            traineeMasterData.Schlarship = traineeMasterViewModel.Schlarship;
            traineeMasterData.DelayedEntry = traineeMasterViewModel.DelayedEntry;
            traineeMasterData.TraineeName = traineeMasterViewModel.TraineeName;
            traineeMasterData.KatakanaName = traineeMasterViewModel.KatakanaName;
            traineeMasterData.KanjiName = traineeMasterViewModel.KanjiName;
            traineeMasterData.BloodTypeFlg = traineeMasterViewModel.BloodTypeFlg;
            traineeMasterData.SexFlag = traineeMasterViewModel.SexFlag;
            traineeMasterData.SpouseFlg = traineeMasterViewModel.SpouseFlg;
            traineeMasterData.BirthDate = traineeMasterViewModel.BirthDate;
            traineeMasterData.BirthPlace = traineeMasterViewModel.BirthPlace;
            traineeMasterData.BirthdayByEra = traineeMasterViewModel.BirthdayByEra;
            traineeMasterData.Age = traineeMasterViewModel.Age;
            traineeMasterData.CountryId = traineeMasterViewModel.CountryId;
            traineeMasterData.Zip = traineeMasterViewModel.Zip;
            traineeMasterData.Address1 = traineeMasterViewModel.Address1;
            traineeMasterData.Address2 = traineeMasterViewModel.Address2;
            traineeMasterData.TelephoneNo = traineeMasterViewModel.TelephoneNo;
            traineeMasterData.Email = traineeMasterViewModel.Email;
            traineeMasterData.WorkId = traineeMasterViewModel.WorkId;
            traineeMasterData.SendingCompanyId = traineeMasterViewModel.SendingCompanyId;
            traineeMasterData.AcceptingCompanyId = traineeMasterViewModel.AcceptingCompanyId;
            traineeMasterData.Memo1 = traineeMasterViewModel.Memo1;
            traineeMasterData.Memo2 = traineeMasterViewModel.Memo2;
            traineeMasterData.Memo3 = traineeMasterViewModel.Memo3;
            traineeMasterData.EntranceDate = traineeMasterViewModel.EntranceDate;
            traineeMasterData.UpdateDate = traineeMasterViewModel.UpdateDate;



            try
            {
                var files = context.Request.Form.Files;
                // traineeMasterData.TraineeImage = context.Request.Path;
                if (traineeMasterViewModel.TraineeImage != null)
                {
                    if (traineeMasterViewModel.TraineeImage != null || traineeMasterViewModel.TraineeImage.Length != 0)
                    {
                        string path = "DataFolder/" + DateTime.UtcNow.ToString("yyyyMMddHHmmss") + "-" + traineeMasterViewModel.TraineeImage.FileName;

                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            traineeMasterViewModel.TraineeImage.CopyTo(stream);

                            traineeMasterData.TraineeImage = path;

                        }
                    }
                }
                    


            }
            catch (Exception e)
            {

            }
       
            
            return traineeMasterData;
        }

        private TraineeMaster TraineerInfomationQualificationSection(TraineeMasterViewModel traineeMasterViewModel, TraineeMaster traineeMasterData)
        {
            traineeMasterData.GroupFrom = traineeMasterViewModel.GroupFrom;
            traineeMasterData.GroupTo = traineeMasterViewModel.GroupTo;
            traineeMasterData.PracticalTrainingFrom = traineeMasterViewModel.PracticalTrainingFrom;
            traineeMasterData.PracticalTrainingTo = traineeMasterViewModel.PracticalTrainingTo;
            traineeMasterData.PracticalTrainingFrom2 = traineeMasterViewModel.PracticalTrainingFrom2;
            traineeMasterData.PracticalTrainingTo2 = traineeMasterViewModel.PracticalTrainingTo2;
            traineeMasterData.PracticalTrainingFrom3 = traineeMasterViewModel.PracticalTrainingFrom3;
            traineeMasterData.PracticalTrainingTo3 = traineeMasterViewModel.PracticalTrainingTo3;
            traineeMasterData.TechnicalFrom = traineeMasterViewModel.TechnicalFrom;
            traineeMasterData.TechnicalTo = traineeMasterViewModel.TechnicalTo;
            traineeMasterData.SpecificActivityFrom = traineeMasterViewModel.SpecificActivityFrom;
            traineeMasterData.SpecificActivityto = traineeMasterViewModel.SpecificActivityto;
            traineeMasterData.SpecificNo1From = traineeMasterViewModel.SpecificNo1From;
            traineeMasterData.SpecificNo1To = traineeMasterViewModel.SpecificNo1To;
            traineeMasterData.SpecificNo2From = traineeMasterViewModel.SpecificNo2From;
            traineeMasterData.SpecificNo2To = traineeMasterViewModel.SpecificNo2To;
            return traineeMasterData;


        }

        private TraineeHistory TraineeHistoryInformationSection(TraineeMasterViewModel traineeMasterViewModel, TraineeHistory traineeHistoryData)
        {
            traineeHistoryData.TraineeHistoryId = traineeMasterViewModel.TraineeHistoryId;
            traineeHistoryData.TraineeId = traineeMasterViewModel.TraineeId;
            traineeHistoryData.PassportNo = traineeMasterViewModel.PassportNo;
            traineeHistoryData.PassportLimit = traineeMasterViewModel.PassportLimit;
            if (traineeMasterViewModel.ResidentCardNo!=null)
            {
                traineeHistoryData.RegistrationNo = traineeMasterViewModel.RegistrationNo.ToString();
            }
           
            traineeHistoryData.RegistrationLimit = traineeMasterViewModel.RegistrationLimit;
    
            traineeHistoryData.UpdateDate = traineeMasterViewModel.UpdateDate;


            return traineeHistoryData;

        }


        private TraineeMaster SendingInformationSection(TraineeMasterViewModel traineeMasterViewModel, TraineeMaster TraineeMasterData)
        {
            TraineeMasterData.EntranceDate = traineeMasterViewModel.EntranceDate;
            TraineeMasterData.EntryDate = traineeMasterViewModel.EntryDate;
            TraineeMasterData.HiringDate = traineeMasterViewModel.HiringDate;
            TraineeMasterData.ReturnDate = traineeMasterViewModel.ReturnDate;
            TraineeMasterData.NewSystemstartDate = traineeMasterViewModel.NewSystemstartDate;
            TraineeMasterData.Scheduledstartdateforboth = traineeMasterViewModel.Scheduledstartdateforboth;
            TraineeMasterData.ReturnPlanDate1 = traineeMasterViewModel.ReturnPlanDate1;
            TraineeMasterData.ReturnPlanDate2 = traineeMasterViewModel.ReturnPlanDate2;
            TraineeMasterData.TotalStartDate = traineeMasterViewModel.TotalStartDate;
            TraineeMasterData.Returndate3 = traineeMasterViewModel.Returndate3;
            TraineeMasterData.PositionStatus = traineeMasterViewModel.PositionStatus;
            TraineeMasterData.Immigrationstatus = traineeMasterViewModel.Immigrationstatus;
            TraineeMasterData.Specificskillstart1 = traineeMasterViewModel.Specificskillstart1;
            TraineeMasterData.Specificskillstart2 = traineeMasterViewModel.Specificskillstart2;
            TraineeMasterData.SpecificskillRhome1 = traineeMasterViewModel.SpecificskillRhome1;
            TraineeMasterData.SpecificskillRhome2 = traineeMasterViewModel.SpecificskillRhome2;
            return TraineeMasterData;

        }

        private TraineeMaster TestInfoSection(TraineeMasterViewModel traineeMasterViewModel, TraineeMaster traineeMasterData)
        {
            traineeMasterData.Testname = traineeMasterViewModel.Testname;
            traineeMasterData.Classname1 = traineeMasterViewModel.Classname1;
            traineeMasterData.Passdate = traineeMasterViewModel.Passdate;
            traineeMasterData.Result = traineeMasterViewModel.Result;
            traineeMasterData.Classname2 = traineeMasterViewModel.Classname2;
            traineeMasterData.Passdate2 = traineeMasterViewModel.Passdate2;
            traineeMasterData.Result2 = traineeMasterViewModel.Result2;
           
            return traineeMasterData;


        }
        private TraineeHistory ImageUpload(TraineeMasterViewModel traineeMasterViewModel, TraineeHistory TraineeHistoryData)
        {
            try
            {
                var files = context.Request.Form.Files;
                // traineeMasterData.TraineeImage = context.Request.Path;
                if ( traineeMasterViewModel.PassportImg!= null)
                {

                    if (traineeMasterViewModel.PassportImg != null || traineeMasterViewModel.PassportImg.Length != 0)
                    {
                        string path = "DataFolder/" + DateTime.UtcNow.ToString("yyyyMMddHHmmss") + "-" + traineeMasterViewModel.PassportImg.FileName;

                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            traineeMasterViewModel.PassportImg.CopyTo(stream);
                            TraineeHistoryData.PassportImg = path;

                        }
                    }
                }

                if (traineeMasterViewModel.LandingPermit !=null)
                {
                    if (traineeMasterViewModel.LandingPermit != null || traineeMasterViewModel.LandingPermit.Length != 0)
                    {
                        string path = "DataFolder/" + DateTime.UtcNow.ToString("yyyyMMddHHmmss") + "-" + traineeMasterViewModel.LandingPermit.FileName;

                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            traineeMasterViewModel.LandingPermit.CopyTo(stream);
                            TraineeHistoryData.LandingPermit = path;

                        }
                    }
                }

                if (traineeMasterViewModel.TraineevisaImg1 !=null)
                {
                    if (traineeMasterViewModel.TraineevisaImg1 != null || traineeMasterViewModel.TraineevisaImg1.Length != 0)
                    {
                        string path =  "DataFolder/" + DateTime.UtcNow.ToString("yyyyMMddHHmmss") + "-" + traineeMasterViewModel.TraineevisaImg1.FileName;

                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            traineeMasterViewModel.TraineevisaImg1.CopyTo(stream);
                            TraineeHistoryData.TraineevisaImg1 = path;

                        }
                    }
                }


                if (traineeMasterViewModel.RegistrationImg2 !=null)
                {
                    if (traineeMasterViewModel.RegistrationImg2 != null || traineeMasterViewModel.RegistrationImg2.Length != 0)
                    {
                        string path = "DataFolder/" + DateTime.UtcNow.ToString("yyyyMMddHHmmss") + "-" + traineeMasterViewModel.RegistrationImg2.FileName;

                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            traineeMasterViewModel.RegistrationImg2.CopyTo(stream);
                            TraineeHistoryData.RegistrationImg2 = path;

                        }
                    }
                }

                if (traineeMasterViewModel.DesactvisaImg1 != null)
                {
                    if (traineeMasterViewModel.DesactvisaImg1 != null || traineeMasterViewModel.DesactvisaImg1.Length != 0)
                    {
                        string path = "DataFolder/" + DateTime.UtcNow.ToString("yyyyMMddHHmmss") + "-" + traineeMasterViewModel.DesactvisaImg1.FileName;

                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            traineeMasterViewModel.DesactvisaImg1.CopyTo(stream);
                            TraineeHistoryData.DesactvisaImg1 = path;

                        }
                    }

                }

                if (traineeMasterViewModel.DesactvisaImg2 != null)
                {
                    if (traineeMasterViewModel.DesactvisaImg2 != null || traineeMasterViewModel.DesactvisaImg2.Length != 0)
                    {
                        string path = "DataFolder/" + DateTime.UtcNow.ToString("yyyyMMddHHmmss") + "-" + traineeMasterViewModel.DesactvisaImg2.FileName;

                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            traineeMasterViewModel.DesactvisaImg2.CopyTo(stream);
                            TraineeHistoryData.DesactvisaImg2 = path;

                        }
                    }
                }

                if (traineeMasterViewModel.ResidentCard2 != null)
                {
                    if (traineeMasterViewModel.ResidentCard2 != null || traineeMasterViewModel.ResidentCard2.Length != 0)
                    {
                        string path = "DataFolder/" + DateTime.UtcNow.ToString("yyyyMMddHHmmss") + "-" + traineeMasterViewModel.ResidentCard2.FileName;

                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            traineeMasterViewModel.ResidentCard2.CopyTo(stream);
                            TraineeHistoryData.ResidentCard2 = path;

                        }
                    }
                }

                if (traineeMasterViewModel.Residentcardyear2 != null)
                {
                    if (traineeMasterViewModel.Residentcardyear2 != null || traineeMasterViewModel.Residentcardyear2.Length != 0)
                    {
                        string path = "DataFolder/" + DateTime.UtcNow.ToString("yyyyMMddHHmmss") + "-" + traineeMasterViewModel.Residentcardyear2.FileName;

                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            traineeMasterViewModel.Residentcardyear2.CopyTo(stream);
                            TraineeHistoryData.Residentcardyear2 = path;

                        }
                    }

                }

                if (traineeMasterViewModel.Residentcard3 != null)
                {

                    if (traineeMasterViewModel.Residentcard3 != null || traineeMasterViewModel.Residentcard3.Length != 0)
                    {
                        string path = "DataFolder/" + DateTime.UtcNow.ToString("yyyyMMddHHmmss") + "-" + traineeMasterViewModel.Residentcard3.FileName;

                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            traineeMasterViewModel.Residentcard3.CopyTo(stream);
                            TraineeHistoryData.Residentcard3 = path;

                        }
                    }

                }

                if (traineeMasterViewModel.Residentcardyear3 != null)
                {
                    if (traineeMasterViewModel.Residentcardyear3 != null || traineeMasterViewModel.Residentcardyear3.Length != 0)
                    {
                        string path = "DataFolder/" + DateTime.UtcNow.ToString("yyyyMMddHHmmss") + "-" + traineeMasterViewModel.Residentcardyear3.FileName;

                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            traineeMasterViewModel.Residentcardyear3.CopyTo(stream);
                            TraineeHistoryData.Residentcardyear3 = path;

                        }
                    }


                }


                if (traineeMasterViewModel.Residentcard4 != null)
                {
                    if (traineeMasterViewModel.Residentcard4 != null || traineeMasterViewModel.Residentcard4.Length != 0)
                    {
                        string path = "DataFolder/" + DateTime.UtcNow.ToString("yyyyMMddHHmmss") + "-" + traineeMasterViewModel.Residentcard4.FileName;

                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            traineeMasterViewModel.Residentcard4.CopyTo(stream);
                            TraineeHistoryData.Residentcard4 = path;

                        }
                    }

                }

                if (traineeMasterViewModel.Residentcardyear4 != null)
                {
                    if (traineeMasterViewModel.Residentcardyear4 != null || traineeMasterViewModel.Residentcardyear4.Length != 0)
                    {
                        string path = "DataFolder/" + DateTime.UtcNow.ToString("yyyyMMddHHmmss") + "-" + traineeMasterViewModel.Residentcardyear4.FileName;

                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            traineeMasterViewModel.Residentcardyear4.CopyTo(stream);
                            TraineeHistoryData.Residentcardyear4 = path;

                        }
                    }
                }

                if (traineeMasterViewModel.Residentcard5 != null)
                {
                    if (traineeMasterViewModel.Residentcard5 != null || traineeMasterViewModel.Residentcard5.Length != 0)
                    {
                        string path = "DataFolder/" + DateTime.UtcNow.ToString("yyyyMMddHHmmss") + "-" + traineeMasterViewModel.Residentcard5.FileName;

                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            traineeMasterViewModel.Residentcard5.CopyTo(stream);
                            TraineeHistoryData.Residentcard5 = path;

                        }
                    }
                }

                if (traineeMasterViewModel.Residentcardyesr5 != null)
                {
                    if (traineeMasterViewModel.Residentcardyesr5 != null || traineeMasterViewModel.Residentcardyesr5.Length != 0)
                    {
                        string path = "DataFolder/" + DateTime.UtcNow.ToString("yyyyMMddHHmmss") + "-" + traineeMasterViewModel.Residentcardyesr5.FileName;

                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            traineeMasterViewModel.Residentcardyesr5.CopyTo(stream);
                            TraineeHistoryData.Residentcardyesr5 = path;

                        }
                    }

                }

                if (traineeMasterViewModel.Other1 != null)
                {
                    if (traineeMasterViewModel.Other1 != null || traineeMasterViewModel.Other1.Length != 0)
                    {
                        string path = "DataFolder/" + DateTime.UtcNow.ToString("yyyyMMddHHmmss") + "-" + traineeMasterViewModel.Other1.FileName;

                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            traineeMasterViewModel.Other1.CopyTo(stream);
                            TraineeHistoryData.Other1 = path;

                        }
                    }

                }
                if (traineeMasterViewModel.Other2 != null)
                {
                    if (traineeMasterViewModel.Other2 != null || traineeMasterViewModel.Other2.Length != 0)
                    {
                        string path = "DataFolder/" + DateTime.UtcNow.ToString("yyyyMMddHHmmss") + "-" + traineeMasterViewModel.Other2.FileName;

                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            traineeMasterViewModel.Other2.CopyTo(stream);
                            TraineeHistoryData.Other2 = path;

                        }
                    }
                }

                
            }
            catch (Exception e)
            {

            }




            return TraineeHistoryData;

        }

        private TraineeMaster CertificateDetails(TraineeMasterViewModel traineeMasterViewModel, TraineeMaster TraineeMasterData)
        {
            TraineeMasterData.Certification1No = traineeMasterViewModel.Certification1No;
            TraineeMasterData.Generation = traineeMasterViewModel.Generation;
            TraineeMasterData.Certification1Date = traineeMasterViewModel.Certification1Date;
            TraineeMasterData.Certification1From = traineeMasterViewModel.Certification1From;
            TraineeMasterData.Certification1To = traineeMasterViewModel.Certification1To;
            TraineeMasterData.Certification2No = traineeMasterViewModel.Certification2No;
            TraineeMasterData.Certification2Date = traineeMasterViewModel.Certification2Date;
            TraineeMasterData.Certification2From = traineeMasterViewModel.Certification2From;
            TraineeMasterData.Certification2To = traineeMasterViewModel.Certification2To;
            TraineeMasterData.Certification3No = traineeMasterViewModel.Certification3No;
            TraineeMasterData.Certification3Date = traineeMasterViewModel.Certification3Date;
            TraineeMasterData.Certification3From = traineeMasterViewModel.Certification3From;
            TraineeMasterData.Certification3To = traineeMasterViewModel.Certification3To;

            return TraineeMasterData;

        }

        
    }
}
