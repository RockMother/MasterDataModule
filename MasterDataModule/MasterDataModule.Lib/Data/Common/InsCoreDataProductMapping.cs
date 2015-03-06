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
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.Common;
namespace TuevSued.V1.IT.FE.MasterDataModule.Lib.Data
{
        /// <summary>
        /// Database mapping for <see cref="InsCoreDataProduct"/> to table INS_CORE_DATA_PRODUCT
        /// </summary>
        internal sealed class InsCoreDataProductMapping : EntityTypeConfiguration<InsCoreDataProduct>
        {
    	    public static readonly InsCoreDataProductMapping Instance = new InsCoreDataProductMapping();
    	    /// <summary>
            /// Instance constructor
            /// </summary>
            private InsCoreDataProductMapping()
            {
                // Primary Key
                this.HasKey(t => t.Id);
    
                // Properties
                this.Property(t => t.Id)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    
                this.Property(t => t.ProductNumber)
                    .IsRequired()
                    .HasMaxLength(50);
    
                this.Property(t => t.CreateDate)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    
                this.Property(t => t.Source)
                    .HasMaxLength(4);
    
                this.Property(t => t.OldProductNumber)
                    .HasMaxLength(50);
    
                // Table & Column Mappings
                this.ToTable("INS_CORE_DATA_PRODUCT", "DBO");
                this.Property(t => t.Id).HasColumnName(InsCoreDataProduct.Fields.Id);
                this.Property(t => t.ProductNumber).HasColumnName(InsCoreDataProduct.Fields.ProductNumber);
                this.Property(t => t.IsNextInspectionProduct).HasColumnName(InsCoreDataProduct.Fields.IsNextInspectionProduct);
                this.Property(t => t.IsProvisionCostMayBeCalculated).HasColumnName(InsCoreDataProduct.Fields.IsProvisionCostMayBeCalculated);
                this.Property(t => t.PriceReportRequired).HasColumnName(InsCoreDataProduct.Fields.PriceReportRequired);
                this.Property(t => t.InsProductTypeId).HasColumnName(InsCoreDataProduct.Fields.InsProductTypeId);
                this.Property(t => t.InsProductObjectClassId).HasColumnName(InsCoreDataProduct.Fields.InsProductObjectClassId);
                this.Property(t => t.InsProductObjectTypeId).HasColumnName(InsCoreDataProduct.Fields.InsProductObjectTypeId);
                this.Property(t => t.InsProductMaterialGroupId).HasColumnName(InsCoreDataProduct.Fields.InsProductMaterialGroupId);
                this.Property(t => t.InsProductClassId).HasColumnName(InsCoreDataProduct.Fields.InsProductClassId);
                this.Property(t => t.InsCoreDataProductGroupId).HasColumnName(InsCoreDataProduct.Fields.InsCoreDataProductGroupId);
                this.Property(t => t.IsIngener).HasColumnName(InsCoreDataProduct.Fields.IsIngener);
                this.Property(t => t.IsProductive).HasColumnName(InsCoreDataProduct.Fields.IsProductive);
                this.Property(t => t.IsKmGeld).HasColumnName(InsCoreDataProduct.Fields.IsKmGeld);
                this.Property(t => t.IsOtherMaterial).HasColumnName(InsCoreDataProduct.Fields.IsOtherMaterial);
                this.Property(t => t.IsTrip).HasColumnName(InsCoreDataProduct.Fields.IsTrip);
                this.Property(t => t.CreateDate).HasColumnName(InsCoreDataProduct.Fields.CreateDate);
                this.Property(t => t.ChangeDate).HasColumnName(InsCoreDataProduct.Fields.ChangeDate);
                this.Property(t => t.DeleteDate).HasColumnName(InsCoreDataProduct.Fields.DeleteDate);
                this.Property(t => t.OwnerOrgId).HasColumnName(InsCoreDataProduct.Fields.OwnerOrgId);
                this.Property(t => t.VisibilityOrgId).HasColumnName(InsCoreDataProduct.Fields.VisibilityOrgId);
                this.Property(t => t.CreateEmployeeId).HasColumnName(InsCoreDataProduct.Fields.CreateEmployeeId);
                this.Property(t => t.ChangeEmployeeId).HasColumnName(InsCoreDataProduct.Fields.ChangeEmployeeId);
                this.Property(t => t.Source).HasColumnName(InsCoreDataProduct.Fields.Source);
                this.Property(t => t.FromDate).HasColumnName(InsCoreDataProduct.Fields.FromDate);
                this.Property(t => t.ToDate).HasColumnName(InsCoreDataProduct.Fields.ToDate);
                this.Property(t => t.ReusageType).HasColumnName(InsCoreDataProduct.Fields.ReusageType);
                this.Property(t => t.InsTaxCodeId).HasColumnName(InsCoreDataProduct.Fields.InsTaxCodeId);
                this.Property(t => t.OldProductNumber).HasColumnName(InsCoreDataProduct.Fields.OldProductNumber);
    
    
            }
        }
}
