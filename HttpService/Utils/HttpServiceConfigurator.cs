using HttpService.Interface;
using HttpService.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpService.Utils
{
  public class HttpServiceConfigurator
  {
    public static void Inject(IServiceCollection services)
    {
      services.AddTransient<IRequestService, RequestService>();
      services.AddTransient<IHttpService,Service.HttpService >();
    }
  }
}
