using System.Threading.Tasks;
using Zion.Localization;
using Zion.MultiTenancy;
using Volo.Abp.Identity.Blazor;
using Volo.Abp.SettingManagement.Blazor.Menus;
using Volo.Abp.TenantManagement.Blazor.Navigation;
using Volo.Abp.UI.Navigation;

namespace Zion.Blazor.Menus;

public class ZionMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<ZionResource>();

        // context.Menu.Items.Insert(
        //     0,
        //     new ApplicationMenuItem(
        //         "Dashboard",
        //         "Dashboard",
        //         "/",
        //         icon: "fas fa-home",
        //         order: 0
        //     )
        // );
        context.Menu.Items.Insert(
            1,
            new ApplicationMenuItem(
                "Students",
                "Students",
                "/Students",
                icon: "fas fa-home",
                order: 1
            )
        );

        context.Menu.Items.Insert(
            2,
            new ApplicationMenuItem(
                "Teachers",
                "Teachers",
                "/Teachers",
                icon: "fas fa-home",
                order: 2
            )
        );

        context.Menu.Items.Insert(
            3,
            new ApplicationMenuItem(
                "Subjects",
                "Subjects",
                "/Subjects",
                icon: "fas fa-home",
                order: 3
            )
        );

        context.Menu.Items.Insert(
            4,
            new ApplicationMenuItem(
                "Rooms",
                "Rooms",
                "/Rooms",
                icon: "fas fa-home",
                order: 4
            )
        );

        context.Menu.Items.Insert(
            5,
            new ApplicationMenuItem(
                "Sections",
                "Sections",
                "/Sections",
                icon: "fas fa-home",
                order: 5
            )
        );

        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenus.GroupName, 3);

        return Task.CompletedTask;
    }
}
