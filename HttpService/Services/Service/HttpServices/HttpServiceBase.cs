using HttpService.Interface;

namespace HttpService.Service;

  //The HttpService Base
  public partial class HttpService : IHttpService
  {
    private readonly IRequestService _requestService;

    public HttpService(IRequestService requestService)
    {
      _requestService = requestService;
    }


  }

