﻿using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Dignite.Abp.Notifications.EntityFrameworkCore
{
    [ConnectionStringName(NotificationsDbProperties.ConnectionStringName)]
    public interface INotificationsDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}