using Examination.Models.Exam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Examination.Accessor.Exam;

namespace Examination.Controllers.API.Exams {
	public class ExamController : ApiController {
		// GET api/<controller>
		public IEnumerable<string> Get() {
			return new string[] { "value1", "value2" };
		}

		// GET api/<controller>/5
		public string Get(int id) {
			return "value";
		}

		// POST api/<controller>
		public void Post(IList<ExamModel> value) {
			var exam = new List<ExamModel>();
			Examination.Accessor.Exam.Exams exams = new Examination.Accessor.Exam.Exams();
			for(var i = 0; i < value.Count; i++) {
				exam.Add(new ExamModel() {
					ExaminerAnswer = value[i].ExaminerAnswer,
					ExaminerModel_id = value[i].ExaminerModel_id,
					QuestionsModel_id = value[i].QuestionsModel_id
				});
			}
			for(var i = 0; i < exam.Count; i++) {
				exams.AddExaminer(exam[i]);
				exams.AddQuestion(exam[i]);
			}
		}

		// PUT api/<controller>/5
		public void Put(int id, [FromBody]string value) {
		}

		// DELETE api/<controller>/5
		public void Delete(int id) {
		}
	}
}