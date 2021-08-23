using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GloableCommunication.Areas.Trainee.Controllers
{
    [Area("Trainee")]
    public class PassportRegistrationController : Controller
    {
        public IActionResult Index()
        {
            List<DbModels.TraineeHistory> traineeHistories = new List<DbModels.TraineeHistory>();
            using (DbModels.GCommunicationContext db = new DbModels.GCommunicationContext())
            {
                traineeHistories = db.TraineeHistories.ToList();
            }
            return View(traineeHistories);
        }
    }
}
