using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace RabbitMq.Two.Data;

/* This is used if database provider does't define
 * ITwoDbSchemaMigrator implementation.
 */
public class NullTwoDbSchemaMigrator : ITwoDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
