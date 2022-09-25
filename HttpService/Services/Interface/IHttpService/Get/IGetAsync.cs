 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpService.Interface;
public partial interface IHttpService
  {
    Task<ReturnModel<T>> GetAsync<T>(string url, Dictionary<string,string>? query = null,
                                      Dictionary<string, string>? headers = null);
    Task<ReturnModel<T>> GetAsync<T>(string url, string query,
                                      Dictionary<string, string>? headers = null);
    Task<ReturnModel<object>> GetAsync(string url, Dictionary<string, string>? query = null,
                                        Dictionary<string, string>? headers = null);
    Task<ReturnModel<object>> GetAsync(string url, string query,
                                        Dictionary<string, string>? headers = null);


   

  }
