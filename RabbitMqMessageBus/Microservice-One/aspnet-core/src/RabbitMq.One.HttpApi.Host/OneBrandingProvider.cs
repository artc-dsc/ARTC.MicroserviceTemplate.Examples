using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace RabbitMq.One;

[Dependency(ReplaceServices = true)]
public class OneBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "One";
}
