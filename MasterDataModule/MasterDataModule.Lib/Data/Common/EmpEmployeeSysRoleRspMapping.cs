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

namespace TuevSued.V1.IT.MasterDataModule.Lib.Data.Common
{
        /// <summary>
        /// Database mapping for <see cref="EmpEmployeeSysRoleRsp"/> to table EMP_EMPLOYEE_SYS_ROLE_RSP
        /// </summary>
        internal sealed class EmpEmployeeSysRoleRspMapping : EntityTypeConfiguration<EmpEmployeeSysRoleRsp>
        {
    	    public static readonly EmpEmployeeSysRoleRspMapping Instance = new EmpEmployeeSysRoleRspMapping();
    	    /// <summary>
            /// Instance constructor
            /// </summary>
            private EmpEmployeeSysRoleRspMapping()
            {
                // Primary Key
                this.HasKey(t => t.Id);
    
                // Properties
                this.Property(t => t.Id)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    
                this.Property(t => t.CreateDate)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
    
                this.Property(t => t.Source)
                    .HasMaxLength(4);
    
                // Table & Column Mappings
                this.ToTable("EMP_EMPLOYEE_SYS_ROLE_RSP", "DBO");
                this.Property(t => t.Id).HasColumnName(EmpEmployeeSysRoleRsp.Fields.Id);
                this.Property(t => t.EmpEmployeeId).HasColumnName(EmpEmployeeSysRoleRsp.Fields.EmpEmployeeId);
                this.Property(t => t.SysRoleId).HasColumnName(EmpEmployeeSysRoleRsp.Fields.SysRoleId);
                this.Property(t => t.CreateDate).HasColumnName(EmpEmployeeSysRoleRsp.Fields.CreateDate);
                this.Property(t => t.ChangeDate).HasColumnName(EmpEmployeeSysRoleRsp.Fields.ChangeDate);
                this.Property(t => t.DeleteDate).HasColumnName(EmpEmployeeSysRoleRsp.Fields.DeleteDate);
                this.Property(t => t.OwnerOrgId).HasColumnName(EmpEmployeeSysRoleRsp.Fields.OwnerOrgId);
                this.Property(t => t.VisibilityOrgId).HasColumnName(EmpEmployeeSysRoleRsp.Fields.VisibilityOrgId);
                this.Property(t => t.CreateEmployeeId).HasColumnName(EmpEmployeeSysRoleRsp.Fields.CreateEmployeeId);
                this.Property(t => t.ChangeEmployeeId).HasColumnName(EmpEmployeeSysRoleRsp.Fields.ChangeEmployeeId);
                this.Property(t => t.Source).HasColumnName(EmpEmployeeSysRoleRsp.Fields.Source);
                this.Property(t => t.FromDate).HasColumnName(EmpEmployeeSysRoleRsp.Fields.FromDate);
                this.Property(t => t.ToDate).HasColumnName(EmpEmployeeSysRoleRsp.Fields.ToDate);
    
    
            }
        }
}
