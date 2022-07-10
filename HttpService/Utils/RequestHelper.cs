using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpService.Utils
{
  public static class RequestHelper
  {
    /// <summary>
    /// Add required headers to the request message
    /// </summary>
    /// <param name="reqMessage">Configured HttpRequestMessage for http client</param>
    /// <param name="headers">KeyValue pairs of headers</param>
    public async static Task AddHeadersAsync(this HttpRequestMessage reqMessage, Dictionary<string, string> headers)
    {
      foreach (var header in headers ?? new Dictionary<string, string>())
        reqMessage.Headers.Add(header.Key, header.Value);
    }

    public async static Task<Dictionary<string, string>> CheckHeadersAsync(this Dictionary<string, string> headers)
    {

      if (headers == null)
        return null;

      foreach (var item in headers)
      {
        if (String.IsNullOrEmpty(item.Key) || String.IsNullOrEmpty(item.Value))
          headers.Remove(item.Key);
      }

      return headers;
    }

    public async static Task<Dictionary<string, string>> CheckQueryAsync(this Dictionary<string, string> query)
    {

      if(query == null)
        return null;

      foreach(var item in query)
      {
        if(String.IsNullOrEmpty(item.Key) || String.IsNullOrEmpty(item.Value))
          query.Remove(item.Key);
      }

      return query;
    }

    public  async static Task<string> CheckQueryAsync(this string query)
    {

      if (query == null)
        return null;

      if (!query.StartsWith("?"))
        query = "?" + query;

      return query;

    }

  }
}
