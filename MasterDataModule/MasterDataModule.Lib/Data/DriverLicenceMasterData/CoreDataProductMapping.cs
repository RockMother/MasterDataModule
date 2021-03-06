//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.DriverLicenceMasterData;

namespace TuevSued.V1.IT.FE.MasterDataModule.Lib.Data
{
        /// <summary>
        /// Database mapping for <see cref="CoreDataProduct"/> to table DRL_CORE_DATA_PRODUCT
        /// </summary>
        internal sealed class CoreDataProductMapping : EntityTypeConfiguration<CoreDataProduct>
        {
    	    public static readonly CoreDataProductMapping Instance = new CoreDataProductMapping();
    	    /// <summary>
            /// Instance constructor
            /// </summary>
            private CoreDataProductMapping()
            {
                // Primary Key
                this.HasKey(t => t.Id);
    
                // Properties
                this.Property(t => t.Id)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    
                this.Property(t => t.CreateDate)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    
                this.Property(t => t.FeProductNumber)
                    .IsRequired()
                    .IsFixedLength()
                    .HasMaxLength(10);
    
                // Table & Column Mappings
                this.ToTable("DRL_CORE_DATA_PRODUCT", "DATA");
                this.Property(t => t.Id).HasColumnName(CoreDataProduct.Fields.Id);
                this.Property(t => t.InsCoreDataProductId).HasColumnName(CoreDataProduct.Fields.InsCoreDataProductId);
                this.Property(t => t.PointAmount).HasColumnName(CoreDataProduct.Fields.PointAmount);
                this.Property(t => t.MinAge).HasColumnName(CoreDataProduct.Fields.MinAge);
                this.Property(t => t.MaxAge).HasColumnName(CoreDataProduct.Fields.MaxAge);
                this.Property(t => t.ExamType).HasColumnName(CoreDataProduct.Fields.ExamType);
                this.Property(t => t.PriorTimeInMonths).HasColumnName(CoreDataProduct.Fields.PriorTimeInMonths);
                this.Property(t => t.ExpirationInMonth).HasColumnName(CoreDataProduct.Fields.ExpirationInMonth);
                this.Property(t => t.RepeatTimeInDays).HasColumnName(CoreDataProduct.Fields.RepeatTimeInDays);
                this.Property(t => t.TrainingCertFlag).HasColumnName(CoreDataProduct.Fields.TrainingCertFlag);
                this.Property(t => t.ResultFlag).HasColumnName(CoreDataProduct.Fields.ResultFlag);
                this.Property(t => t.MultiplyFlag).HasColumnName(CoreDataProduct.Fields.MultiplyFlag);
                this.Property(t => t.CreateDate).HasColumnName(CoreDataProduct.Fields.CreateDate);
                this.Property(t => t.ChangeDate).HasColumnName(CoreDataProduct.Fields.ChangeDate);
                this.Property(t => t.OwnerOrgId).HasColumnName(CoreDataProduct.Fields.OwnerOrgId);
                this.Property(t => t.VisibilityOrgId).HasColumnName(CoreDataProduct.Fields.VisibilityOrgId);
                this.Property(t => t.CreateEmployeeId).HasColumnName(CoreDataProduct.Fields.CreateEmployeeId);
                this.Property(t => t.ChangeEmployeeId).HasColumnName(CoreDataProduct.Fields.ChangeEmployeeId);
                this.Property(t => t.FromDate).HasColumnName(CoreDataProduct.Fields.FromDate);
                this.Property(t => t.ToDate).HasColumnName(CoreDataProduct.Fields.ToDate);
                this.Property(t => t.IsMofaPrint).HasColumnName(CoreDataProduct.Fields.IsMofaPrint);
                this.Property(t => t.IsAdditionalProduct).HasColumnName(CoreDataProduct.Fields.IsAdditionalProduct);
                this.Property(t => t.IsPrepaymentRequired).HasColumnName(CoreDataProduct.Fields.IsPrepaymentRequired);
                this.Property(t => t.IsMandatory).HasColumnName(CoreDataProduct.Fields.IsMandatory);
                this.Property(t => t.FeProductNumber).HasColumnName(CoreDataProduct.Fields.FeProductNumber);
                this.Property(t => t.RepeatTimeInDaysReduced).HasColumnName(CoreDataProduct.Fields.RepeatTimeInDaysReduced);
                this.Property(t => t.DeleteDate).HasColumnName(CoreDataProduct.Fields.DeleteDate);
    
                //// Relationships
                //this.HasRequired(t => t.InsCoreDataProduct)
                //    .WithMany(t => t.CoreDataProducts)
                //    .HasForeignKey(d => d.InsCoreDataProductId);
    
    
            }
        }
}
