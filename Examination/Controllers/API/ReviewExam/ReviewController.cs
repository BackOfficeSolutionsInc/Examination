using Examination.Accessor.Review;
using Examination.Models.Exam;
using Examination.Models.Examiner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Examination.Controllers.API.ReviewExam {
	public class ReviewController : ApiController {
		// GET api/<controller>
		public IEnumerable<string> Get() {
			return new string[] { "value1", "value2" };
		}

		// GET api/<controller>/5
		public string Get(int id) {
			return "value";
		}

		// POST api/<controller>
		public IList<ExamModel> Post(ExaminerModel value) {
			Reviewing rv = new Reviewing();
			var exams = rv.GetAllExaminerExam(value.Id);
			return exams;
		}

		// PUT api/<controller>/5
		public void Put(int id, [FromBody]string value) {
		}

		// DELETE api/<controller>/5
		public void Delete(int id) {
		}
	}
}