using HttpService.Interface;
 
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
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;

namespace HttpService.Service;
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
  /// <returns> ReturnModel of T</returns>
  public async Task<ReturnModel<T>> SendRequestAsync<T>(HttpRequestMessage requestMessage)
  {
    var request = await _httpClient.SendAsync(requestMessage,HttpCompletionOption.ResponseHeadersRead); 
    request.EnsureSuccessStatusCode();
    if (IsContentTypeValid(request.Content.Headers.ContentType))
    {
      var responseStream = await request.Content.ReadAsStreamAsync();
      JsonSerializerOptions? options = new()
      {
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
      };
      T responseData = JsonSerializer.Deserialize<T>(responseStream , options);
      ReturnModel<T> returnModel = new(statusCode :request.StatusCode, data: responseData);
      return returnModel;
    }
    else
    {
      ReturnModel<T> returnModel = new();
      returnModel.CreateUnSupportedMediaType();
      return returnModel;
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
  public async Task<HttpRequestMessage> CreateRequestMessageAsync(string url, HttpMethod httpMethod,
                                                        Dictionary<string, string>? query,
                                                        Dictionary<string, string>? headers, object model,
                                                        string mediaType = MediaTypes.Json)
  {
    if (query is not null)
    {
      query = await query.CheckQueryAsync();
      url = QueryHelpers.AddQueryString(url, query);
    }
    HttpRequestMessage requestMessage = await SetUpHttpRequest(url, httpMethod, headers, model);
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
  public async Task<HttpRequestMessage> CreateRequestMessageAsync(string url,
                                                        HttpMethod httpMethod,
                                                        string? query,
                                                        Dictionary<string, string>? headers, object model,
                                                        string mediaType = MediaTypes.Json)
  {
    if (query is not null)
    {
      query = await query.CheckQueryAsync();
      url += query;
    }
    HttpRequestMessage requestMessage = await SetUpHttpRequest(url, httpMethod, headers, model);

    return requestMessage;
  }
  

  private async Task<HttpRequestMessage> SetUpHttpRequest(string url,
                                                        HttpMethod httpMethod,
                                                        Dictionary<string, string>? headers, object model,
                                                        string mediaType = MediaTypes.UTF8Json)
  {

    

    HttpRequestMessage requestMessage = new(httpMethod, url);
    MediaTypeWithQualityHeaderValue requestMediaType = new(mediaType);

    requestMessage.VersionPolicy = HttpVersionPolicy.RequestVersionOrHigher;
    requestMessage.Version = new Version(2, 1);
    requestMessage.Headers.Accept.Add(requestMediaType);
    if (headers is not null)
    {
      headers = await headers.CheckHeadersAsync();
      await requestMessage.AddHeadersAsync(headers);
    }

    if(model is not null && (mediaType is MediaTypes.Json || mediaType is MediaTypes.UTF8Json))
      requestMessage.Content = new StringContent(model.Serialize<object>(), Encoding.UTF8, MediaTypes.Json);

    if(model is not null &&  (mediaType is MediaTypes.FormData))
      requestMessage.Content = CreateMultiPartFromData(model);

    return requestMessage;

  }


  /// <summary>
  /// Creates a multiPartFormData from the model
  /// </summary>
  /// <param name="model"></param>
  /// <returns></returns>
  private MultipartFormDataContent CreateMultiPartFromData(object model)
  {

    MultipartFormDataContent multipartFormData = new();
    PropertyInfo[] modelProperties = model.GetType().GetProperties();

    foreach (PropertyInfo property in modelProperties)
    {
      var propertyValue = property.GetValue(model);
      var propertyName = property.Name;

      if (property.CanRead && propertyValue != null && property.PropertyType.Name is not "IFormFile"
        && IsCsharpType(propertyValue))
        multipartFormData.Add(new StringContent(propertyValue.ToString()), name: propertyName);

      if (property.CanRead && propertyValue != null && property.PropertyType.Name is not "IFormFile"
        && !IsCsharpType(propertyValue))
        multipartFormData.Add(new StringContent(propertyValue.Serialize()), name: propertyName);

      if (property.CanRead && propertyValue != null && property.PropertyType.Name is "IFormFile")
      {
        IFormFile file = (IFormFile)propertyValue;
        var memory = new MemoryStream();
        file.CopyTo(memory);
        var fileBytes = memory.ToArray();
        var streamContent = new ByteArrayContent(fileBytes, 0, fileBytes.Length);
        streamContent.Headers.Add("Content-Length", file.Length.ToString());
        streamContent.Headers.Add("Content-Type", file.ContentType);
        multipartFormData.Add(streamContent, propertyName, file.FileName);
      }

    }
    return multipartFormData;
  }

  private bool IsContentTypeValid(MediaTypeHeaderValue mediaType)
    => mediaType.MediaType is MediaTypes.Json
     || mediaType.MediaType is MediaTypes.UTF8Json
     || mediaType.MediaType is MediaTypes.FormData;
  private static bool IsCsharpType(object property)
   => property.GetType().IsValueType || property is string;

}

