using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using GloableCommunication.Areas.Trainee.Models.ViewModel;
using GloableCommunication.DbModels;
using GloableCommunication.ProPlatform.FileManager;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Storage;

namespace GloableCommunication.Areas.Trainee.Controllers
{
    public class AddTraaneeData
    {
        GCommunicationContext db = null;
        IDbContextTransaction transaction = null;
        HttpContext context;

        public AddTraaneeData(HttpContext context_)
        {
            context = context_;
            db = new GCommunicationContext();
        }

         ~AddTraaneeData()
        {
            removeObject();
        }

        private void removeObject()
        {
            if(db != null)
            {
                db.Dispose();
                db = null;
            }
            if(transaction != null )
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


                traineeMasterData.TraineeHistories.Add(traineeHistoryData);
               db.TraineeMasters.Add(traineeMasterData);

                //profile.Users.Add(user);

                //db.Profiles.Add(profile);
                db.SaveChanges();
                transaction.Commit();
            }
            catch(Exception e)
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
            traineeMasterData.InsertDate = traineeMasterViewModel.InsertDate;
            traineeMasterData.WorkId = traineeMasterViewModel.WorkId;

            var Traineneeocuupation = db.Works.Where(w => w.WorkId == traineeMasterViewModel.WorkId).Join
                  (db.Occupations,
                      tmaster => tmaster.OccupationId,
                      occu => occu.OccupationId,
                      (tmaster, occu) => new { Work = tmaster, Occupation = occu }
                  ).FirstOrDefault();


            traineeMasterData.OccupationId = Traineneeocuupation.Occupation.OccupationId;
            traineeMasterData.SendingCompanyId = traineeMasterViewModel.SendingCompanyId;
            traineeMasterData.AcceptingCompanyId = traineeMasterViewModel.AcceptingCompanyId;
            traineeMasterData.Memo1 = traineeMasterViewModel.Memo1;
            traineeMasterData.Memo2 = traineeMasterViewModel.Memo2;
            traineeMasterData.Memo3 = traineeMasterViewModel.Memo3;
            traineeMasterData.EntranceDate = traineeMasterViewModel.EntranceDate;



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
            traineeHistoryData.RegistrationNo = traineeMasterViewModel.RegistrationNo;
            traineeHistoryData.RegistrationLimit = traineeMasterViewModel.RegistrationLimit;
            traineeHistoryData.InsertDate = traineeMasterViewModel.InsertDate;


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
            TraineeMasterData.EntranceStatus = traineeMasterViewModel.EntranceStatus;
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
                        string path = "DataFolder/"  + DateTime.UtcNow.ToString("yyyyMMddHHmmss") + "-" + traineeMasterViewModel.PassportImg.FileName;

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
                        string path = "DataFolder/ " + DateTime.UtcNow.ToString("yyyyMMddHHmmss") + " - " + traineeMasterViewModel.TraineevisaImg1.FileName;

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
                        string path = "DataFolder/" + DateTime.UtcNow.ToString("yyyyMMddHHmmss")+ "-" + traineeMasterViewModel.RegistrationImg2.FileName;

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
