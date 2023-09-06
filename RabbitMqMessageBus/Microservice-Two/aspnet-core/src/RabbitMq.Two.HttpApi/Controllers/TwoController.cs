using RabbitMq.Two.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace RabbitMq.Two.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TwoController : AbpControllerBase
{
    protected TwoController()
    {
        LocalizationResource = typeof(TwoResource);
    }
}
