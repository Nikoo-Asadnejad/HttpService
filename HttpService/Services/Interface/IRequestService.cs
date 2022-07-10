using HttpService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpService.Interface;
public interface IRequestService
  {
    Task<ResponseModel<T>> SendRequestAsync<T>(HttpRequestMessage requestMessage);



    Task<HttpRequestMessage> CreateRequestMessageAsync(string url, HttpMethod httpMethod,
                                                          Dictionary<string, string>? query,
                                                          Dictionary<string, string>? headers, object model);

    Task<HttpRequestMessage> CreateRequestMessageAsync(string url,
                                                          HttpMethod httpMethod,
                                                          string query,
                                                          Dictionary<string, string>? headers, object model);


  }
