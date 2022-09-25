 
using HttpService.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpService.Interface;
public partial interface IHttpService 
  {

    Task<ReturnModel<T>> PutFormDataAsync<T>(string url, object model, Dictionary<string, string>? query = null,
                                      Dictionary<string, string>? headers = null);
    Task<ReturnModel<T>> PutFormDataAsync<T>(string url, object model, string query,
                                      Dictionary<string, string>? headers = null);
    Task<ReturnModel<object>> PutFormDataAsync(string url, object model, Dictionary<string, string>? query = null,
                                        Dictionary<string, string>? headers = null);
    Task<ReturnModel<object>> PutFormDataAsync(string url, object model, string query,
                                        Dictionary<string, string>? headers = null);





  }

