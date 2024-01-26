using Xunit;

namespace Zion.EntityFrameworkCore;

[CollectionDefinition(ZionTestConsts.CollectionDefinitionName)]
public class ZionEntityFrameworkCoreCollection : ICollectionFixture<ZionEntityFrameworkCoreFixture>
{

}
