﻿using System;
using System.Data.Entity.Core.Objects;
using TuevSued.V1.IT.FE.DataAccess.Interfaces;

namespace TuevSued.V1.IT.FE.MasterDataModule.Lib.Data
{
    /// <summary> Custom partial part of context interface IFeEntitities (see FeDataModel.Context.Interface.cs). </summary>
    public partial interface IFeEntities : IEntities
    {
        /// <summary>
        ///     Object context
        /// </summary>
        ObjectContext ObjectContext { get; }
        /// <summary>
        ///     Throws InvalidOperationException if there is any change in DbContext after the last changes saving.
        /// </summary>
        void ThrowIfHasChange();
    }
}