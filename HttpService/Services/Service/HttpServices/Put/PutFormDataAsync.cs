using HttpService.Interface;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpService.Service;

//The HttpService Put Methods
public partial class HttpService  : IHttpService
  {

    /// <summary>
    ///  Send Put request and serialize the api response model to T
    /// </summary>
    /// <typeparam name="T">Api response would be serialied to T</typeparam>
    /// <param name="url">Qpi route</param>
    /// <param name="model">Objet model we want ro pass to api in body</param>
    /// <param name="query">Query string</param>
    /// <param name="headers">Request headers</param>
    /// <returns>Response model of T</returns>
    public async Task<ReturnModel<T>> PutAsync<T>(string url, object model = null,
      Dictionary<string, string> query = null, Dictionary<string, string> headers = null)
    {
      HttpRequestMessage requestMessage =
       _requestService.CreateRequestMessageAsync(url, HttpMethod.Put, query, headers, model).Result;

      ReturnModel<T> requestResponse = _requestService.SendRequestAsync<T>(requestMessage).Result;
      return requestResponse;
    }

    /// <summary>
    ///  Send Put request and serialize the api response model to T
    /// </summary>
    /// <typeparam name="T">Api response would be serialied to T</typeparam>
    /// <param name="url">Qpi route</param>
    /// <param name="model">Objet model we want ro pass to api in body</param>
    /// <param name="query">Query string</param>
    /// <param name="headers">Request headers</param>
    /// <returns>Response model of T</returns>
    public async Task<ReturnModel<T>> PutAsync<T>(string url, object model = null, string query = null,
      Dictionary<string, string> headers = null)
    {
      HttpRequestMessage requestMessage =
       _requestService.CreateRequestMessageAsync(url, HttpMethod.Put, query, headers, model).Result;

      ReturnModel<T> requestResponse = _requestService.SendRequestAsync<T>(requestMessage).Result;
      return requestResponse;
    }
    /// <summary>
    ///  Send Put request
    /// </summary>
    /// <param name="url">Qpi route</param>
    /// <param name="model">Objet model we want ro pass to api in body</param>
    /// <param name="query">Query string</param>
    /// <param name="headers">Request headers</param>
    /// <returns>Response</returns>
    public async Task<ReturnModel<object>> PutAsync(string url, object model = null,
      Dictionary<string, string> query = null, Dictionary<string, string> headers = null)
    {
      HttpRequestMessage requestMessage =
             _requestService.CreateRequestMessageAsync(url, HttpMethod.Put, query, headers, model).Result;

      ReturnModel<object> requestResponse = _requestService.SendRequestAsync<object>(requestMessage).Result;
      return requestResponse;
    }

    /// <summary>
    ///  Send Put request
    /// </summary>
    /// <param name="url">Qpi route</param>
    /// <param name="model">Objet model we want ro pass to api in body</param>
    /// <param name="query">Query string</param>
    /// <param name="headers">Request headers</param>
    /// <returns>Response</returns>
    public async Task<ReturnModel<object>> PutAsync(string url, object model = null, string query = null,
      Dictionary<string, string> headers = null)
    {
      HttpRequestMessage requestMessage =
       _requestService.CreateRequestMessageAsync(url, HttpMethod.Put, query, headers, model).Result;

      ReturnModel<object> requestResponse = _requestService.SendRequestAsync<object>(requestMessage).Result;
      return requestResponse;
    }




  }

