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

namespace TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.DriverLicenceMasterData
{
    /// <summary>
    /// Entity from table DRL_EXAM_RECOGNITION_TYPE. EN: 5.2.12.7 Recognition type  DE: 5.2.12.7 Annerkennung  
    /// </summary>
    public partial class ExamRecognitionType : IHasId<int>, ICommonSystemFields, ISystemFields, IRemovable, IHasTitle
    {
    
        /// <summary>
        /// Table name
        /// </summary>
        public static readonly string EntityTableName = "DRL_EXAM_RECOGNITION_TYPE";
        
        #region Fields
        /// <summary>
        /// Columns names
        /// </summary>
        public static class Fields
        {
            /// <summary>
            /// Column name 'ID' for property <see cref="LegalBasis.Id"/>
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// Column name 'NAME' for property <see cref="LegalBasis.Name"/>
            /// </summary>
            public static readonly string Name = "NAME";
            /// <summary>
            /// Column name 'DESCRIPTION' for property <see cref="LegalBasis.Description"/>
            /// </summary>
            public static readonly string Description = "DESCRIPTION";
           
            /// <summary>
            /// Column name 'CREATE_DATE' for property <see cref="LegalBasis.CreateDate"/>
            /// </summary>
            public static readonly string CreateDate = "CREATE_DATE";
            /// <summary>
            /// Column name 'CHANGE_DATE' for property <see cref="LegalBasis.ChangeDate"/>
            /// </summary>
            public static readonly string ChangeDate = "CHANGE_DATE";
            /// <summary>
            /// Column name 'OWNER_ORG_ID' for property <see cref="LegalBasis.OwnerOrgId"/>
            /// </summary>
            public static readonly string OwnerOrgId = "OWNER_ORG_ID";
            /// <summary>
            /// Column name 'VISIBILITY_ORG_ID' for property <see cref="LegalBasis.VisibilityOrgId"/>
            /// </summary>
            public static readonly string VisibilityOrgId = "VISIBILITY_ORG_ID";
            /// <summary>
            /// Column name 'CREATE_EMPLOYEE_ID' for property <see cref="LegalBasis.CreateEmployeeId"/>
            /// </summary>
            public static readonly string CreateEmployeeId = "CREATE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'CHANGE_EMPLOYEE_ID' for property <see cref="LegalBasis.ChangeEmployeeId"/>
            /// </summary>
            public static readonly string ChangeEmployeeId = "CHANGE_EMPLOYEE_ID";
            /// <summary>
            /// Column name 'FROM_DATE' for property <see cref="LegalBasis.FromDate"/>
            /// </summary>
            public static readonly string FromDate = "FROM_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="LegalBasis.ToDate"/>
            /// </summary>
            public static readonly string ToDate = "TO_DATE";
            /// <summary>
            /// Column name 'TO_DATE' for property <see cref="ExamClass.DeleteDate"/>
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
      
        }
        #endregion
        /// <summary>
        /// Constructor
        /// </summary>
        public ExamRecognitionType()
        {
        }
    
        /// <summary>
        /// EN: PK  DE: Primaerschluessel  
        /// </summary>
        public int Id {  get;  set; }
        /// <summary>
        /// EN: Recognition type  DE: Annerkennung
        /// </summary>
        public string Name {  get;  set; }
        /// <summary>
        /// EN: Description  DE: Beschreibung  
        /// </summary>
        public string Description {  get;  set; }
        
        /// <summary>
        /// ANLAGEDATUM (INSERT-DATUM)  
        /// </summary>
        public System.DateTime CreateDate {  get;  set; }
        /// <summary>
        /// AENDERUNGSDATUM (UPDATE-DATUM)  
        /// </summary>
        public System.DateTime ChangeDate {  get;  set; }
        /// <summary>
        /// OWNER (SCHLUESSEL EINER ORGANISATIONSEINHEIT, WELCHE FUER DIE PFLEGE EINES DATENSATZES  
        /// </summary>
        public int? OwnerOrgId {  get;  set; }
        /// <summary>
        /// SICHTBARKEIT (SCHLUESSEL EINER ORGANISATIONSEINHEIT, AB WELCHER IM HIERACHIEBAUM ABWAERTS EIN DATENSATZ SICHTBAR IST)  
        /// </summary>
        public int? VisibilityOrgId {  get;  set; }
        /// <summary>
        /// ANLEGER (PERSONALNUMMER DES MITARBEITERS, DER DEN DATENSATZ ANGELEGT HAT)  
        /// </summary>
        public int? CreateEmployeeId {  get;  set; }
        /// <summary>
        /// AENDERER (PERSONALNUMMER DES MITARBEITERS, DER DEN DATENSATZ ALS LETZTES GEAENDERT HAT, BEI NEUANLAGE IST DIESER WERT GLEICH DEM ANLEGER)  
        /// </summary>
        public int? ChangeEmployeeId {  get;  set; }
        /// <summary>
        /// VON-DATUM DER GUELTIGKEIT  
        /// </summary>
        public System.DateTime FromDate {  get;  set; }
        /// <summary>
        /// ENDE-DATUM DER GUELTIGKEIT  
        /// </summary>
        public System.DateTime ToDate {  get;  set; }



        /// <summary>
        /// Entity create date 
        /// </summary>
        DateTime? ICommonSystemFields.CreateDate
        {
            get { return CreateDate; }
            set
            {
                if (value.HasValue)
                {
                    CreateDate = value.Value;
                }
                else
                {
                    throw new ArgumentNullException("value");
                }
            }
        }

        /// <summary>
        /// Last changed date 
        /// </summary>
    	DateTime? ICommonSystemFields.ChangeDate
    	{
    	    get { 
    		      return ChangeDate; 
    			}
    		set { 
    		      if(value.HasValue){ChangeDate = value.Value;} else{ throw new ArgumentNullException("value"); } 
    			}
    	}    
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
        /// DELETE DATUM
        /// </summary>
        public System.DateTime? DeleteDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string EntityTitle { get { return Name; } }


        /// <summary>
        /// Shallow copy of object. Exclude navigation properties and PK properties
        /// </summary>
        public LegalBasis ShallowCopy()
    	{
    	   return new LegalBasis {
                                           Name = this.Name,
                                           Description = this.Description
    	                              };
    	}
    }
}
