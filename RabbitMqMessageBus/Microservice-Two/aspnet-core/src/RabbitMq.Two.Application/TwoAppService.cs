using System;
using System.Collections.Generic;
using System.Text;
using RabbitMq.Two.Localization;
using Volo.Abp.Application.Services;

namespace RabbitMq.Two;

/* Inherit your application services from this class.
 */
public abstract class TwoAppService : ApplicationService
{
    protected TwoAppService()
    {
        LocalizationResource = typeof(TwoResource);
    }
}
