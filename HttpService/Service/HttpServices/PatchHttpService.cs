using HttpService.Interface;
using HttpService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpService.Service
{
  //Patch
  public partial class HttpService : IHttpService
  {
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="url"></param>
    /// <param name="model"></param>
    /// <param name="query"></param>
    /// <param name="headers"></param>
    /// <returns></returns>
    public async Task<ResponseModel<T>> PatchAsync<T>(string url, object model,
      Dictionary<string, string>? query = null,
      Dictionary<string, string>? headers = null)
    {
      HttpRequestMessage requestMessage =
        _requestService.CreateRequestMessageAsync<T>(url, HttpMethod.Patch, query, headers, model).Result;

      ResponseModel<T> requestResponse = _requestService.SendRequestAsync<T>(requestMessage).Result;
      return requestResponse;
    }

    public async Task<ResponseModel<T>> PatchAsync<T>(string url, object model, string query,
      Dictionary<string, string>? headers = null)
    {
      HttpRequestMessage requestMessage =
        _requestService.CreateRequestMessageAsync<T>(url, HttpMethod.Patch, query, headers, model).Result;

      ResponseModel<T> requestResponse = _requestService.SendRequestAsync<T>(requestMessage).Result;
      return requestResponse;
    }

    public async Task<ResponseModel<object>> PatchAsync(string url, object model,
      Dictionary<string, string>? query = null,
      Dictionary<string, string>? headers = null)
    {
      HttpRequestMessage requestMessage =
        _requestService.CreateRequestMessageAsync<object>(url, HttpMethod.Patch, query, headers, model).Result;

      ResponseModel<object> requestResponse = _requestService.SendRequestAsync<object>(requestMessage).Result;
      return requestResponse;
    }

    public async Task<ResponseModel<object>> PatchAsync(string url, object model, string query,
      Dictionary<string, string>? headers = null)
    {
      HttpRequestMessage requestMessage =
        _requestService.CreateRequestMessageAsync<object>(url, HttpMethod.Patch, query, headers, model).Result;

      ResponseModel<object> requestResponse = _requestService.SendRequestAsync<object>(requestMessage).Result;
      return requestResponse;
    }


    public async Task<ResponseModel<T>> PatchAsync<T>(string url,
     Dictionary<string, string>? query = null,
     Dictionary<string, string>? headers = null)
    {
      HttpRequestMessage requestMessage =
        _requestService.CreateRequestMessageAsync<T>(url, HttpMethod.Patch, query, headers, null).Result;

      ResponseModel<T> requestResponse = _requestService.SendRequestAsync<T>(requestMessage).Result;
      return requestResponse;
    }

    public async Task<ResponseModel<T>> PatchAsync<T>(string url, string query,
      Dictionary<string, string>? headers = null)
    {
      HttpRequestMessage requestMessage =
        _requestService.CreateRequestMessageAsync<T>(url, HttpMethod.Patch, query, headers, null).Result;

      ResponseModel<T> requestResponse = _requestService.SendRequestAsync<T>(requestMessage).Result;
      return requestResponse;
    }

    public async Task<ResponseModel<object>> PatchAsync(string url,
      Dictionary<string, string>? query = null,
      Dictionary<string, string>? headers = null)
    {
      HttpRequestMessage requestMessage =
        _requestService.CreateRequestMessageAsync<object>(url, HttpMethod.Patch, query, headers, null).Result;

      ResponseModel<object> requestResponse = _requestService.SendRequestAsync<object>(requestMessage).Result;
      return requestResponse;
    }

    public async Task<ResponseModel<object>> PatchAsync(string url, string query,
      Dictionary<string, string>? headers = null)
    {
      HttpRequestMessage requestMessage =
        _requestService.CreateRequestMessageAsync<object>(url, HttpMethod.Patch, query, headers, null).Result;

      ResponseModel<object> requestResponse = _requestService.SendRequestAsync<object>(requestMessage).Result;
      return requestResponse;
    }


  }
}
