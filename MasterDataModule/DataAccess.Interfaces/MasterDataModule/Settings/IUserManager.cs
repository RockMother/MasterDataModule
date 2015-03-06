﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.DriverLicenceMasterData;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.Base;

namespace TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.Settings
{
    /// <summary>
    /// 
    /// </summary>
	public interface IUserManager : IEntityManager<User, int>
	{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userLogin"></param>
        /// <returns></returns>
		User GetByLogin(string userLogin);
	}
}
