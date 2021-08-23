using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GloableCommunication.DbModels;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Internal;
using GloableCommunication.Areas.MasterMaintainance.Models.ViewModels;
using GloableCommunication.ProPlatform.Security;
namespace GloableCommunication.Areas.MasterMaintainance.Controllers
{
    [Area("MasterMaintainance")]
    public class UserIdController : Controller
    {
        public IActionResult Index()
        {

            List<GloableCommunication.DbModels.User> user = new List<GloableCommunication.DbModels.User>();
            using (GCommunicationContext db = new GCommunicationContext())
            {
                user = db.Users.Where(w => w.IsDeleteUser == false).ToList();

            }


            return View(user);
        }

        public IActionResult AddorEditView(int Id)
        {
            UserIdViewModel useridViewModel = new UserIdViewModel();
            using (GCommunicationContext db = new GCommunicationContext())
            {
                if (Id != 0)
                {
                    GloableCommunication.DbModels.User user = db.Users.Where(w => w.UserId == Id).First();

                    useridViewModel.UserId = user.UserId;
                    useridViewModel.UserCode = user.UserCode.Trim();
                    useridViewModel.Password = user.Password.Trim();
                    if (user.Email == null) { useridViewModel.Email = null; }
                    else { useridViewModel.Email = user.Email.Trim(); }
                    useridViewModel.InsertDateTime = user.InsertDateTime;
                    useridViewModel.UpdateDateTime = user.UpdateDateTime;
                }
                else
                {
                    useridViewModel.InsertDateTime = DateTime.Now;
                    //useridViewModel.UpdateDateTime = DateTime.Now;
                }
                useridViewModel.Users = db.Users.ToList();

            }
            return View(useridViewModel);
        }



        public ActionResult SaveChanges(DbModels.User formuser)
        {
            using (GCommunicationContext db = new GCommunicationContext())
            {
                if (formuser.UserId == 0)
                {

                    formuser.Password = ProEncryptor.ToMD5Hash(formuser.Password);
                    formuser.InsertDateTime = DateTime.Today;
                    formuser.IsDeleteUser = false;
                    db.Users.Add(formuser);

                }
                else
                {
                    DbModels.User dbUser = db.Users.Where(w => w.UserId == formuser.UserId).FirstOrDefault();
                    dbUser.UserId = formuser.UserId;
                    dbUser.UserCode = formuser.UserCode;
                    dbUser.Email = formuser.Email;
                    dbUser.UpdateDateTime = DateTime.Today;

                }
                db.SaveChanges();
            }
            return Redirect("/MasterMaintainance/Country/Index");
        }


        public IActionResult Delete(int Id)
        {
            using (GCommunicationContext db = new GCommunicationContext())
            {
                DbModels.User user = db.Users.Where(w => w.UserId == Id).First();
                user.IsDeleteUser = true;
                db.SaveChanges();
            }

            return Redirect("/MasterMaintainance/UserId/Index");
        }


        //Detail view
        public IActionResult DetailView(int Id)
        {

            UserIdViewModel useridViewModel = new UserIdViewModel();
            using (GCommunicationContext db = new GCommunicationContext())

            {

                GloableCommunication.DbModels.User user = db.Users.Where(w => w.UserId == Id).First();
                useridViewModel.UserId = user.UserId;
                useridViewModel.UserCode = user.UserCode;
                useridViewModel.Email = user.Email;
                useridViewModel.InsertDateTime = user.InsertDateTime;
                useridViewModel.UpdateDateTime = user.UpdateDateTime;

            }
                return View(useridViewModel);
        }
    }
}
