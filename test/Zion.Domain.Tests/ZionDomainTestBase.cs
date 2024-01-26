using Volo.Abp.Modularity;

namespace Zion;

/* Inherit from this class for your domain layer tests. */
public abstract class ZionDomainTestBase<TStartupModule> : ZionTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
