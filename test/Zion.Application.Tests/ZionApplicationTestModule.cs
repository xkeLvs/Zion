using Volo.Abp.Modularity;

namespace Zion;

[DependsOn(
    typeof(ZionApplicationModule),
    typeof(ZionDomainTestModule)
)]
public class ZionApplicationTestModule : AbpModule
{

}
