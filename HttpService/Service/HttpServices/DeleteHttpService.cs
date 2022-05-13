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

    /// <summary>
    ///  Send Delete request and serialize the api response model to T
    /// </summary>
    /// <typeparam name="T">Api response would be serialied to T</typeparam>
    /// <param name="url">Api route</param>
    /// <param name="query">Query string</param>
    /// <param name="headers">Request headers</param>
    /// <returns>Response model of T</returns>
    public async Task<ResponseModel<T>> DeleteAsync<T>(string url,
      Dictionary<string, string>? query = null,
      Dictionary<string, string>? headers = null)
    {
      HttpRequestMessage requestMessage =
        _requestService.CreateRequestMessageAsync<object>(url, HttpMethod.Delete, query, headers, null).Result;


      throw new NotImplementedException();
    }

    /// <summary>
    ///  Send Delete request and serialize the api response model to T
    /// </summary>
    /// <typeparam name="T">Api response would be serialied to T</typeparam>
    /// <param name="url">Api route</param>
    /// <param name="query">Query string</param>
    /// <param name="headers">Request headers</param>
    /// <returns>Response model of T</returns>
    public Task<ResponseModel<T>> DeleteAsync<T>(string url,
      string query,
      Dictionary<string, string>? headers = null)
    {

      HttpRequestMessage requestMessage =
        _requestService.CreateRequestMessageAsync<object>(url, HttpMethod.Delete, query, headers, null).Result;

      throw new NotImplementedException();
    }

    /// <summary>
    ///  Send Delete request 
    /// </summary>
    /// <param name="url">Api route</param>
    /// <param name="query">Query string</param>
    /// <param name="headers">Request headers</param>
    /// <returns>Response model</returns>
    public Task<ResponseModel<object>> DeleteAsync(string url,
      Dictionary<string, string>? query = null,
      Dictionary<string, string>? headers = null)
    {
      HttpRequestMessage requestMessage =
        _requestService.CreateRequestMessageAsync<object>(url, HttpMethod.Delete, query, headers, null).Result;

      throw new NotImplementedException();
    }

    /// <summary>
    ///  Send Delete request 
    /// </summary>
    /// <param name="url">Api route</param>
    /// <param name="query">Query string</param>
    /// <param name="headers">Request headers</param>
    /// <returns>Response model</returns>
    public Task<ResponseModel<object>> DeleteAsync(string url,
      string query, Dictionary<string, string>? headers = null)
    {
      HttpRequestMessage requestMessage =
        _requestService.CreateRequestMessageAsync<object>(url, HttpMethod.Delete, query, headers, null).Result;

      throw new NotImplementedException();
    }
  }
}
