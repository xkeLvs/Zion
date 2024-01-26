using Zion.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Zion.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ZionController : AbpControllerBase
{
    protected ZionController()
    {
        LocalizationResource = typeof(ZionResource);
    }
}
