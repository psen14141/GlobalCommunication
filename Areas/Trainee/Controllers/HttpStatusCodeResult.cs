using Microsoft.AspNetCore.Mvc;

namespace GloableCommunication.Areas.Trainee.Controllers
{
    internal class HttpStatusCodeResult : ActionResult
    {
        private object oK;

        public HttpStatusCodeResult(object oK)
        {
            this.oK = oK;
        }
    }
}