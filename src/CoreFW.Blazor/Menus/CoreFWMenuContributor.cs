using System.Threading.Tasks;
using CoreFW.Localization;
using CoreFW.MultiTenancy;
using Volo.Abp.Identity;
using Volo.Abp.Identity.Blazor;
using Volo.Abp.SettingManagement.Blazor.Menus;
using Volo.Abp.TenantManagement.Blazor.Navigation;
using Volo.Abp.UI.Navigation;

namespace CoreFW.Blazor.Menus;

public class CoreFWMenuContributor : IMenuContributor
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
        var l = context.GetLocalizer<CoreFWResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                CoreFWMenus.Home,
                l["Menu:Home"],
                "/",
                icon: "fas fa-home",
                order: 0
            )
        );

        context.Menu.Items.Insert(
            1,
            new ApplicationMenuItem(
                "DxGridDemo",
                "Demo DxGrid",
                "/dx-grid-demo",
                icon: "fas fa-table",
                order: 1
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

        // Add Organization Units menu item
        administration.AddItem(
            new ApplicationMenuItem(
                "CoreFW.OrganizationUnits",
                l["Menu:OrganizationUnits"],
                url: "/organization-units",
                icon: "fas fa-sitemap",
                order: 2,
                requiredPermissionName: IdentityPermissions.Users.Default
            )
        );

        return Task.CompletedTask;
    }
}
