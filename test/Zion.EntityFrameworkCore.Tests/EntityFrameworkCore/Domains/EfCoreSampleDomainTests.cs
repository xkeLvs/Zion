using Zion.Samples;
using Xunit;

namespace Zion.EntityFrameworkCore.Domains;

[Collection(ZionTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ZionEntityFrameworkCoreTestModule>
{

}
