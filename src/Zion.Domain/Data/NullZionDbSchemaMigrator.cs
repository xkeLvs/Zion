using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Zion.Data;

/* This is used if database provider does't define
 * IZionDbSchemaMigrator implementation.
 */
public class NullZionDbSchemaMigrator : IZionDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
