using HttpService.Interface;
using HttpService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpService.Service
{
  //Delete
  public partial class HttpService : IHttpService
  {

    public async Task<ResponseModel<T>> DeleteAsync<T>(string url,
      Dictionary<string, string>? query = null,
      Dictionary<string, string>? headers = null)
    {
      HttpRequestMessage requestMessage =
        _requestService.CreateRequestMessageAsync<object>(url, HttpMethod.Delete, query, headers, null).Result;


      throw new NotImplementedException();
    }

    public Task<ResponseModel<T>> DeleteAsync<T>(string url,
      string query,
      Dictionary<string, string>? headers = null)
    {

      HttpRequestMessage requestMessage =
        _requestService.CreateRequestMessageAsync<object>(url, HttpMethod.Delete, query, headers, null).Result;

      throw new NotImplementedException();
    }

    public Task<ResponseModel<object>> DeleteAsync(string url,
      Dictionary<string, string>? query = null,
      Dictionary<string, string>? headers = null)
    {
      HttpRequestMessage requestMessage =
        _requestService.CreateRequestMessageAsync<object>(url, HttpMethod.Delete, query, headers, null).Result;

      throw new NotImplementedException();
    }

    public Task<ResponseModel<object>> DeleteAsync(string url,
      string query, Dictionary<string, string>? headers = null)
    {
      HttpRequestMessage requestMessage =
        _requestService.CreateRequestMessageAsync<object>(url, HttpMethod.Delete, query, headers, null).Result;

      throw new NotImplementedException();
    }
  }
}
