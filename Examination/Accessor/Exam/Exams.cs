using Examination.Models;
using Examination.Models.Exam;
using Examination.Models.Examiner;
using Examination.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examination.Accessor.Exam {
	public class Exams {
		public void AddExaminer(ExamModel exam) {
			using (var db = HibernateSession.GetCurrentSession()) {
				using (var tx = db.BeginTransaction()) {
					var examiner = db.Get<ExaminerModel>(exam.ExaminerModel_id);
					examiner.exam.Add(exam);

					db.SaveOrUpdate(examiner);
					tx.Commit();
					db.Flush();
				}
			}
		}
		public void AddQuestion(ExamModel exam) {
			using (var db = HibernateSession.GetCurrentSession()) {
				using (var tx = db.BeginTransaction()) {
					var question = db.Get<QuestionsModel>(exam.QuestionsModel_id);
					question.exam.Add(exam);

					db.SaveOrUpdate(question);
					tx.Commit();
					db.Flush();
				}
			}
		}
	}
}