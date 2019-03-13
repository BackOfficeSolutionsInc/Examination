using Examination.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Examination.Controllers.MVC.Qustionaire
{
    public class QuestionController : Controller
    {
        // GET: Question
        public ActionResult Index()
        {
            return View();
        }
		public ActionResult CreateQuestion() {
			ViewData["ApiServer"] = Config.GetApiServerURL();
			return View();
		}
	}
}