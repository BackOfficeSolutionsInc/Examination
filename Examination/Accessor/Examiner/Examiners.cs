using Examination.Models.Examiner;
using Examination.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examination.Accessor.Examiner {
	public class Examiners {
		public void CreateExaminer(ExaminerModel examinerModel) {
			using (var s = HibernateSession.GetCurrentSession()) {
				using (var tx = s.BeginTransaction()) {
					s.Save(examinerModel);
					tx.Commit();
					s.Flush();
				}
			}
		}
		public IList<ExaminerModel> GetAllExaminer() {
			using (var db = HibernateSession.GetCurrentSession()) {
				using (var tx = db.BeginTransaction()) {
					return db.QueryOver<ExaminerModel>().List();
				}
			}
		}
	}
}