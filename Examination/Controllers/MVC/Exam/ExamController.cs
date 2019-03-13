using Examination.Accessor.Quetionaire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Examination.Utilities;

namespace Examination.Controllers.MVC.Exam
{
    public class ExamController : Controller
    {
        // GET: Exam
        public ActionResult Index(string Id)
        {
			ViewData["Id"] = Id;
			ViewData["ApiServer"] =Config.GetApiServerURL();
			var ques = new Questions();
			var questList=ques.GetAllQuestion();
			ViewData["questions"] = questList;
			return View();
        }
		public ActionResult EndExam(string Id) {
			return View();
		}
	}
}