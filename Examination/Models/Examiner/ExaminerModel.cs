using Examination.Models.Enums;
using Examination.Models.Exam;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examination.Models.Examiner {
	
		public class ExaminerModel {
			public virtual string Id { get; set; }
			public virtual string Lastname { get; set; }
			public virtual string FirstName { get; set; }
			public virtual string Middlename { get; set; }
			public virtual DateTime Birthday { get; set; }
			public virtual string bday { get; set; }
			public virtual GenderType? Gender { get; set; }
			public virtual string Address { get; set; }
			public virtual string Email { get; set; }
			public virtual ICollection<ExamModel> exam { get; set; }
		public ExaminerModel() {

				CreateTime = DateTime.UtcNow;
			}
		public virtual String Name() {
			return ((FirstName ?? "").Trim() + " " + (Lastname ?? "").Trim()).Trim();
		}

		public virtual DateTime CreateTime { get; set; }
			public virtual DateTime? DeleteTime { get; set; } 
			public class ExaminerModelMap : ClassMap<ExaminerModel> {
				public ExaminerModelMap() {
					Id(x => x.Id).CustomType(typeof(string)).GeneratedBy.Custom(typeof(GuidStringGenerator)).Length(36);
					Map(x => x.Lastname);
					Map(x => x.FirstName);
					Map(x => x.Middlename);
					Map(x => x.Birthday);
					Map(x => x.Address).CustomType("StringClob").CustomSqlType("nvarchar(max)");
					Map(x => x.Gender);
					Map(x => x.CreateTime);
					Map(x => x.DeleteTime);
					Map(x => x.Email);
				   HasMany(x => x.exam).Cascade.SaveUpdate();

			}
		}




		}

	}
