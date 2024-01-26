using Zion.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Zion.Blazor;

public abstract class ZionComponentBase : AbpComponentBase
{
    protected ZionComponentBase()
    {
        LocalizationResource = typeof(ZionResource);
    }
}
