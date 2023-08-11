namespace HttpService.Interface;

public partial interface IHttpService
{
  Task<ResponseBase<T>> PostFromDataAsync<T>(string url, object model = null,
    Dictionary<string, string> query = null,
    Dictionary<string, string> headers = null);

  Task<ResponseBase<T>> PostFromDataAsync<T>(string url, object model = null, string query = null,
    Dictionary<string, string> headers = null);

  Task<ResponseBase<object>> PostFromDataAsync(string url, object model = null,
    Dictionary<string, string> query = null,
    Dictionary<string, string> headers = null);

  Task<ResponseBase<object>> PostFromDataAsync(string url, object model = null, string query = null,
    Dictionary<string, string> headers = null);
}

