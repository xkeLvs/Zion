using System.Threading.Tasks;

namespace Zion.Data;

public interface IZionDbSchemaMigrator
{
    Task MigrateAsync();
}
