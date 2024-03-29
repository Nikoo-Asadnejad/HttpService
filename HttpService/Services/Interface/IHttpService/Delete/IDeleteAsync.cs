namespace HttpService.Services.Interface.IHttpService;
  public partial interface IHttpService
  {
  Task<ResponseBase<T>> DeleteAsync<T>(string url,
      Dictionary<string, string>? query = null,
      Dictionary<string, string>? headers = null);

  Task<ResponseBase<T>> DeleteAsync<T>(string url,
      string query,
      Dictionary<string, string>? headers = null);


  Task<ResponseBase<object>> DeleteAsync(string url,
      Dictionary<string, string>? query = null,
      Dictionary<string, string>? headers = null);

  Task<ResponseBase<object>> DeleteAsync(string url,
      string query, Dictionary<string, string>? headers = null);
  }

