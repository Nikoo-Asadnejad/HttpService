using HttpService.FixValues;
using HttpService.Interface;

namespace HttpService.Service;

//The HttpService PatchFormDataAsync Methods
public partial class HttpService : IHttpService
{
  /// <summary>
  ///  Patchs model as multiPartFormData and serialize the api response model to T
  /// </summary>
  /// <typeparam name="T">Api response would be serialied to T</typeparam>
  /// <param name="url">Api route</param>
  /// <param name="model">Objet model we want ro pass to api in body</param>
  /// <param name="query">Query string</param>
  /// <param name="headers">Request headers</param>
  /// <returns>Response model of T</returns>
  public async Task<ResponseBase<T>> PatchFormDataAsync<T>(string url,
    object model,
    Dictionary<string, string>? query = null,
    Dictionary<string, string>? headers = null)
  {
    HttpRequestMessage requestMessage =
      await _requestService.CreateRequestMessageAsync(url, HttpMethod.Patch, query, headers, model, MediaTypes.FormData);

    ResponseBase<T> requestResponse = await _requestService.SendRequestAsync<T>(requestMessage);
    return requestResponse;
  }

  /// <summary>
  ///  Patchs model as multiPartFormData serialize the api response model to T
  /// </summary>
  /// <typeparam name="T">Api response would be serialied to T</typeparam>
  /// <param name="url">Qpi route</param>
  /// <param name="model">Objet model we want ro pass to api in body</param>
  /// <param name="query">Query string</param>
  /// <param name="headers">Request headers</param>
  /// <returns>Response model of T</returns>
  public async Task<ResponseBase<T>> PatchFormDataAsync<T>(string url,
    object model,
    string? query = null,
    Dictionary<string, string>? headers = null)
  {
    HttpRequestMessage requestMessage =
     await _requestService.CreateRequestMessageAsync(url, HttpMethod.Patch, query, headers, model, MediaTypes.FormData);

    ResponseBase<T> requestResponse = await _requestService.SendRequestAsync<T>(requestMessage);
    return requestResponse;
  }

  /// <summary>
  ///  Patchs model as multiPartFormData
  /// </summary>
  /// <param name="url">Api route</param>
  /// <param name="model">Objet model we want ro pass to api in body</param>
  /// <param name="query">Query string</param>
  /// <param name="headers">Request headers</param>
  /// <returns>Response model</returns>
  public async Task<ResponseBase<object>> PatchFormDataAsync(string url,
    object model,
    Dictionary<string, string>? query = null,
    Dictionary<string, string>? headers = null)
  {
    HttpRequestMessage requestMessage =
     await _requestService.CreateRequestMessageAsync(url, HttpMethod.Patch, query, headers, model, MediaTypes.FormData);

    ResponseBase<object> requestResponse = await _requestService.SendRequestAsync<object>(requestMessage);
    return requestResponse;
  }

  /// <summary>
  ///  Patchs model as multiPartFormData
  /// </summary>
  /// <param name="url">Api route</param>
  /// <param name="model">Objet model we want ro pass to api in body</param>
  /// <param name="query">Query string</param>
  /// <param name="headers">Request headers</param>
  /// <returns>Response model</returns>
  public async Task<ResponseBase<object>> PatchFormDataAsync(string url,
    object model,
    string? query = null,
    Dictionary<string, string>? headers = null)
  {
    HttpRequestMessage requestMessage =
      await _requestService.CreateRequestMessageAsync(url, HttpMethod.Patch, query, headers, model, MediaTypes.FormData);

    ResponseBase<object> requestResponse = await _requestService.SendRequestAsync<object>(requestMessage);
    return requestResponse;
  }





}

