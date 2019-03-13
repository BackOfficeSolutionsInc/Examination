using Examination.Models.Examiner;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examination.Models.Exam {
	public class ExamModel {
		public virtual string Id { get; set; }
		public virtual string ExaminerAnswer { get; set; }
		public virtual string Remarks { get; set; }
		public ExamModel() {

			CreateTime = DateTime.UtcNow;
		}

		public virtual DateTime CreateTime { get; set; }
		public virtual DateTime? DeleteTime { get; set; }
		public virtual bool? IsCorrect { get; set; }
		public virtual bool? AlreadyReview { get; set; }
		public virtual string ExaminerModel_id { get; set; }
		public virtual string QuestionsModel_id { get; set; }
		public virtual string Question { get; set; }
		public virtual int ItemNo { get; set; }

		public class ExamModelMap : ClassMap<ExamModel> {
			public ExamModelMap() {
				Id(x => x.Id).CustomType(typeof(string)).GeneratedBy.Custom(typeof(GuidStringGenerator)).Length(36);
				Map(x => x.ExaminerAnswer);
				Map(x => x.CreateTime);
				Map(x => x.DeleteTime);
				Map(x => x.IsCorrect);
				Map(x => x.ExaminerModel_id);
				Map(x => x.QuestionsModel_id);
				//Reference(x => x.question).Cascade.SaveUpdate();
				//References(x => x.question).Cascade.SaveUpdate();
				//References(x => x.examiner).Cascade.SaveUpdate();   
				Map(x => x.Remarks);
				Map(x => x.AlreadyReview);
			}
		}
	}
}