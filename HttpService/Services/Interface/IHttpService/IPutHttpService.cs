using HttpService.Model;
using HttpService.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpService.Interface
{
  public partial interface IHttpService 
  {

    Task<ResponseModel<T>> PutAsync<T>(string url, object model, Dictionary<string, string>? query = null,
                                      Dictionary<string, string>? headers = null);
    Task<ResponseModel<T>> PutAsync<T>(string url, object model, string query,
                                      Dictionary<string, string>? headers = null);
    Task<ResponseModel<object>> PutAsync(string url, object model, Dictionary<string, string>? query = null,
                                        Dictionary<string, string>? headers = null);
    Task<ResponseModel<object>> PutAsync(string url, object model, string query,
                                        Dictionary<string, string>? headers = null);





  }
}
