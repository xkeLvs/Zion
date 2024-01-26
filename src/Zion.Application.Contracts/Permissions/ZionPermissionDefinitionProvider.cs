using Zion.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Zion.Permissions;

public class ZionPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ZionPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ZionPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ZionResource>(name);
    }
}
