using HttpService.Interface;
using HttpService.Service;
using Microsoft.Extensions.DependencyInjection;

namespace HttpService.Configuration
{
  public class HttpServiceConfigurator
  {
    public static void InjectHttpService(IServiceCollection services)
    {
      services.AddHttpClient();
      services.AddTransient<IRequestService, RequestService>();
      services.AddTransient<IHttpService,Service.HttpService >();
    }
  }
}
