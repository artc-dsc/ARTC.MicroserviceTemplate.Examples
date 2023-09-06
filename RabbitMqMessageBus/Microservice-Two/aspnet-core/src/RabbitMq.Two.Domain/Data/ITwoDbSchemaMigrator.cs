using System.Threading.Tasks;

namespace RabbitMq.Two.Data;

public interface ITwoDbSchemaMigrator
{
    Task MigrateAsync();
}
