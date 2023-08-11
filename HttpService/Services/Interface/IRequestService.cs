using HttpService.FixValues;
 


namespace HttpService.Interface;
public interface IRequestService
  {

    
    Task<ResponseBase<T>> SendRequestAsync<T>(HttpRequestMessage requestMessage);

    

    Task<HttpRequestMessage> CreateRequestMessageAsync(string url, HttpMethod httpMethod,
                                                          Dictionary<string, string>? query,
                                                          Dictionary<string, string>? headers, object model,
                                                          string mediaType = MediaTypes.Json);

    Task<HttpRequestMessage> CreateRequestMessageAsync(string url,
                                                          HttpMethod httpMethod,
                                                          string query,
                                                          Dictionary<string, string>? headers, object model,
                                                          string mediaType = MediaTypes.Json);




}
