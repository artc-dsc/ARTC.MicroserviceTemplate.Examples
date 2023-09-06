using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace RabbitMq.Two;

[Dependency(ReplaceServices = true)]
public class TwoBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Two";
}
