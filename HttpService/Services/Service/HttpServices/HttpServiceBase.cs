using HttpService.Interface;
using HttpService.Utils;
using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

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

