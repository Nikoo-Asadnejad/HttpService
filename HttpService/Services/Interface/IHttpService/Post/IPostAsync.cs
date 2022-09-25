 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpService.Interface;
public partial interface IHttpService
  {

    Task<ReturnModel<T>> PostAsync<T>(string url, object model, Dictionary<string, string>? query = null,
                                        Dictionary<string, string>? headers = null);
    Task<ReturnModel<T>> PostAsync<T>(string url, object model, string query,
                                        Dictionary<string, string>? headers);
    Task<ReturnModel<object>> PostAsync(string url, object model, Dictionary<string, string>? query = null,
                                          Dictionary<string, string>? headers = null);
    Task<ReturnModel<object>> PostAsync(string url, object model, string query,
                                          Dictionary<string, string>? headers = null);
  }
