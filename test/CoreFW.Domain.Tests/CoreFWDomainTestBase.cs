﻿using Volo.Abp.Modularity;

namespace CoreFW;

/* Inherit from this class for your domain layer tests. */
public abstract class CoreFWDomainTestBase<TStartupModule> : CoreFWTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
