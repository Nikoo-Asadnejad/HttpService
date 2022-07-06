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
    public string Message { get; set; }
    public dynamic Errors { get; set; }
    public T? Model { get; set; }


    public ResponseModel()
    {

    }

    public ResponseModel(HttpStatusCode httpStatusCode , T? model,
                          string message = null , string systemMessage = null ,
                          dynamic errors = null)
    {
      HttpStatusCode = httpStatusCode;
      SystemMessage = systemMessage;
      Model = model;
      Message = message;
      Errors =errors;
    }

    public ResponseModel(HttpStatusCode httpStatusCode,string message = null,
                        string systemMessage = null , dynamic errors = null)
    {
      HttpStatusCode = httpStatusCode;
      SystemMessage = systemMessage;
      Message = message;
      Errors = errors;
    }



  }
}
