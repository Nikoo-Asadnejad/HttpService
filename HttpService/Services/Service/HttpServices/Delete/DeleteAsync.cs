using HttpService.Interface;

namespace HttpService.Service;
 //The HttpService Delete Methods
public partial class HttpService : IHttpService
  {

    /// <summary>
    ///  Send Delete request and serialize the api response model to T
    /// </summary>
    /// <typeparam name="T">Api response would be serialied to T</typeparam>
    /// <param name="url">Api route</param>
    /// <param name="query">Query string</param>
    /// <param name="headers">Request headers</param>
    /// <returns>Response model of T</returns>
    public async Task<ResponseBase<T>> DeleteAsync<T>(string url,
      Dictionary<string, string>? query = null,
      Dictionary<string, string>? headers = null)
    {
      HttpRequestMessage requestMessage =
        await _requestService.CreateRequestMessageAsync(url, HttpMethod.Delete, query, headers, null);


      ResponseBase<T> requestResponse = await _requestService.SendRequestAsync<T>(requestMessage);
      return requestResponse;
    }

    /// <summary>
    ///  Send Delete request and serialize the api response model to T
    /// </summary>
    /// <typeparam name="T">Api response would be serialied to T</typeparam>
    /// <param name="url">Api route</param>
    /// <param name="query">Query string</param>
    /// <param name="headers">Request headers</param>
    /// <returns>Response model of T</returns>
    public async Task<ResponseBase<T>> DeleteAsync<T>(string url,
      string query,
      Dictionary<string, string>? headers = null)
    {

      HttpRequestMessage requestMessage =
        await _requestService.CreateRequestMessageAsync(url, HttpMethod.Delete, query, headers, null);

      ResponseBase<T> requestResponse =await _requestService.SendRequestAsync<T>(requestMessage);
      return requestResponse;
    }

    /// <summary>
    ///  Send Delete request 
    /// </summary>
    /// <param name="url">Api route</param>
    /// <param name="query">Query string</param>
    /// <param name="headers">Request headers</param>
    /// <returns>Response model</returns>
    public async Task<ResponseBase<object>> DeleteAsync(string url,
      Dictionary<string, string>? query = null,
      Dictionary<string, string>? headers = null)
    {
      HttpRequestMessage requestMessage =
       await _requestService.CreateRequestMessageAsync(url, HttpMethod.Delete, query, headers, null);

      ResponseBase<object> requestResponse = await _requestService.SendRequestAsync<object>(requestMessage);
      return requestResponse;
    }

    /// <summary>
    ///  Send Delete request 
    /// </summary>
    /// <param name="url">Api route</param>
    /// <param name="query">Query string</param>
    /// <param name="headers">Request headers</param>
    /// <returns>Response model</returns>
    public async Task<ResponseBase<object>> DeleteAsync(string url,
      string query, Dictionary<string, string>? headers = null)
    {
      HttpRequestMessage requestMessage =
       await  _requestService.CreateRequestMessageAsync(url, HttpMethod.Delete, query, headers, null);

      ResponseBase<object> requestResponse = await _requestService.SendRequestAsync<object>(requestMessage);
      return requestResponse;
    }
  }

