using HttpService.Interface;

namespace HttpService.Service;

//The HttpService Patch Methods
public partial class HttpService : IHttpService
  {
    /// <summary>
    ///  Send Patch request and serialize the api response model to T
    /// </summary>
    /// <typeparam name="T">Api response would be serialied to T</typeparam>
    /// <param name="url">Qpi route</param>
    /// <param name="model">Objet model we want ro pass to api in body</param>
    /// <param name="query">Query string</param>
    /// <param name="headers">Request headers</param>
    /// <returns>Response model of T</returns>
    public async Task<ResponseBase<T>> PatchAsync<T>(string url, object model = null,
      Dictionary<string, string>? query = null,
      Dictionary<string, string>? headers = null)
    {
      HttpRequestMessage requestMessage =
       await _requestService.CreateRequestMessageAsync(url, HttpMethod.Patch, query, headers, model);

      ResponseBase<T> requestResponse =await _requestService.SendRequestAsync<T>(requestMessage);
      return requestResponse;
    }

    /// <summary>
    ///  Send Patch request and serialize the api response model to T
    /// </summary>
    /// <typeparam name="T">Api response would be serialied to T</typeparam>
    /// <param name="url">Qpi route</param>
    /// <param name="model">Objet model we want ro pass to api in body</param>
    /// <param name="query">Query string</param>
    /// <param name="headers">Request headers</param>
    /// <returns>Response model of T</returns>
    public async Task<ResponseBase<T>> PatchAsync<T>(string url, object model = null, string query = null,
      Dictionary<string, string> headers = null)
    {
      HttpRequestMessage requestMessage =
       await _requestService.CreateRequestMessageAsync(url, HttpMethod.Patch, query, headers, model);

      ResponseBase<T> requestResponse = await _requestService.SendRequestAsync<T>(requestMessage);
      return requestResponse;
    }

    /// <summary>
    ///  Send Patch request
    /// </summary>
    /// <param name="url">Qpi route</param>
    /// <param name="model">Objet model we want ro pass to api in body</param>
    /// <param name="query">Query string</param>
    /// <param name="headers">Request headers</param>
    /// <returns>Response model</returns>
    public async Task<ResponseBase<object>> PatchAsync(string url, object model = null,
      Dictionary<string, string> query = null,
      Dictionary<string, string> headers = null)
    {
      HttpRequestMessage requestMessage =
        await _requestService.CreateRequestMessageAsync(url, HttpMethod.Patch, query, headers, model);

      ResponseBase<object> requestResponse = await _requestService.SendRequestAsync<object>(requestMessage);
      return requestResponse;
    }

    /// <summary>
    ///  Send Patch request
    /// </summary>
    /// <param name="url">Qpi route</param>
    /// <param name="model">Objet model we want ro pass to api in body</param>
    /// <param name="query">Query string</param>
    /// <param name="headers">Request headers</param>
    /// <returns>Response model</returns>
    public async Task<ResponseBase<object>> PatchAsync(string url, object model = null, string query = null,
      Dictionary<string, string> headers = null)
    {
      HttpRequestMessage requestMessage =
       await _requestService.CreateRequestMessageAsync(url, HttpMethod.Patch, query, headers, model);

      ResponseBase<object> requestResponse =await _requestService.SendRequestAsync<object>(requestMessage);
      return requestResponse;
    }


}

