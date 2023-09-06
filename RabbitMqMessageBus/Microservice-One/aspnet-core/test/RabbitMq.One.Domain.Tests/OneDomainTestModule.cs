using RabbitMq.One.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace RabbitMq.One;

[DependsOn(
    typeof(OneEntityFrameworkCoreTestModule)
    )]
public class OneDomainTestModule : AbpModule
{

}
