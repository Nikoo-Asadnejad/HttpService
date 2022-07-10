using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HttpService.Model;
public class ResponseModel<T>
  {
    public HttpStatusCode HttpStatusCode { get; set; }
    public T? Data { get; set; }
    public string DataTitle { get; set; }
    public string SystemMessage { get; set; }
    public string Message { get; set; }
    public dynamic Errors { get; set; }
    
    public ResponseModel()
    {

    }

    public ResponseModel(HttpStatusCode httpStatusCode , T? data,
                          string message = null , string systemMessage = null ,
                          dynamic errors = null)
    {
      HttpStatusCode = httpStatusCode;
      SystemMessage = systemMessage;
      Data = data;
      Message = message;
      Errors = errors;
    }

    public ResponseModel(HttpStatusCode httpStatusCode,string message = null,
                        string systemMessage = null , dynamic errors = null)
    {
      HttpStatusCode = httpStatusCode;
      SystemMessage = systemMessage;
      Message = message;
      Errors = errors;
    }

    public void CreateSuccessModel(T data, string title = null, string message = null)
    {
      this.Data = data;
      this.HttpStatusCode = HttpStatusCode.OK;
      this.DataTitle = title is null ? this.DataTitle :  title;
      this.Message = message == null ? ReturnMessages.SuccessMessage : message;
    }

    public void CreateCreatedModel(T data, string title = null, string message = null)
    {
      this.Data = data;
      this.HttpStatusCode = HttpStatusCode.Created;
      this.DataTitle = title is null ? this.DataTitle : title;
      this.Message = message == null ? ReturnMessages.CreatedMessage : message;
    }

    public void CreateNotFoundModel(string title = null, string message = null , string systemMessage = null)
    {
      this.HttpStatusCode = HttpStatusCode.NotFound;
      this.DataTitle = title is null ? this.DataTitle : title;
      this.Message = message == null ? ReturnMessages.NotFoundMessage : message;
    }

    public void CreateServerErrorModel(string title = null, string message = null , string systemMessage = null)
    {
      this.HttpStatusCode = HttpStatusCode.InternalServerError;
      this.DataTitle = title is null ? this.DataTitle : title;
      this.Message = message == null ? ReturnMessages.InternalServerErrorMessage : message;
      this.SystemMessage = systemMessage is null ? this.SystemMessage : systemMessage;
    }

    public void CreateBadRequestModel(string title = null, string message = null )
    {
      this.HttpStatusCode = HttpStatusCode.BadRequest;
      this.DataTitle = title is null ? this.DataTitle : title;
      this.Message = message == null ? ReturnMessages.InternalServerErrorMessage : message;

    }

    public void CreateInvalidInputErrorModel(string title = null, string message = null ,
      List<FieldErrorsModel> fieldErrors = null)
    {
      this.HttpStatusCode = HttpStatusCode.BadRequest;
      this.DataTitle = title is null ? this.DataTitle : title;
      this.Message = message is null ? ReturnMessages.InvalidInputErrorMessage : message;
      this.Errors = fieldErrors;
    }

    public void CreateDuplicatedErrorModel(string title = null, string message = null)
    {
      this.HttpStatusCode = HttpStatusCode.BadRequest;
      this.DataTitle = title;
      this.Message = message == null ? ReturnMessages.DuplicationErrorMessage : message;
    }

  }

