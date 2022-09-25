 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpService.Services.Interface.IHttpService;
  public partial interface IHttpService
  {
  Task<ReturnModel<T>> DeleteAsync<T>(string url,
      Dictionary<string, string>? query = null,
      Dictionary<string, string>? headers = null);

  Task<ReturnModel<T>> DeleteAsync<T>(string url,
      string query,
      Dictionary<string, string>? headers = null);


  Task<ReturnModel<object>> DeleteAsync(string url,
      Dictionary<string, string>? query = null,
      Dictionary<string, string>? headers = null);

  Task<ReturnModel<object>> DeleteAsync(string url,
      string query, Dictionary<string, string>? headers = null);
  }

