using RabbitMq.One.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace RabbitMq.One.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class OneController : AbpControllerBase
{
    protected OneController()
    {
        LocalizationResource = typeof(OneResource);
    }
}
