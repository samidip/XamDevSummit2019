// <auto-generated> - Template:ModelsBackedByDtoInterface, Version:1.1, Id:4d03f2c7-de27-4aae-a267-cad747c9606a
using System;
using System.Collections.Generic;

namespace MSC.ConferenceMate.Model.CM.Interface
{
	public partial interface ILookupList
	{
		string CreatedBy { get; }
		System.DateTime CreatedUtcDate { get; }
		string CustomJson { get; }
		int DataVersion { get; }
		string Description { get; }
		int DisplayPriority { get; }
		string DisplayText { get; }
		string ForeignKeyTableName { get; }
		int ForeignKeyTablePkId { get; }
		bool IsDeleted { get; }
		int LanguageTypeId { get; }
		int LookupListId { get; }
		string ModifiedBy { get; }
		System.DateTime ModifiedUtcDate { get; }

		ILanguageType LanguageType { get; }


	}
}