//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using Apps.Models;
using System;
namespace Apps.Models.DEF
{
	public class Virtual_DEF_TestJobsDetailItemModel
	{
			public virtual string VerCode { get; set; }
			public virtual string Code { get; set; }
			public virtual string Name { get; set; }
			public virtual string Description { get; set; }
			public virtual Nullable<bool> Result { get; set; }
			public virtual Nullable<int> Sort { get; set; }
			public virtual Nullable<int> ExSort { get; set; }
			public virtual bool Lock { get; set; }
			public virtual string Developer { get; set; }
			public virtual string Tester { get; set; }
			public virtual Nullable<System.DateTime> FinDt { get; set; }
			public virtual Nullable<bool> TestRequestFlag { get; set; }
			public virtual Nullable<bool> DevFinFlag { get; set; }
		}
}
