using Volo.Abp.Settings;

namespace RabbitMq.Two.Settings;

public class TwoSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(TwoSettings.MySetting1));
    }
}
