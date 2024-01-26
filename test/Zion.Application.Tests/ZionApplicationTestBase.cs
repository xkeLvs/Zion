using Volo.Abp.Modularity;

namespace Zion;

public abstract class ZionApplicationTestBase<TStartupModule> : ZionTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
