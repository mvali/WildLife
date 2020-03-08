using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;

namespace DeveloperWeb.Controllers
{
    public class ContactUsController : Controller
    {
        // GET: ContactUs
        public ActionResult Index()
        {
            return PartialView();
        }

        public ActionResult ContactResult()
        {
            return PartialView();
        }

        public ActionResult ContactAjax()
        {
            var contact = new Models.Contact();
            /*contact.Message = Resources.ContactUs.Contact.MessagePlaceholder;
            contact.Name = Resources.ContactUs.Contact.NamePlaceholder;
            contact.Phone= Resources.ContactUs.Contact.PhonePlaceholder;
            contact.Email = Resources.ContactUs.Contact.EmailPlaceholder;
            */
            return PartialView(contact);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ContactAjax(Models.Contact task)
        {
            if (ModelState.IsValid)
            {
                var data1 = task.Name + ", " + task.Email;

                var bRet = task.SendEmail();
                TempData["Status"] = "emailSent";

                return PartialView("contactResult", task);
            }
            else
            {
                TempData["Status"] = "Message err from controller";
                return PartialView("ContactAjax", task);
                //return PartialView("contactResult", task);
            }
        }

    }
}