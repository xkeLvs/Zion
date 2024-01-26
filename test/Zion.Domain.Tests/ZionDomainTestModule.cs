using Volo.Abp.Modularity;

namespace Zion;

[DependsOn(
    typeof(ZionDomainModule),
    typeof(ZionTestBaseModule)
)]
public class ZionDomainTestModule : AbpModule
{

}
