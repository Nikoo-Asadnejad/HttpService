using HttpService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpService.Interface;

public partial interface IHttpService
{
  Task<ResponseModel<T>> PostFromDataAsync<T>(string url, object model = null,
    Dictionary<string, string> query = null,
    Dictionary<string, string> headers = null);

  Task<ResponseModel<T>> PostFromDataAsync<T>(string url, object model = null, string query = null,
    Dictionary<string, string> headers = null);

  Task<ResponseModel<object>> PostFromDataAsync(string url, object model = null,
    Dictionary<string, string> query = null,
    Dictionary<string, string> headers = null);

  Task<ResponseModel<object>> PostFromDataAsync(string url, object model = null, string query = null,
    Dictionary<string, string> headers = null);
}

