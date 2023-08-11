namespace HttpService.Interface;
public partial interface IHttpService
  {

    Task<ResponseBase<T>> PatchFormDataAsync<T>(string url, object model, Dictionary<string, string>? query = null,
                                        Dictionary<string, string>? headers = null);

    Task<ResponseBase<T>> PatchFormDataAsync<T>(string url, object model, string? query = null,
                                        Dictionary<string, string>? headers = null);
    Task<ResponseBase<object>> PatchFormDataAsync(string url, object model, Dictionary<string, string>? query = null,
                                          Dictionary<string, string>? headers = null);

    Task<ResponseBase<object>> PatchFormDataAsync(string url, object model, string? query = null,
                                          Dictionary<string, string>? headers = null);

  }

