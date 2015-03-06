//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.Common
{
    /// <summary>
    /// Entity from table EMP_EMPLOYEE_SYS_ROLE_RSP. Imported from AsPro: Represents system roles assigned to employees  
    /// </summary>
    public partial  class EmpEmployeeSysRoleRsp: IHasId<int>, ICommonSystemFields, ISystemFields, IRemovable
    {
    
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "EMP_EMPLOYEE_SYS_ROLE_RSP";
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'ID' for property <see cref="EmpEmployeeSysRoleRsp.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// Column name 'EMP_EMPLOYEE_ID' for property <see cref="EmpEmployeeSysRoleRsp.EmpEmployeeId"/>
            /// </summary>
            public static readonly string EmpEmployeeId = "EMP_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'SYS_ROLE_ID' for property <see cref="EmpEmployeeSysRoleRsp.SysRoleId"/>
            /// </summary>
            public static readonly string SysRoleId = "SYS_ROLE_ID";
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="EmpEmployeeSysRoleRsp.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="EmpEmployeeSysRoleRsp.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'DELETE_DATE' for property <see cref="EmpEmployeeSysRoleRsp.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
            /// <summary>
            /// Column name 'OWNER_ORG_ID' for property <see cref="EmpEmployeeSysRoleRsp.OwnerOrgId"/>
            /// </summary>
            public static readonly string OwnerOrgId = "OWNER_ORG_ID";
            /// <summary>
            /// Column name 'VISIBILITY_ORG_ID' for property <see cref="EmpEmployeeSysRoleRsp.VisibilityOrgId"/>
            /// </summary>
            public static readonly string VisibilityOrgId = "VISIBILITY_ORG_ID";
            /// <summary>
            /// Column name 'CREATE_EMPLOYEE_ID' for property <see cref="EmpEmployeeSysRoleRsp.CreateEmployeeId"/>
            /// </summary>
            public static readonly string CreateEmployeeId = "CREATE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'CHANGE_EMPLOYEE_ID' for property <see cref="EmpEmployeeSysRoleRsp.ChangeEmployeeId"/>
            /// </summary>
            public static readonly string ChangeEmployeeId = "CHANGE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'SOURCE' for property <see cref="EmpEmployeeSysRoleRsp.Source"/>
            /// </summary>
            public static readonly string Source = "SOURCE";
            /// <summary>
            /// Column name 'FROM_DATE' for property <see cref="EmpEmployeeSysRoleRsp.FromDate"/>
            /// </summary>
            public static readonly string FromDate = "FROM_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="EmpEmployeeSysRoleRsp.ToDate"/>
            /// </summary>
            public static readonly string ToDate = "TO_DATE";
      
        }
        #endregion
        /// <summary>
        /// PK. Original table: EMP_EMPLOYEE_SYS_ROLE_RSP, Column: ID  
        /// </summary>
        public int Id {  get;  set; }
        /// <summary>
        /// The employee.. Original table: EMP_EMPLOYEE_SYS_ROLE_RSP, Column: EMP_EMPLOYEE_ID  
        /// </summary>
        public int EmpEmployeeId {  get;  set; }
        /// <summary>
        /// The role connected to employee.. Original table: EMP_EMPLOYEE_SYS_ROLE_RSP, Column: SYS_ROLE_ID  
        /// </summary>
        public int SysRoleId {  get;  set; }
        /// <summary>
        /// Create date. Original table: EMP_EMPLOYEE_SYS_ROLE_RSP, Column: CREATE_DATE  
        /// </summary>
        public System.DateTime CreateDate {  get;  set; }
        /// <summary>
        /// Change date. Original table: EMP_EMPLOYEE_SYS_ROLE_RSP, Column: CHANGE_DATE  
        /// </summary>
        public System.DateTime ChangeDate {  get;  set; }
        /// <summary>
        /// Entity create date 
        /// </summary>
        DateTime? ICommonSystemFields.CreateDate
        {
            get
            {
                return CreateDate;
            }
            set
            {
                if (value.HasValue) { CreateDate = value.Value; } else { throw new ArgumentNullException("value"); }
            }
        }
        /// <summary>
        /// Last changed date 
        /// </summary>
        DateTime? ICommonSystemFields.ChangeDate
        {
            get
            {
                return ChangeDate;
            }
            set
            {
                if (value.HasValue) { ChangeDate = value.Value; } else { throw new ArgumentNullException("value"); }
            }
        }    
        /// <summary>
        /// Delete date. Original table: EMP_EMPLOYEE_SYS_ROLE_RSP, Column: DELETE_DATE  
        /// </summary>
        public System.DateTime? DeleteDate {  get;  set; }
        /// <summary>
        /// Owner of record concerning organizational hierarchy. Original table: EMP_EMPLOYEE_SYS_ROLE_RSP, Column: OWNER_ORG_ID  
        /// </summary>
        public int? OwnerOrgId {  get;  set; }
        /// <summary>
        /// Visibility of record concerning organizational hierarchy. Original table: EMP_EMPLOYEE_SYS_ROLE_RSP, Column: VISIBILITY_ORG_ID  
        /// </summary>
        public int? VisibilityOrgId {  get;  set; }
        /// <summary>
        /// Employee who created record. Original table: EMP_EMPLOYEE_SYS_ROLE_RSP, Column: CREATE_EMPLOYEE_ID  
        /// </summary>
        public int? CreateEmployeeId {  get;  set; }
        /// <summary>
        /// Employee who changed record. Original table: EMP_EMPLOYEE_SYS_ROLE_RSP, Column: CHANGE_EMPLOYEE_ID  
        /// </summary>
        public int? ChangeEmployeeId {  get;  set; }
        /// <summary>
        /// Short name of source data. Original table: EMP_EMPLOYEE_SYS_ROLE_RSP, Column: SOURCE  
        /// </summary>
        public string Source {  get;  set; }
        /// <summary>
        /// Validity start date. Original table: EMP_EMPLOYEE_SYS_ROLE_RSP, Column: FROM_DATE  
        /// </summary>
        public System.DateTime FromDate {  get;  set; }
        /// <summary>
        /// Validity end date. Original table: EMP_EMPLOYEE_SYS_ROLE_RSP, Column: TO_DATE  
        /// </summary>
        public System.DateTime ToDate {  get;  set; }
        /// <summary>
        /// From date entity valid 
        /// </summary>
    	DateTime? ISystemFields.FromDate
    	{
    	    get { 
    		      return FromDate; 
    			}
    		set { 
    		      if(value.HasValue){FromDate = value.Value;} else{ throw new ArgumentNullException("value"); } 
    			}
    	}    
        /// <summary>
        /// To date entity valid 
        /// </summary>
    	DateTime? ISystemFields.ToDate
    	{
    	    get { 
    		      return ToDate; 
    			}
    		set { 
    		      if(value.HasValue){ToDate = value.Value;} else{ throw new ArgumentNullException("value"); } 
    			}
    	}
        
        /// <summary>
        /// Shallow copy of object. Exclude navigation properties and PK properties
        /// </summary>
        public EmpEmployeeSysRoleRsp ShallowCopy()
    	{
    	   return new EmpEmployeeSysRoleRsp {
                                           EmpEmployeeId = this.EmpEmployeeId,
                                           SysRoleId = this.SysRoleId,
                                           DeleteDate = this.DeleteDate,
                                           Source = this.Source,
    	                              };
    	}
    }
}
