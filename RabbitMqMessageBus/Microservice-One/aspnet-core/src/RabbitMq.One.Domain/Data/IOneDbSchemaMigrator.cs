using System.Threading.Tasks;

namespace RabbitMq.One.Data;

public interface IOneDbSchemaMigrator
{
    Task MigrateAsync();
}
