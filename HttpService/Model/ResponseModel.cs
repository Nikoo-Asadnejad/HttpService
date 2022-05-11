using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HttpService.Model
{
  public class ResponseModel<T>
  {
    public HttpStatusCode HttpStatusCode { get; set; }
    public string SystemMessage { get; set; }
    public T? ResponseData { get; set; }
    public string Message { get; set; }
  }
}
