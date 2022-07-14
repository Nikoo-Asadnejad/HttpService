using HttpService.Interface;
using HttpService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpService.Service;

//The HttpService Get Methods
public partial class HttpService : IHttpService
  {


    /// <summary>
    ///  Send Get request and serialize the api response model to T
    /// </summary>
    /// <typeparam name="T">Api response would be serialied to T</typeparam>
    /// <param name="url">Api route</param>
    /// <param name="query">Query string</param>
    /// <param name="headers">Request headers</param>
    /// <returns>Response model of T</returns>
    public async Task<ResponseModel<T>> GetAsync<T>(string url,
      Dictionary<string, string> query = null,
      Dictionary<string, string> headers = null)
    {

      HttpRequestMessage requestMessage =
        _requestService.CreateRequestMessageAsync(url, HttpMethod.Get, query, headers, null).Result;

      ResponseModel<T> requestResponse = _requestService.SendRequestAsync<T>(requestMessage).Result;
      return requestResponse;
    }

    /// <summary>
    ///  Send Get request and serialize the api response model to T
    /// </summary>
    /// <typeparam name="T">Api response would be serialied to T</typeparam>
    /// <param name="url">Api route</param>
    /// <param name="query">Query string</param>
    /// <param name="headers">Request headers</param>
    /// <returns>Response model of T</returns>
    public async Task<ResponseModel<T>> GetAsync<T>(string url, string query = null,
      Dictionary<string, string> headers = null)
    {
        HttpRequestMessage requestMessage =
        _requestService.CreateRequestMessageAsync(url, HttpMethod.Get, query, headers, null).Result;

        ResponseModel<T> requestResponse = _requestService.SendRequestAsync<T>(requestMessage).Result;
        return requestResponse;
    }

    /// <summary>
    ///  Send Get request 
    /// </summary>
    /// <param name="url">Api route</param>
    /// <param name="query">Query string</param>
    /// <param name="headers">Request headers</param>
    /// <returns>Response model</returns>
    public async Task<ResponseModel<object>> GetAsync(string url,
      Dictionary<string, string> query = null,
      Dictionary<string, string> headers = null)
    {
      HttpRequestMessage requestMessage =
        _requestService.CreateRequestMessageAsync(url, HttpMethod.Get, query, headers, null).Result;

      ResponseModel<object> requestResponse = _requestService.SendRequestAsync<object>(requestMessage).Result;
      return requestResponse;
    }

    /// <summary>
    ///  Send Get request 
    /// </summary>
    /// <param name="url">Api route</param>
    /// <param name="query">Query string</param>
    /// <param name="headers">Request headers</param>
    /// <returns>Response model</returns>
    public async Task<ResponseModel<object>> GetAsync(string url, string query = null,
      Dictionary<string, string>? headers = null)
    {

      HttpRequestMessage requestMessage =
        _requestService.CreateRequestMessageAsync(url, HttpMethod.Get, query, headers, null).Result;

      ResponseModel<object> requestResponse = _requestService.SendRequestAsync<object>(requestMessage).Result;
      return requestResponse;
    }

  }

