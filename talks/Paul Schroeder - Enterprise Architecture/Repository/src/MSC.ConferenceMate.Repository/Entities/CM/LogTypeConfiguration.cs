// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.7
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace MSC.ConferenceMate.Repository.Entities.CM
{

    // LogType
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.33.0.0")]
    public partial class LogTypeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<LogType>
    {
        public LogTypeConfiguration()
            : this("dbo")
        {
        }

        public LogTypeConfiguration(string schema)
        {
            ToTable("LogType", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Type).HasColumnName(@"Type").HasColumnType("nvarchar").IsRequired().HasMaxLength(150);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>