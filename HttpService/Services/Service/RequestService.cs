using HttpService.Interface;
using HttpService.Model;
using HttpService.Utils;
using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using HttpService.FixValues;
namespace HttpService.Service
{
  public class RequestService : IRequestService
  {


    private readonly IHttpClientFactory _httpClientFactory;
    private readonly HttpClient _httpClient;

    public RequestService(IHttpClientFactory httpClientFactory)
    {
      _httpClientFactory = httpClientFactory;
      _httpClient = _httpClientFactory.CreateClient();
    }

    /// <summary>
    /// Send a Http Request 
    /// </summary>
    /// <typeparam name="T">Api response will be serialied to T</typeparam>
    /// <param name="requestMessage">HttpRequestMessage we have created for our request</param>
    /// <returns> ResponseModel of T</returns>
    public async Task<ResponseModel<T>> SendRequestAsync<T>(HttpRequestMessage requestMessage)
    {
      
      var request = _httpClient.SendAsync(requestMessage).Result;

      if(request.Content.Headers.ContentType.MediaType is FixStrings.MediaTypes.JsonUTF8MediaType)
      {
        var response = request.Content.ReadAsStringAsync().Result;
        ResponseModel<T> responseModel = new(request.StatusCode, response.Deserialize<T>());
        return responseModel;
      }
      else
      {
        ResponseModel<T> responseModel = new(HttpStatusCode.UnsupportedMediaType);
        return responseModel;
      }
      

      
    }

    /// <summary>
    /// Creates a HttpRequestMessage 
    /// </summary>
    /// <param name="url">Api Route</param>
    /// <param name="httpMethod">Http Method</param>
    /// <param name="query">Query as dictionary object</param>
    /// <param name="headers">Request Headers</param>
    /// <param name="model">Object model we want to pass through our request body</param>
    /// <returns>HttpRequestMessage</returns>
    public async  Task<HttpRequestMessage> CreateRequestMessageAsync( string url, HttpMethod httpMethod,
                                                          Dictionary<string, string>? query,
                                                          Dictionary<string, string>? headers, object model)
    {
      if (query is not null)
      {
        query = await query.CheckQueryAsync();
        url = QueryHelpers.AddQueryString(url, query);
      }
      HttpRequestMessage requestMessage = SetUpHttpRequest(url, httpMethod, headers, model).Result;
      return requestMessage;
    }
    /// <summary>
    /// Creates a HttpRequestMessage 
    /// </summary>
    /// <param name="url">Api Route</param>
    /// <param name="httpMethod">Http Method</param>
    /// <param name="query">Query as string</param>
    /// <param name="headers">Request Headers</param>
    /// <param name="model">Object model we want to pass through our request body</param>
    /// <returns>HttpRequestMessage</returns>
    public async  Task<HttpRequestMessage> CreateRequestMessageAsync(string url,
                                                          HttpMethod httpMethod,
                                                          string query,
                                                          Dictionary<string, string>? headers, object model)
    {
      if (query is not null)
      {
        query = await query.CheckQueryAsync();
        url += query;
      }
      HttpRequestMessage requestMessage = SetUpHttpRequest(url, httpMethod, headers, model).Result;

      return requestMessage;
    }

    private async Task<HttpRequestMessage> SetUpHttpRequest(string url,
                                                          HttpMethod httpMethod,
                                                          Dictionary<string, string>? headers, object model)
    {
      HttpRequestMessage requestMessage = new(httpMethod, url);
      MediaTypeWithQualityHeaderValue mediaType = new(FixStrings.MediaTypes.JsonUTF8MediaType);
      requestMessage.Headers.Accept.Add(mediaType);

      if (headers is not null)
      {
        headers = await headers.CheckHeadersAsync();
        await requestMessage.AddHeadersAsync(headers);
      }

      if (model is not null)
        requestMessage.Content = new StringContent(model.Serialize<object>(), Encoding.UTF8, FixStrings.MediaTypes.JsonMediaType);

      return requestMessage;

    }

  }
}
