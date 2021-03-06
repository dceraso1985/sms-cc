// <copyright file="AppConfigRepository.cs" company="Microsoft">
// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
// </copyright>


namespace Microsoft.Teams.Apps.CompanyCommunicator.Common.Repositories.ButtonClickLogData
{
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;
    using Microsoft.Teams.Apps.CompanyCommunicator.Common.Repositories;

    /// <summary>
    /// App configuration repository.
    /// </summary>
    public class ButtonClickLogRepository : BaseRepository<ButtonClickLogEntity>, IButtonClickLogRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonClickLogRepository"/> class.
        /// </summary>
        /// <param name="logger">The logging service.</param>
        /// <param name="repositoryOptions">Options used to create the repository.</param>
        public ButtonClickLogRepository(
            ILogger<ButtonClickLogRepository> logger,
            IOptions<RepositoryOptions> repositoryOptions)
            : base(
                  logger,
                  storageAccountConnectionString: repositoryOptions.Value.StorageAccountConnectionString,
                  tableName: ButtonClickLogTableName.TableName,
                  defaultPartitionKey: ButtonClickLogTableName.SettingsPartition,
                  ensureTableExists: repositoryOptions.Value.EnsureTableExists)
        {
        }
    }

}
