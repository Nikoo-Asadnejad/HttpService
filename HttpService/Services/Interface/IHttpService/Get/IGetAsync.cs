namespace HttpService.Interface;
public partial interface IHttpService
  {
    Task<ResponseBase<T>> GetAsync<T>(string url, Dictionary<string,string>? query = null,
                                      Dictionary<string, string>? headers = null);
    Task<ResponseBase<T>> GetAsync<T>(string url, string query,
                                      Dictionary<string, string>? headers = null);
    Task<ResponseBase<object>> GetAsync(string url, Dictionary<string, string>? query = null,
                                        Dictionary<string, string>? headers = null);
    Task<ResponseBase<object>> GetAsync(string url, string query,
                                        Dictionary<string, string>? headers = null);


   

  }
