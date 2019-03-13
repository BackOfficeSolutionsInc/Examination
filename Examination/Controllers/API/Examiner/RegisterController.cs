using Examination.Models.Examiner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Examination.Accessor.Examiner;
using System.Globalization;

namespace Examination.Controllers.API.Examiner {
	public class RegisterController : ApiController {
		// GET api/<controller>
		public IEnumerable<string> Get() {
			return new string[] { "value1", "value2" };
		}

		// GET api/<controller>/5
		public string Get(int id) {
			return "value";
		}

		// POST api/<controller>
		public String Post(ExaminerModel value) {
			CultureInfo culture = new CultureInfo("en-US");
			value.Birthday = DateTime.Parse(value.bday, culture);
			var reg = new ExaminerModel() {
				FirstName = value.FirstName,
				Lastname = value.Lastname,
				Middlename = value.Middlename,
				Birthday = value.Birthday,
				Address = value.Address
			};
			Examiners exam = new Examiners();
			exam.CreateExaminer(reg);
			return reg.Id;
		}

		// PUT api/<controller>/5
		public void Put(int id, [FromBody]string value) {
		}

		// DELETE api/<controller>/5
		public void Delete(int id) {
		}
	}
}