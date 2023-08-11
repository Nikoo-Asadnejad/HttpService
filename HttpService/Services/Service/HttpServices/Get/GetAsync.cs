using HttpService.Interface;
 

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
  public async Task<ResponseBase<T>> GetAsync<T>(string url,
    Dictionary<string, string> query = null,
    Dictionary<string, string> headers = null)
  {

    HttpRequestMessage requestMessage =
      await _requestService.CreateRequestMessageAsync(url, HttpMethod.Get, query, headers, null);

    ResponseBase<T> requestResponse = await _requestService.SendRequestAsync<T>(requestMessage);
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
  public async Task<ResponseBase<T>> GetAsync<T>(string url,
    string query = null,
    Dictionary<string, string> headers = null)
  {
    HttpRequestMessage requestMessage =
    await _requestService.CreateRequestMessageAsync(url, HttpMethod.Get, query, headers, null);

    ResponseBase<T> requestResponse = await _requestService.SendRequestAsync<T>(requestMessage);
    return requestResponse;
  }

  /// <summary>
  ///  Send Get request 
  /// </summary>
  /// <param name="url">Api route</param>
  /// <param name="query">Query string</param>
  /// <param name="headers">Request headers</param>
  /// <returns>Response model</returns>
  public async Task<ResponseBase<object>> GetAsync(string url,
    Dictionary<string, string> query = null,
    Dictionary<string, string> headers = null)
  {
    HttpRequestMessage requestMessage =
     await  _requestService.CreateRequestMessageAsync(url, HttpMethod.Get, query, headers, null);

    ResponseBase<object> requestResponse = await _requestService.SendRequestAsync<object>(requestMessage);
    return requestResponse;
  }

  /// <summary>
  ///  Send Get request 
  /// </summary>
  /// <param name="url">Api route</param>
  /// <param name="query">Query string</param>
  /// <param name="headers">Request headers</param>
  /// <returns>Response model</returns>
  public async Task<ResponseBase<object>> GetAsync(string url,
    string query = null,
    Dictionary<string, string>? headers = null)
  {

    HttpRequestMessage requestMessage =
     await _requestService.CreateRequestMessageAsync(url, HttpMethod.Get, query, headers, null);

    ResponseBase<object> requestResponse = await _requestService.SendRequestAsync<object>(requestMessage);
    return requestResponse;
  }

}

