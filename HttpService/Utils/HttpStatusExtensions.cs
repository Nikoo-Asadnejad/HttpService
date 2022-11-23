using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HttpService.Utils;
public static class HttpStatusExtensions
{
  public static bool IsSuccessfulll(this HttpStatusCode httpStatusCode)
  => (int)httpStatusCode >= 200 && (int)httpStatusCode < 300;
  public static bool IsRedirected(this HttpStatusCode httpStatusCode)
  => (int)httpStatusCode >= 300 && (int)httpStatusCode < 400;
  public static bool IsError(this HttpStatusCode httpStatusCode)
  => (int) httpStatusCode >= 400 && (int) httpStatusCode < 500;
  public static bool IsServerError(this HttpStatusCode httpStatusCode)
  => (int)httpStatusCode >= 500 && (int)httpStatusCode < 600;

  public static bool IsSuccessfulll(this int httpStatusCode)
 => (int)httpStatusCode >= 200 && (int)httpStatusCode < 300;
  public static bool IsRedirected(this int httpStatusCode)
  => (int)httpStatusCode >= 300 && (int)httpStatusCode < 400;
  public static bool IsError(this int httpStatusCode)
  => (int)httpStatusCode >= 400 && (int)httpStatusCode < 500;
  public static bool IsServerError(this int httpStatusCode)
  => (int)httpStatusCode >= 500 && (int)httpStatusCode < 600;
}

