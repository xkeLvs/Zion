using System;
using System.Collections.Generic;
using System.Text;
using Zion.Localization;
using Volo.Abp.Application.Services;

namespace Zion;

/* Inherit your application services from this class.
 */
public abstract class ZionAppService : ApplicationService
{
    protected ZionAppService()
    {
        LocalizationResource = typeof(ZionResource);
    }
}
