using RabbitMq.Two.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace RabbitMq.Two.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TwoEntityFrameworkCoreModule),
    typeof(TwoApplicationContractsModule)
    )]
public class TwoDbMigratorModule : AbpModule
{
}
