using HttpService.Interface;
using HttpService.Model;
using HttpService.Utils;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HttpService.Service;
//The HttpService Post Methods
public partial class HttpService : IHttpService
{

  /// <summary>
  ///  Send Post request and serialize the api response model to T
  /// </summary>
  /// <typeparam name="T">Api response would be serialied to T</typeparam>
  /// <param name="url">Qpi route</param>
  /// <param name="model">Objet model we want ro pass to api in body</param>
  /// <param name="query">Query string</param>
  /// <param name="headers">Request headers</param>
  /// <returns>Response model of T</returns>
  public async Task<ResponseModel<T>> PostAsync<T>(string url, object model = null,
    Dictionary<string, string> query = null,
    Dictionary<string, string> headers = null)
  {
    HttpRequestMessage requestMessage =
      _requestService.CreateRequestMessageAsync(url, HttpMethod.Post, query, headers, model).Result;

    ResponseModel<T> requestResponse = _requestService.SendRequestAsync<T>(requestMessage).Result;
    return requestResponse;
  }

  /// <summary>
  ///  Send Post request and serialize the api response model to T
  /// </summary>
  /// <typeparam name="T">Api response would be serialied to T</typeparam>
  /// <param name="url">Qpi route</param>
  /// <param name="model">Objet model we want ro pass to api in body</param>
  /// <param name="query">Query string</param>
  /// <param name="headers">Request headers</param>
  /// <returns>Response model of T</returns>
  public async Task<ResponseModel<T>> PostAsync<T>(string url, object model = null, string query = null,
    Dictionary<string, string> headers = null)
  {
    HttpRequestMessage requestMessage =
    _requestService.CreateRequestMessageAsync(url, HttpMethod.Post, query, headers, model).Result;

    ResponseModel<T> requestResponse = _requestService.SendRequestAsync<T>(requestMessage).Result;
    return requestResponse;
  }

  /// <summary>
  ///  Send Post request
  /// </summary>
  /// <param name="url">Qpi route</param>
  /// <param name="model">Objet model we want ro pass to api in body</param>
  /// <param name="query">Query string</param>
  /// <param name="headers">Request headers</param>
  /// <returns>Response model</returns>
  public async Task<ResponseModel<object>> PostAsync(string url, object model = null,
    Dictionary<string, string> query = null,
    Dictionary<string, string> headers = null)
  {
    HttpRequestMessage requestMessage =
    _requestService.CreateRequestMessageAsync(url, HttpMethod.Post, query, headers, model).Result;

    ResponseModel<object> requestResponse = _requestService.SendRequestAsync<object>(requestMessage).Result;
    return requestResponse;
  }

  /// <summary>
  ///  Send Post request
  /// </summary>
  /// <param name="url">Qpi route</param>
  /// <param name="model">Objet model we want ro pass to api in body</param>
  /// <param name="query">Query string</param>
  /// <param name="headers">Request headers</param>
  /// <returns>Response model</returns>
  public async Task<ResponseModel<object>> PostAsync(string url, object model = null, string query = null,
    Dictionary<string, string> headers = null)
  {
    HttpRequestMessage requestMessage =
    _requestService.CreateRequestMessageAsync(url, HttpMethod.Post, query, headers, model).Result;

    ResponseModel<object> requestResponse = _requestService.SendRequestAsync<object>(requestMessage).Result;
    return requestResponse;
  }


}
