using Zion.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Zion.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ZionEntityFrameworkCoreModule),
    typeof(ZionApplicationContractsModule)
    )]
public class ZionDbMigratorModule : AbpModule
{
}
