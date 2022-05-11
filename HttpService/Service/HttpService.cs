using HttpService.Interface;
using HttpService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpService.Service
{
  public class HttpService : IHttpService
  {
    public Task<ResponseModel<T>> DeleteAsync<T>(string url, Dictionary<string, string>? query = null, Dictionary<string, string>? headers = null)
    {
      throw new NotImplementedException();
    }

    public Task<ResponseModel<T>> DeleteAsync<T>(string url, string query, Dictionary<string, string>? headers = null)
    {
      throw new NotImplementedException();
    }

    public Task<ResponseModel<object>> DeleteAsync(string url, Dictionary<string, string>? query = null, Dictionary<string, string>? headers = null)
    {
      throw new NotImplementedException();
    }

    public Task<ResponseModel<object>> DeleteAsync(string url, string query, Dictionary<string, string>? headers = null)
    {
      throw new NotImplementedException();
    }

    public Task<ResponseModel<T>> GetAsync<T>(string url, Dictionary<string, string>? query = null, Dictionary<string, string>? headers = null)
    {
      throw new NotImplementedException();
    }

    public Task<ResponseModel<T>> GetAsync<T>(string url, string query, Dictionary<string, string>? headers = null)
    {
      throw new NotImplementedException();
    }

    public Task<ResponseModel<object>> GetAsync(string url, Dictionary<string, string>? query = null, Dictionary<string, string>? headers = null)
    {
      throw new NotImplementedException();
    }

    public Task<ResponseModel<object>> GetAsync(string url, string query, Dictionary<string, string>? headers = null)
    {
      throw new NotImplementedException();
    }

    public Task<ResponseModel<T>> PatchAsync<T>(string url, object model, Dictionary<string, string>? query = null, Dictionary<string, string>? headers = null)
    {
      throw new NotImplementedException();
    }

    public Task<ResponseModel<T>> PatchAsync<T>(string url, object model, string query, Dictionary<string, string>? headers = null)
    {
      throw new NotImplementedException();
    }

    public Task<ResponseModel<object>> PatchAsync(string url, object model, Dictionary<string, string>? query = null, Dictionary<string, string>? headers = null)
    {
      throw new NotImplementedException();
    }

    public Task<ResponseModel<object>> PatchAsync(string url, object model, string query, Dictionary<string, string>? headers = null)
    {
      throw new NotImplementedException();
    }

    public Task<ResponseModel<T>> PostAsync<T>(string url, object model, Dictionary<string, string>? query = null, Dictionary<string, string>? headers = null)
    {
      throw new NotImplementedException();
    }

    public Task<ResponseModel<T>> PostAsync<T>(string url, object model, string query, Dictionary<string, string>? headers)
    {
      throw new NotImplementedException();
    }

    public Task<ResponseModel<object>> PostAsync(string url, object model, Dictionary<string, string>? query = null, Dictionary<string, string>? headers = null)
    {
      throw new NotImplementedException();
    }

    public Task<ResponseModel<object>> PostAsync(string url, object model, string query, Dictionary<string, string>? headers = null)
    {
      throw new NotImplementedException();
    }

    public Task<ResponseModel<T>> PutAsync<T>(string url, object model, Dictionary<string, string>? query = null, Dictionary<string, string>? headers = null)
    {
      throw new NotImplementedException();
    }

    public Task<ResponseModel<T>> PutAsync<T>(string url, object model, string query, Dictionary<string, string>? headers = null)
    {
      throw new NotImplementedException();
    }

    public Task<ResponseModel<object>> PutAsync(string url, object model, Dictionary<string, string>? query = null, Dictionary<string, string>? headers = null)
    {
      throw new NotImplementedException();
    }

    public Task<ResponseModel<object>> PutAsync(string url, object model, string query, Dictionary<string, string>? headers = null)
    {
      throw new NotImplementedException();
    }
  }
}
