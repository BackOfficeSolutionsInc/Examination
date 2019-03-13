using Examination.Models;
using Examination.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examination.Accessor.Quetionaire {
	public class Questions {
		public void CreateQuestion(QuestionsModel questionsModel) {
			using (var s = HibernateSession.GetCurrentSession()) {
				using (var tx = s.BeginTransaction()) {
					s.Save(questionsModel);
					tx.Commit();
					s.Flush();
				}
			}
		}

		public IList<QuestionsModel> GetAllQuestion() {
			using (var db = HibernateSession.GetCurrentSession()) {
				using (var tx = db.BeginTransaction()) {
					return db.QueryOver<QuestionsModel>().OrderBy(x=>x.ItemNo).Asc.List();
				}
			}
		}
	}
}