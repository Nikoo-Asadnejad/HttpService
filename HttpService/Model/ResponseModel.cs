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
    public T? Model { get; set; }


    public ResponseModel()
    {

    }

    public ResponseModel(HttpStatusCode httpStatusCode , T? model, string systemMessage = null)
    {
      HttpStatusCode = httpStatusCode;
      SystemMessage = systemMessage;
      Model = model;
    }

    public ResponseModel(HttpStatusCode httpStatusCode,  string systemMessage = null)
    {
      HttpStatusCode = httpStatusCode;
      SystemMessage = systemMessage;
    }

  }
}
