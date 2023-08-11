namespace HttpService.Interface;
public partial interface IHttpService 
  {

    Task<ResponseBase<T>> PutAsync<T>(string url, object model, Dictionary<string, string>? query = null,
                                      Dictionary<string, string>? headers = null);
    Task<ResponseBase<T>> PutAsync<T>(string url, object model, string query,
                                      Dictionary<string, string>? headers = null);
    Task<ResponseBase<object>> PutAsync(string url, object model, Dictionary<string, string>? query = null,
                                        Dictionary<string, string>? headers = null);
    Task<ResponseBase<object>> PutAsync(string url, object model, string query,
                                        Dictionary<string, string>? headers = null);





  }

