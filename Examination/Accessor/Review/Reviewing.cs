using Examination.Models;
using Examination.Models.Exam;
using Examination.Models.Examiner;
using Examination.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examination.Accessor.Review { 


	public class Reviewing {
		
		public IList<ExamModel> GetAllExaminerExam(string examinerId) {
			using (var db = HibernateSession.GetCurrentSession()) {
				using (var tx = db.BeginTransaction()) {
					var examiner = db.Get<ExaminerModel>(examinerId);
					var exams = examiner.exam.ToList();
					for(var i = 0; i < exams.Count; i++) {
						var question = db.Get<QuestionsModel>(exams[i].QuestionsModel_id);
						exams[i].ItemNo = question.ItemNo;
						exams[i].Question = question.Question;
					}
					return exams.OrderBy(x=>x.ItemNo).ToList();
					//return db.QueryOver<ExamModel>()
					//	.Where(x=>x.examiner)
					//	.List();
				}
			}
		}

		public void UpdateReview(ExamModel exam) {
			using (var db = HibernateSession.GetCurrentSession()) {
				using (var tx = db.BeginTransaction()) {
					var exm = db.Get<ExamModel>(exam.Id);
					exm.IsCorrect = exam.IsCorrect;
					exm.Remarks = exam.Remarks;
					exm.AlreadyReview = exam.AlreadyReview;
					db.SaveOrUpdate(exm);
					tx.Commit();
					db.Flush();
				}
			}
		}
	}
}