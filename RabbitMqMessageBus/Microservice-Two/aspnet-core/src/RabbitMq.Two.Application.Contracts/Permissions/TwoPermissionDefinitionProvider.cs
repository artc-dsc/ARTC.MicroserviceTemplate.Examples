using RabbitMq.Two.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace RabbitMq.Two.Permissions;

public class TwoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TwoPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(TwoPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TwoResource>(name);
    }
}
