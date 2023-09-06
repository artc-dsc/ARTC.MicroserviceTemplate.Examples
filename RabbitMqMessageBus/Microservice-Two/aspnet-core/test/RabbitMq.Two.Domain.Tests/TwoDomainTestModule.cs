using RabbitMq.Two.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace RabbitMq.Two;

[DependsOn(
    typeof(TwoEntityFrameworkCoreTestModule)
    )]
public class TwoDomainTestModule : AbpModule
{

}
