using HttpService.Interface;
using HttpService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpService.Service
{
  public partial class HttpService : IHttpService
  {
    /// <summary>
    /// Sends Get Request , Serialize the Response Model To T 
    /// </summary>
    /// <typeparam name="T">The Model we want to map response model to</typeparam>
    /// <param name="url">Route</param>
    /// <param name="query">Query</param>
    /// <param name="headers">Headers</param>
    /// <returns>ResponseModel<T></returns>
    public async Task<ResponseModel<T>> GetAsync<T>(string url,
      Dictionary<string, string>? query = null,
      Dictionary<string, string>? headers = null)
    {

      HttpRequestMessage requestMessage =
        _requestService.CreateRequestMessageAsync<object>(url, HttpMethod.Get, query, headers, null).Result;

      ResponseModel<T> requestResponse = _requestService.SendRequestAsync<T>(requestMessage).Result;
      return requestResponse;
    }

    /// <summary>
    /// Sends Get Request , Serialize the  Response Model To T 
    /// </summary>
    /// <typeparam name="T"> Response Model</typeparam>
    /// <param name="url">Route</param>
    /// <param name="query">Query</param>
    /// <param name="headers">Headers</param>
    /// <returns>ResponseModel<T></returns>
    public async Task<ResponseModel<T>> GetAsync<T>(string url, string query,
      Dictionary<string, string>? headers = null)
    {
        HttpRequestMessage requestMessage =
        _requestService.CreateRequestMessageAsync<object>(url, HttpMethod.Get, query, headers, null).Result;

        ResponseModel<T> requestResponse = _requestService.SendRequestAsync<T>(requestMessage).Result;
        return requestResponse;
    }

    /// <summary>
    /// Sends Get Request ,Don't Serialize the Response Model
    /// </summary>
    /// <param name="url">Route</param>
    /// <param name="query">Query</param>
    /// <param name="headers">Headers</param>
    /// <returns>ResponseModel<Object></returns>
    public async Task<ResponseModel<object>> GetAsync(string url,
      Dictionary<string, string>? query = null,
      Dictionary<string, string>? headers = null)
    {
      HttpRequestMessage requestMessage =
        _requestService.CreateRequestMessageAsync<object>(url, HttpMethod.Get, query, headers, null).Result;

      ResponseModel<object> requestResponse = _requestService.SendRequestAsync<object>(requestMessage).Result;
      return requestResponse;
    }

    /// <summary>
    /// Sends Get Request ,Don't Serialize the Response Model
    /// </summary>
    /// <param name="url">Route</param>
    /// <param name="query">Query</param>
    /// <param name="headers">Headers</param>
    /// <returns>ResponseModel<Object></returns>
    public async Task<ResponseModel<object>> GetAsync(string url, string query,
      Dictionary<string, string>? headers = null)
    {

      HttpRequestMessage requestMessage =
        _requestService.CreateRequestMessageAsync<object>(url, HttpMethod.Get, query, headers, null).Result;

      ResponseModel<object> requestResponse = _requestService.SendRequestAsync<object>(requestMessage).Result;
      return requestResponse;
    }

  }
}
