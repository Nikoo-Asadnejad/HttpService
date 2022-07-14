using HttpService.FixValues;
using HttpService.Interface;
using HttpService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpService.Service;

//The HttpService PutFormDataAsyn Methods
public partial class HttpService  : IHttpService
  {

  /// <summary>
  ///  Puts model as multiPartFormData and serialize the api response model to T
  /// </summary>
  /// <typeparam name="T">Api response would be serialied to T</typeparam>
  /// <param name="url">Api route</param>
  /// <param name="model">Objet model we want ro pass to api in body</param>
  /// <param name="query">Query string</param>
  /// <param name="headers">Request headers</param>
  /// <returns>Response model of T</returns>
  public async Task<ResponseModel<T>> PutFormDataAsync<T>(string url, object model = null,
      Dictionary<string, string> query = null, Dictionary<string, string> headers = null)
    {
      HttpRequestMessage requestMessage =
       _requestService.CreateRequestMessageAsync(url, HttpMethod.Put, query, headers, model, MediaTypes.FormData).Result;

      ResponseModel<T> requestResponse = _requestService.SendRequestAsync<T>(requestMessage).Result;
      return requestResponse;
    }

  /// <summary>
  ///  Puts model as multiPartFormData and serialize the api response model to T
  /// </summary>
  /// <typeparam name="T">Api response would be serialied to T</typeparam>
  /// <param name="url">Api route</param>
  /// <param name="model">Objet model we want ro pass to api in body</param>
  /// <param name="query">Query string</param>
  /// <param name="headers">Request headers</param>
  /// <returns>Response model of T</returns>
  public async Task<ResponseModel<T>> PutFormDataAsync<T>(string url, object model = null, string query = null,
      Dictionary<string, string> headers = null)
    {
      HttpRequestMessage requestMessage =
       _requestService.CreateRequestMessageAsync(url, HttpMethod.Put, query, headers, model ,MediaTypes.FormData).Result;

      ResponseModel<T> requestResponse = _requestService.SendRequestAsync<T>(requestMessage).Result;
      return requestResponse;
    }

  /// <summary>
  ///  Puts model as multiPartFormData
  /// </summary>
  /// <param name="url">Api route</param>
  /// <param name="model">Objet model we want ro pass to api in body</param>
  /// <param name="query">Query string</param>
  /// <param name="headers">Request headers</param>
  /// <returns>Response</returns>
  public async Task<ResponseModel<object>> PutFormDataAsync(string url, object model = null,
      Dictionary<string, string> query = null, Dictionary<string, string> headers = null)
    {
      HttpRequestMessage requestMessage =
             _requestService.CreateRequestMessageAsync(url, HttpMethod.Put, query, headers, model, MediaTypes.FormData).Result;

      ResponseModel<object> requestResponse = _requestService.SendRequestAsync<object>(requestMessage).Result;
      return requestResponse;
    }

  /// <summary>
  ///  Puts model as multiPartFormData
  /// </summary>
  /// <param name="url">Api route</param>
  /// <param name="model">Objet model we want ro pass to api in body</param>
  /// <param name="query">Query string</param>
  /// <param name="headers">Request headers</param>
  /// <returns>Response</returns>
  public async Task<ResponseModel<object>> PutFormDataAsync(string url, object model = null, string query = null,
      Dictionary<string, string> headers = null)
    {
      HttpRequestMessage requestMessage =
       _requestService.CreateRequestMessageAsync(url, HttpMethod.Put, query, headers, model , MediaTypes.FormData).Result;

      ResponseModel<object> requestResponse = _requestService.SendRequestAsync<object>(requestMessage).Result;
      return requestResponse;
    }




  }

