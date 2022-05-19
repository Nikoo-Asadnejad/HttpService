using HttpService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpService.Interface
{
  public partial interface IHttpService
  {
    Task<ResponseModel<T>> DeleteAsync<T>(string url, Dictionary<string, string>? query = null,
                                        Dictionary<string, string>? headers = null);

    Task<ResponseModel<T>> DeleteAsync<T>(string url, string query,
                                          Dictionary<string, string>? headers = null);

    Task<ResponseModel<object>> DeleteAsync(string url, Dictionary<string, string>? query = null,
                                            Dictionary<string, string>? headers = null);

    Task<ResponseModel<object>> DeleteAsync(string url, string query,
                                           Dictionary<string, string>? headers = null);
  }
}
