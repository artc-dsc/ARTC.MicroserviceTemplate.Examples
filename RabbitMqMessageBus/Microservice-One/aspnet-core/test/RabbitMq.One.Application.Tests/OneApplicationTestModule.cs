using Volo.Abp.Modularity;

namespace RabbitMq.One;

[DependsOn(
    typeof(OneApplicationModule),
    typeof(OneDomainTestModule)
    )]
public class OneApplicationTestModule : AbpModule
{

}
