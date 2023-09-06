using RabbitMq.One.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace RabbitMq.One.Permissions;

public class OnePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(OnePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(OnePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<OneResource>(name);
    }
}
