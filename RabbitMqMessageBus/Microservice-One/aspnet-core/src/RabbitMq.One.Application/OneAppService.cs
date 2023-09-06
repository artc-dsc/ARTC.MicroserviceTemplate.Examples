using System;
using System.Collections.Generic;
using System.Text;
using RabbitMq.One.Localization;
using Volo.Abp.Application.Services;

namespace RabbitMq.One;

/* Inherit your application services from this class.
 */
public abstract class OneAppService : ApplicationService
{
    protected OneAppService()
    {
        LocalizationResource = typeof(OneResource);
    }
}
