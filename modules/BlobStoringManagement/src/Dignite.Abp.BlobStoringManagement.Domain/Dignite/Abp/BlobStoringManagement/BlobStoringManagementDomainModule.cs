﻿using Dignite.Abp.BlobStoring;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Dignite.Abp.BlobStoringManagement
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(BlobStoringManagementDomainSharedModule),
        typeof(DigniteAbpBlobStoringAbstractionsModule)
    )]
    public class BlobStoringManagementDomainModule : AbpModule
    {
    }
}
