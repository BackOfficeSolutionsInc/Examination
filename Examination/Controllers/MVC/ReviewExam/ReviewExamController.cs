using Examination.Accessor.Examiner;
using Examination.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Examination.Controllers.MVC.ReviewExam
{
    public class ReviewExamController : Controller
    {
        // GET: ReviewExam
        public ActionResult Index()
        {
			var examiners = new Examiners();
			var examinerList = examiners.GetAllExaminer();
			ViewData["ApiServer"] = Config.GetApiServerURL();
			return View(examinerList);
        }

    }
}