using Volo.Abp.Modularity;

namespace RabbitMq.Two;

[DependsOn(
    typeof(TwoApplicationModule),
    typeof(TwoDomainTestModule)
    )]
public class TwoApplicationTestModule : AbpModule
{

}
