﻿// <copyright file="ButtonClickLogEntity.cs" company="Microsoft">
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
// </copyright>

namespace Microsoft.Teams.Apps.CompanyCommunicator.Common.Repositories
{
    using System;
    using Microsoft.Azure.Cosmos.Table;

    /// <summary>
    /// Button Click Log entity.
    /// </summary>
    public class ButtonClickLogEntity : TableEntity
    {
        /// <summary>
        /// Gets or sets the User Id value.
        /// </summary>
        public string UserId { get; set; }
    }
}
