using Examination.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Examination.Controllers.MVC.Examiner
{
    public class ExaminerController : Controller
    {
        // GET: Examiner
        public ActionResult Information()
        {
			ViewData["ApiServer"] = Config.GetApiServerURL();
			return View();
        }
    }
}