namespace HttpService.Interface;
public partial interface IHttpService
  {

    Task<ResponseBase<T>> PostAsync<T>(string url, object model, Dictionary<string, string>? query = null,
                                        Dictionary<string, string>? headers = null);
    Task<ResponseBase<T>> PostAsync<T>(string url, object model, string query,
                                        Dictionary<string, string>? headers);
    Task<ResponseBase<object>> PostAsync(string url, object model, Dictionary<string, string>? query = null,
                                          Dictionary<string, string>? headers = null);
    Task<ResponseBase<object>> PostAsync(string url, object model, string query,
                                          Dictionary<string, string>? headers = null);
  }
