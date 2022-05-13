using HttpService.Interface;
using HttpService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpService.Service
{
  //Put
  public partial class HttpService  : IHttpService
  {


    public async Task<ResponseModel<T>> PutAsync<T>(string url, object model,
      Dictionary<string, string>? query = null, Dictionary<string, string>? headers = null)
    {
      HttpRequestMessage requestMessage =
       _requestService.CreateRequestMessageAsync<T>(url, HttpMethod.Put, query, headers, model).Result;

      ResponseModel<T> requestResponse = _requestService.SendRequestAsync<T>(requestMessage).Result;
      return requestResponse;
    }

    public async Task<ResponseModel<T>> PutAsync<T>(string url, object model, string query,
      Dictionary<string, string>? headers = null)
    {
      HttpRequestMessage requestMessage =
       _requestService.CreateRequestMessageAsync<T>(url, HttpMethod.Put, query, headers, model).Result;

      ResponseModel<T> requestResponse = _requestService.SendRequestAsync<T>(requestMessage).Result;
      return requestResponse;
    }

    public async Task<ResponseModel<object>> PutAsync(string url, object model,
      Dictionary<string, string>? query = null, Dictionary<string, string>? headers = null)
    {
      HttpRequestMessage requestMessage =
             _requestService.CreateRequestMessageAsync<object>(url, HttpMethod.Put, query, headers, model).Result;

      ResponseModel<object> requestResponse = _requestService.SendRequestAsync<object>(requestMessage).Result;
      return requestResponse;
    }

    public async Task<ResponseModel<object>> PutAsync(string url, object model, string query,
      Dictionary<string, string>? headers = null)
    {
      HttpRequestMessage requestMessage =
       _requestService.CreateRequestMessageAsync<object>(url, HttpMethod.Put, query, headers, model).Result;

      ResponseModel<object> requestResponse = _requestService.SendRequestAsync<object>(requestMessage).Result;
      return requestResponse;
    }


    public async Task<ResponseModel<T>> PutAsync<T>(string url,
      Dictionary<string, string>? query = null,
      Dictionary<string, string>? headers = null)
    {
      HttpRequestMessage requestMessage =
       _requestService.CreateRequestMessageAsync<T>(url, HttpMethod.Put, query, headers, null).Result;

      ResponseModel<T> requestResponse = _requestService.SendRequestAsync<T>(requestMessage).Result;
      return requestResponse;
    }

    public async Task<ResponseModel<T>> PutAsync<T>(string url, string query,
      Dictionary<string, string>? headers = null)
    {
      HttpRequestMessage requestMessage =
       _requestService.CreateRequestMessageAsync<T>(url, HttpMethod.Put, query, headers, null).Result;

      ResponseModel<T> requestResponse = _requestService.SendRequestAsync<T>(requestMessage).Result;
      return requestResponse;
    }

    public async Task<ResponseModel<object>> PutAsync(string url,
      Dictionary<string, string>? query = null, Dictionary<string, string>? headers = null)
    {
      HttpRequestMessage requestMessage =
             _requestService.CreateRequestMessageAsync<object>(url, HttpMethod.Put, query, headers, null).Result;

      ResponseModel<object> requestResponse = _requestService.SendRequestAsync<object>(requestMessage).Result;
      return requestResponse;
    }

    public async Task<ResponseModel<object>> PutAsync(string url, string query,
      Dictionary<string, string>? headers = null)
    {
      HttpRequestMessage requestMessage =
       _requestService.CreateRequestMessageAsync<object>(url, HttpMethod.Put, query, headers, null).Result;

      ResponseModel<object> requestResponse = _requestService.SendRequestAsync<object>(requestMessage).Result;
      return requestResponse;
    }



  }
}
