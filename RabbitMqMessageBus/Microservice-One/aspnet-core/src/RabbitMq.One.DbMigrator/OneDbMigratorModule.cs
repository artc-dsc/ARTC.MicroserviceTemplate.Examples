using RabbitMq.One.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace RabbitMq.One.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(OneEntityFrameworkCoreModule),
    typeof(OneApplicationContractsModule)
    )]
public class OneDbMigratorModule : AbpModule
{
}
