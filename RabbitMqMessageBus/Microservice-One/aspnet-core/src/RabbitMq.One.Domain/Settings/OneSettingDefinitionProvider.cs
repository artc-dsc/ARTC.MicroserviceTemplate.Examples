using Volo.Abp.Settings;

namespace RabbitMq.One.Settings;

public class OneSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(OneSettings.MySetting1));
    }
}
