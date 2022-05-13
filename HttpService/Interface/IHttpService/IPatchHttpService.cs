using HttpService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpService.Interface
{
  public partial interface IHttpService
  {

    Task<ResponseModel<T>> PatchAsync<T>(string url, object model, Dictionary<string, string>? query = null,
                                        Dictionary<string, string>? headers = null);

    Task<ResponseModel<T>> PatchAsync<T>(string url, object model, string query,
                                        Dictionary<string, string>? headers = null);
    Task<ResponseModel<object>> PatchAsync(string url, object model, Dictionary<string, string>? query = null,
                                          Dictionary<string, string>? headers = null);

    Task<ResponseModel<object>> PatchAsync(string url, object model, string query,
                                          Dictionary<string, string>? headers = null);


  }
}
