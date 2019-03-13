using System.Diagnostics;
using FluentNHibernate.Mapping;
using Examination.Models.Enums;
using System;
//using Microsoft.AspNet.Identity.EntityFramework;
//using Examination.Models.UserModels;
using System.Collections.Generic;
using Examination.Models.Exam;

namespace Examination.Models {
	
	public class QuestionsModel  {
		public virtual string Id { get; set; }
		public virtual int ItemNo { get; set; }
		public virtual string Question { get; set; }
		public virtual string Answers { get; set; }
		public QuestionsModel() {
			
			CreateTime = DateTime.UtcNow;
		}

		public virtual DateTime CreateTime { get; set; }
		public virtual DateTime? DeleteTime { get; set; }
		public virtual ICollection<ExamModel> exam { get; set; }
		public class QuestionsModelMap : ClassMap<QuestionsModel> {
			public QuestionsModelMap() {
				Id(x => x.Id).CustomType(typeof(string)).GeneratedBy.Custom(typeof(GuidStringGenerator)).Length(36);
				Map(x => x.ItemNo).Index("ItemNo_IDX").Length(400).UniqueKey("uniq");
				Map(x => x.Question).CustomType("StringClob").CustomSqlType("nvarchar(max)");
				Map(x => x.Answers).CustomType("StringClob").CustomSqlType("nvarchar(max)");
				Map(x => x.CreateTime);
				Map(x => x.DeleteTime);
				HasMany(x => x.exam).Cascade.SaveUpdate();
			}
		}



		
	}

}
