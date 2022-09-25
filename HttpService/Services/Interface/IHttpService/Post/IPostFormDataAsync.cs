 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpService.Interface;

public partial interface IHttpService
{
  Task<ReturnModel<T>> PostFromDataAsync<T>(string url, object model = null,
    Dictionary<string, string> query = null,
    Dictionary<string, string> headers = null);

  Task<ReturnModel<T>> PostFromDataAsync<T>(string url, object model = null, string query = null,
    Dictionary<string, string> headers = null);

  Task<ReturnModel<object>> PostFromDataAsync(string url, object model = null,
    Dictionary<string, string> query = null,
    Dictionary<string, string> headers = null);

  Task<ReturnModel<object>> PostFromDataAsync(string url, object model = null, string query = null,
    Dictionary<string, string> headers = null);
}

