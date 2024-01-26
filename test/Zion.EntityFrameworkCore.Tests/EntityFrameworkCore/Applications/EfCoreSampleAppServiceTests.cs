using Zion.Samples;
using Xunit;

namespace Zion.EntityFrameworkCore.Applications;

[Collection(ZionTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ZionEntityFrameworkCoreTestModule>
{

}
