using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Zion.Blazor;

[Dependency(ReplaceServices = true)]
public class ZionBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Zion";
}
