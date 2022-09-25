using HttpService.Interface;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpService.Service;
 //The HttpService Delete Methods
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
    public async Task<ReturnModel<T>> DeleteAsync<T>(string url,
      Dictionary<string, string>? query = null,
      Dictionary<string, string>? headers = null)
    {
      HttpRequestMessage requestMessage =
        _requestService.CreateRequestMessageAsync(url, HttpMethod.Delete, query, headers, null).Result;


      ReturnModel<T> requestResponse = _requestService.SendRequestAsync<T>(requestMessage).Result;
      return requestResponse;
    }

    /// <summary>
    ///  Send Delete request and serialize the api response model to T
    /// </summary>
    /// <typeparam name="T">Api response would be serialied to T</typeparam>
    /// <param name="url">Api route</param>
    /// <param name="query">Query string</param>
    /// <param name="headers">Request headers</param>
    /// <returns>Response model of T</returns>
    public async Task<ReturnModel<T>> DeleteAsync<T>(string url,
      string query,
      Dictionary<string, string>? headers = null)
    {

      HttpRequestMessage requestMessage =
        _requestService.CreateRequestMessageAsync(url, HttpMethod.Delete, query, headers, null).Result;

      ReturnModel<T> requestResponse = _requestService.SendRequestAsync<T>(requestMessage).Result;
      return requestResponse;
    }

    /// <summary>
    ///  Send Delete request 
    /// </summary>
    /// <param name="url">Api route</param>
    /// <param name="query">Query string</param>
    /// <param name="headers">Request headers</param>
    /// <returns>Response model</returns>
    public async Task<ReturnModel<object>> DeleteAsync(string url,
      Dictionary<string, string>? query = null,
      Dictionary<string, string>? headers = null)
    {
      HttpRequestMessage requestMessage =
        _requestService.CreateRequestMessageAsync(url, HttpMethod.Delete, query, headers, null).Result;

      ReturnModel<object> requestResponse = _requestService.SendRequestAsync<object>(requestMessage).Result;
      return requestResponse;
    }

    /// <summary>
    ///  Send Delete request 
    /// </summary>
    /// <param name="url">Api route</param>
    /// <param name="query">Query string</param>
    /// <param name="headers">Request headers</param>
    /// <returns>Response model</returns>
    public async Task<ReturnModel<object>> DeleteAsync(string url,
      string query, Dictionary<string, string>? headers = null)
    {
      HttpRequestMessage requestMessage =
        _requestService.CreateRequestMessageAsync(url, HttpMethod.Delete, query, headers, null).Result;

      ReturnModel<object> requestResponse = _requestService.SendRequestAsync<object>(requestMessage).Result;
      return requestResponse;
    }
  }

