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
      => httpStatusCode is HttpStatusCode.OK ||
         httpStatusCode is HttpStatusCode.NoContent ||
         httpStatusCode is HttpStatusCode.Created ||
         httpStatusCode is HttpStatusCode.Accepted ||
         httpStatusCode is HttpStatusCode.AlreadyReported ||
         httpStatusCode is HttpStatusCode.IMUsed ||
         httpStatusCode is HttpStatusCode.MultiStatus ||
         httpStatusCode is HttpStatusCode.NonAuthoritativeInformation ||
         httpStatusCode is HttpStatusCode.PartialContent ||
         httpStatusCode is HttpStatusCode.ResetContent;


  }

