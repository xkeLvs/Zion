using Volo.Abp.Settings;

namespace Zion.Settings;

public class ZionSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ZionSettings.MySetting1));
    }
}
